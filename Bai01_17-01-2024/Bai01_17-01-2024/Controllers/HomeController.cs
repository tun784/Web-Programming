using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai01_17_01_2024.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            if (Session["UserName"] == null)
                return RedirectToAction("DangNhap", "DN");
            return View();
        }








        public ActionResult HomePage()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public string Index0(string id, string name, string age)
        {
            return "ID = " + id + "; Name = " + name + "; Age = " + age;
        } //http://localhost:51390/Home/Index/10?name=Tun&age=20
        public string Index1()
        {
            return "ID: " + Request.QueryString["id"] + "; NAME: " + Request.QueryString["name"] + "; AGE: " + Request.QueryString["age"];
        } //http://localhost:51390/Home/Index1/?id=10&name=Tun&age=20
        public ActionResult Index2()
        {
            ViewData["id"] = Request.QueryString["id"];
            ViewData["height"] = Request.QueryString["height"];
            ViewBag.name = Request.QueryString["name"];
            ViewBag.age = Request.QueryString["age"];

            return View();
        } //http://localhost:51390/Home/Index2/?id=9&name=Tun&age=20&height=170

	}
}