﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai4_RealEstate.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult HomePage()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        public ActionResult Services()
        {
            return View();
        }
        public ActionResult Support()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
	}
}