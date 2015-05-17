using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootStrapExample.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CustomerRequests()
        {
            ViewBag.UserName = "Nikhil";
            @ViewBag.Version = "9.1.5.5";
            return View();
        }

        public ActionResult CustomerRequestsMVC()
        {
            ViewBag.UserName = "Nikhil";
            @ViewBag.Version = "9.1.5.5";
            return View();
        }

    }
}