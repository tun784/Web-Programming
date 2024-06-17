using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bai123_Form.Models;

namespace Bai123_Form.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string txt_FullName, string txt_ID, string txt_Email, string File_Image, string t_Note, string Chk1, string Chk2, string Chk3, string optRadios, string sc)
        {
            Session["info"] = new Information() {
                FullName = txt_FullName,
                IdStudent = txt_ID,
                Email = txt_Email,
                FileImage = File_Image,
                Note = t_Note,
                Check1 = Chk1,
                Check2 = Chk2,
                Check3 = Chk3,
                ChooseWorkTime = optRadios,
                SelectCourse = sc
            };

            return RedirectToAction("MHXacNhan", "Home");
        }
        public ActionResult MHXacNhan()
        {
            return View();
        }

        public ActionResult Index_DataAnnotation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index_DataAnnotation(Information2 inf)
        {
            //if (ModelState.IsValid)
            //{
                Session["info"] = new Information2()
                {
                    FullName = inf.FullName,
                    IdStudent = inf.IdStudent,
                    Email = inf.Email,
                    FileImage = inf.FileImage,
                    Check1 = inf.Check1,
                    Check2 = inf.Check2,
                    Check3 = inf.Check3,
                    ChooseWorkTime = inf.ChooseWorkTime,
                    Note = inf.Note,
                    SelectCourse = inf.SelectCourse
                };
                return RedirectToAction("MHXacNhan2", "Home", inf);
            //}
            //else
            //    return View(inf);
        }
        public ActionResult MHXacNhan2()
        {
            return View();
        }
	}
}