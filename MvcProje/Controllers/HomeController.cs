﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page..";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Senin iletişim sayfan";

            return View();
        }
        public ActionResult Bilgi()
        {
            return View();
        }

        public ActionResult Profile()
        {
            ViewBag.Message = "Senin profil sayfan.";
            return View();
        }
    }
}