using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai1_HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult HomePage()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }

        public string Index(string id, string name, string age)
        {
            return "ID = " + id + "; Name = " + name + "; Age = " + age;
        } // Home/Index/10?name=Tun&age=20
        public string Index2()
        {
            return "ID: " + Request.QueryString["id"] + "; NAME: " + Request.QueryString["name"] + "; AGE: " + Request.QueryString["age"];
        } // Home/Index2/?id=10&name=Tun&age=20
        public ActionResult Index3()
        {
            ViewData["id"]     = Request.QueryString["id"];
            ViewData["height"] = Request.QueryString["height"];
            ViewBag.name       = Request.QueryString["name"];
            ViewBag.age        = Request.QueryString["age"];

            return View();
        } // Home/Index3/?id=9&name=Tun&age=20&height=170
	}
}