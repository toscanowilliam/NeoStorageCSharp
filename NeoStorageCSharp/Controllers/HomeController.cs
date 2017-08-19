﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NeoStorageCSharp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new Database.Database();
            db.Database.CreateIfNotExists();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}