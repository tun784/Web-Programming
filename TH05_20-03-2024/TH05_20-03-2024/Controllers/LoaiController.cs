using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TH05_20_03_2024.Models;

namespace TH05_20_03_2024.Controllers
{
    public class LoaiController : Controller
    {
        //
        // GET: /Loai/
        public ActionResult ShowCategory1()
        {
            ConnectSanPham LSP = new ConnectSanPham();
            List<LoaiSanPham> Loaisp = LSP.getData1();
            return View(Loaisp);
        }
        public ActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateCategory(FormCollection fc)
        {
            ConnectLoai obj = new ConnectLoai();
            var name = fc["txtTenLoai"];

            int kt = obj.InsertCategory(name);
            if (kt == 1)
                ViewBag.ThongBao = "Thêm thành công";
            else
                ViewBag.ThongBao = "Thêm KHÔNG thành công";
            return View();
        }
	}
}