using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DbManager;
using System.IO;
using KursActWeb.Models;
using Microsoft.AspNetCore.Hosting;
using System.Globalization;

namespace KursActWeb.Controllers
{
    public class GetFileController : Controller
    {
        StoreContext db;
        readonly IHostingEnvironment _env;
        public GetFileController(StoreContext context, IHostingEnvironment env)
        {
            db = context;
            _env = env;
        }

        [Authorize]
        public FileResult GetExcel_PointsInSubstation(int? Id)
        {
            var substation = db.Substations.Find(Id);
            if (substation == null) return null;
            ExcelManager em = new ExcelManager();
            return File(em.PointsInSubstationPNR(substation), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", substation.Name + "_" + DateTime.Now.ToShortDateString() + ".xlsx");
        }

        [Authorize]
        public FileResult GetExcel_ConsumersInESKBFile(int? Id)
        {
            var substation = db.Substations.Find(Id);
            if (substation == null) return null;
            ExcelManager em = new ExcelManager();
            return File(em.ConsumersInESKBFile(substation), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", substation.Name + "_с_договорами_" + DateTime.Now.ToShortDateString() + ".xlsx");
        }

        [Authorize]
        public FileResult GetExcel_NoConsumersInESKBFile(int? Id)
        {
            var substation = db.Substations.Find(Id);
            if (substation == null) return null;
            ExcelManager em = new ExcelManager();
            return File(em.NoConsumersInESKBFile(substation), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", substation.Name + "_без_договоров_" + DateTime.Now.ToShortDateString() + ".xlsx");
        }

        //Скачать набор актов допуска на дату одним файлом
        [Authorize]
        public FileResult GetExcel_Act(int Id)
        {
            ExcelManager em = new ExcelManager(_env);
            return File(em.Act(Id).Data, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Акт допуска " + Id.ToString() + ".xlsx");
        }

        //Скачать набор актов допуска на дату одним файлом
        [Authorize]
        public FileResult GetExcel_Acts(string inviteDate)
        {
            ExcelManager em = new ExcelManager(_env);
            var date = DateTime.ParseExact(inviteDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var file = em.Acts(date);
            return File(file.Data, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", file.Name);
        }

        //Скачать набор писем на дату одним файлом
        [Authorize]
        public FileResult GetExcel_Letters(string inviteDate)
        {
            ExcelManager em = new ExcelManager(_env);
            var date = DateTime.ParseExact(inviteDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var file = em.Letters(date);
            return File(file.Data, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",file.Name );
        }

        //Скачать одно письмо приглашение
        [Authorize]
        public FileResult GetExcel_Letter(int id)
        {
            ExcelManager em = new ExcelManager(_env);
            var file = em.Letter(id);
            return File(file.Data, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", file.Name);
        }

        [Authorize]
        public FileResult GetExcel_LettersReestrToPostSite(string inviteDate)
        {
            ExcelManager em = new ExcelManager(_env);
            var date = DateTime.ParseExact(inviteDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var file = em.LettersReestrToPostSite(date);
            return File(file.Data, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", file.Name);
        }

        [Authorize]
        public FileResult GetExcel_RequestReestrToInsertPu(string inviteDate)
        {
            ExcelManager em = new ExcelManager(_env);
            var date = DateTime.ParseExact(inviteDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var file = em.RequestReestrToInsertPu(date);
            return File(file.Data, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", file.Name);
        }

        [Authorize]
        public FileResult GetExcel_TransferredReestrActsAdmission(string inviteDate)
        {
            ExcelManager em = new ExcelManager(_env);
            var date = DateTime.ParseExact(inviteDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var file = em.TransferredReestrActsAdmission(date);
            return File(file.Data, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", file.Name);
        }

        [Authorize]
        public FileResult GetExcel_PaymentReport(int id)
        {
            ExcelManager em = new ExcelManager(_env);
            var file = em.PaymentReport(id);
            return File(file.Data, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", file.Name);
        }

        [Authorize]
        public FileResult GetExcel_UspdExport(int id)
        {
            ExcelManager em = new ExcelManager(_env);
            var file = em.ExportReportForUSPD(id);
            return File(file.Data, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", file.Name);
        }
    }
}