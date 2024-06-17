using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TranMinhKhanh_2033216449_KT2.Models;

namespace TranMinhKhanh_2033216449_KT2.Controllers
{
    public class TinTucController : Controller
    {
        // GET: TinTuc
        KTLan2_DTDDDataContext db = new KTLan2_DTDDDataContext();
        public ActionResult TinTucTheoCD(int MLTin)
        {
            var tinTucTheoCD = db.TinTucs.Where(s => s.MLTin == MLTin).OrderBy(s => s.MLTin).ToList();

            ViewBag.TenTT = db.TinTucs.FirstOrDefault(s => s.MLTin == MLTin).LoaiTin.TLTin.ToString();

            return View(tinTucTheoCD);
        }
        public ActionResult TinTucInfo()
        {
            return View(db.TinTucs.ToList());
        }
    }
}