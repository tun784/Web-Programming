using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KiemTraGiuaKyLan2.Models;

namespace KiemTraGiuaKyLan2.Controllers
{
    public class TinTucPartialController : Controller
    {
        // GET: TinTucPartial
        KTLan2_DTDDDataContext db = new KTLan2_DTDDDataContext();
        public ActionResult TinTucPartial()
        {
            var listTinTuc = db.LoaiTins.Take(5).ToList();
            return View(listTinTuc);
        }
    }
}