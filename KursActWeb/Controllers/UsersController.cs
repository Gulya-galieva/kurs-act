using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using DbManager;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace KursActWeb.Controllers
{
    public class UsersController : Controller
    {
        StoreContext db;
        public UsersController(StoreContext context)
        {
            db = context;
        }

        [Authorize]
        public IActionResult UsersList()
        {
            //Выпадающий список с ролями
            return View();
        }

        [Authorize]
        public string GetRoles()
        {
            Dictionary<int, string> roles = new Dictionary<int, string>();
            db.Roles.ToList().ForEach(r =>
            {
                string roleNameRU = r.Name;
                if (roleNameRU == "administrator") roleNameRU = "Администраторы";
                if (roleNameRU == "storekeeper") roleNameRU = "Кладовщики";
                if (roleNameRU == "tuner") roleNameRU = "Настройщики";
                if (roleNameRU == "engineer") roleNameRU = "Инженеры";
                if (roleNameRU == "mounter") roleNameRU = "Монтажники";
                if (roleNameRU == "curator") roleNameRU = "Кураторы";

                roles.Add(r.Id, roleNameRU + " [" + r.Users.Count() + "]");
            });
            return JsonConvert.SerializeObject(roles);
        }

        [Authorize]
        public IActionResult GetRoleUsersTable(int id)
        {
            return View("_usersTable", db.Roles.Find(id).Users);
        }

        [Authorize]
        public string UserInfo(int id)
        {
            var user = db.Users.Find(id);
            if (user != null)
                return JsonConvert.SerializeObject(new { user.Id, user.Name, user.Login, user.Email, user.RoleId, user.WorkerID });
            else
                return "{ }";
        }
        public class PostUserModel
        {
            public string Email { get; set; }
            public int Id { get; set; }
            public string Login { get; set; }
            public string Name { get; set; }
        }

        [Authorize]
        [HttpPost]
        public void UpdateUserInfo([FromBody] JObject data)
        {
            var user = data.ToObject<User>();
            UsersManager um = new UsersManager(db);
            um.UpdateUserInfo(user.Id, user.Login, user.Email, user.Name);
        }

        [Authorize]
        [HttpPost]
        public void UpdateUserRole([FromBody] JObject data)
        {
            var user = data.ToObject<User>();
            UsersManager um = new UsersManager(db);
            um.UpdateRole(user.Id, (int)user.RoleId);
        }
        [Authorize]
        [HttpPost]
        public void NewPass([FromBody] JObject data)
        {
            var user = data.ToObject<User>();
            UsersManager um = new UsersManager(db);
            um.UpdatePass(user.Id, user.Password);
        }

        [Authorize]
        [HttpPost]
        public void AddNewUser([FromBody] JObject data)
        {
            var user = data.ToObject<User>();
            UsersManager um = new UsersManager(db);
            um.AddUser(user);
        }

        [Authorize]
        [HttpPost]
        public void DeleteUser([FromBody] JObject data)
        {
            var user = data.ToObject<User>();
            UsersManager um = new UsersManager(db);
            um.DeleteUser(user.Id);
        }
    }
}