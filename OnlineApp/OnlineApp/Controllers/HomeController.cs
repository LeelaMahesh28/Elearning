using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AdminView()
        {
            ViewBag.Message = "ADMIN PAGE";
            return View();
        }

        public ActionResult UserView()
        {
            ViewBag.Message = "USER PAGE";
            return View();
        }
    }
}