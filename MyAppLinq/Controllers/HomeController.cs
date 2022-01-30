using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyAppLinq.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Ma page à propos.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Ma page de contact.";

            return View();
        }
    }
}