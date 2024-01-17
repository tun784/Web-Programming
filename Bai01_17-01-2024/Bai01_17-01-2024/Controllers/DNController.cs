using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai01_17_01_2024.Models;

namespace Bai01_17_01_2024.Controllers
{
    public class DNController : Controller
    {
        //
        // GET: /DN/
        [HttpGet]
        public ActionResult DangKy()
        {
            return View();
        }
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangKy(string name, string password, string rt_password)
        {
            if (name.Length >= 5 && password.Length >= 6 && rt_password.Equals(password))
                return RedirectToAction("DangNhap", "DN");
            else
                return View();
        }
        [HttpPost]
        public ActionResult DangNhap(string name, string password)
        {
            if ("yennh".Equals(name) && "123456".Equals(password))
                Session["user"] = new User() {
                    login = name,
                    UserName = "Nguyễn Hải Yến"
                };
            return RedirectToAction("Index", "Home");
        }
	}
}