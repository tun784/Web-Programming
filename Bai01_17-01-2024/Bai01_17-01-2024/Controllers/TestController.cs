using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai01_17_01_2024.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/
        public ActionResult Index()
        {
            Models.Khoa khoacntt = new Models.Khoa();
            return View(khoacntt);
        }
	}
}