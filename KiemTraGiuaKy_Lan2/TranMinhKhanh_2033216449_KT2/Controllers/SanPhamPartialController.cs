using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TranMinhKhanh_2033216449_KT2.Models;

namespace TranMinhKhanh_2033216449_KT2.Controllers
{
    public class SanPhamPartialController : Controller
    {
        // GET: SanPhamPartial
        KTLan2_DTDDDataContext db = new KTLan2_DTDDDataContext();
        public ActionResult DienThoaiPartial()
        {
            var listDienThoai = db.Loais.Take(6).ToList();
            return View(listDienThoai);
        }
        public ActionResult LapTopPartial()
        {
            var listLapTop = db.Loais.Skip(6).Take(6).ToList();
            return View(listLapTop);
        }
        public ActionResult PhuKienPartial()
        {
            var listPhuKien = db.Loais.Skip(12).ToList();
            return View(listPhuKien);
        }
        public ActionResult TinTucPartial()
        {
            var listTinTuc = db.TinTucs.Take(5).ToList();
            return View(listTinTuc);
        }
    }
}