using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using WebApp.Common;
using WebApplication3.Models;
using TransactionStatus = WebApp.Common.TransactionStatus;


namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            UserModel model = new UserModel
            {
                FName = "Nikunj",
                LName = "Adhaduk",
                Address = new Address()
                {
                    Street = "152 Queen Mary Blvd",
                    Province = "ON"
                }
            };

            return View("Index", model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            UserModel model = new UserModel
            {
                FName = "Nikunj",
                LName = "Adhaduk",
                Address = new Address()
                {
                    Street = "152 Queen Mary Blvd",
                    Province = "ON"
                }
            };
            ViewBag.Test = "Website";

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult SetLanguage(int id)
        {
            Helper.Helper.CurrentCulture = id;

            return RedirectToAction("Index");
        }

        protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state)
        {
            // Modify current thread's cultures
            Thread.CurrentThread.CurrentCulture = Helper.Helper.culture ?? Helper.Helper.LangCultureInfo;
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

            return base.BeginExecuteCore(callback, state);
        }
    }
}