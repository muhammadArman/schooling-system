﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class homeController : Controller
    {
        // GET: home
        public ActionResult Index()
        {
            ViewBag.a = "hello";
            return View();
        }
    }
}