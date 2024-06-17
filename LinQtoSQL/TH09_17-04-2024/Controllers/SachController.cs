using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TH09_17_04_2024.Models;
namespace TH09_17_04_2024.Controllers
{
    public class SachController : Controller
    {
        //
        // GET: /Sach/
        QuanLyBanSachDataContext db = new QuanLyBanSachDataContext();
        public ActionResult SachAll()
        {
            return View(db.Saches.ToList());
        }
        public ActionResult XemChiTiet(int ms)
        {
            Sach sach = db.Saches.Single(s => s.MaSach == ms);
            if (sach == null){
                return HttpNotFound();
            }
            return View(sach);
        }
        public ActionResult TimSach(string txt_Search)
        {
            var ListTimS = db.Saches.Where(s => s.TenSach.Contains(txt_Search)).ToList();
            if (ListTimS.Count() == 0)
            {
                ViewBag.TB = "Không tìm thấy";
            }
            return View(ListTimS);
        }
	}
}