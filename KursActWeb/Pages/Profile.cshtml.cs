using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbManager;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace KursActWeb.Pages
{
    [Authorize]
    public class ProfileModel : PageModel
    {
        private readonly StoreContext db;
        public ProfileModel(StoreContext context)
        {
            db = context;
        }

        public string Name { get; set; }

        public void OnGet()
        {
            var user = db.Users.FirstOrDefault(u => u.Login == User.Identity.Name);
            Name = user.Name;
        }
    }
}