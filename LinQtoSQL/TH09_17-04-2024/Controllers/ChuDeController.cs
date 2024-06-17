using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TH09_17_04_2024.Models;
namespace TH09_17_04_2024.Controllers
{
    public class ChuDeController : Controller
    {
        //
        // GET: /ChuDe/
        QuanLyBanSachDataContext db = new QuanLyBanSachDataContext();
        public ActionResult ChuDePartial()
        {
            var ListCD = db.ChuDes.OrderBy(cd => cd.TenChuDe).Take(7).ToList();
            return View(ListCD);
        }
        public ActionResult SachTheoChuDe(int cd)
        {
            List<Sach> ListSachCD = db.Saches.Where(s => s.MaChuDe == cd).ToList();
            if (ListSachCD.Count() == 0)
                ViewBag.ThongBao = "Không có sách nào thuộc chủ đề này";
            var chude = db.ChuDes.Single(x => x.MaChuDe == cd);
            ViewBag.TenChuDe = chude.TenChuDe;
            return View(ListSachCD);
        }
	}
}