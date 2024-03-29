using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TH05_20_03_2024.Models;

namespace TH05_20_03_2024.Controllers
{
    public class SanPhamController : Controller
    {
        //
        // GET: /SanPham/
        public ActionResult ShowProductsBySanPham()
        {
            ConnectSanPham objSP = new ConnectSanPham();
            List<SanPham> listsp = objSP.getData();
            return View(listsp);
        }
        public ActionResult ShowProductsByLoaiSanPham()
        {
            ConnectSanPham LSP = new ConnectSanPham();
            List<LoaiSanPham> Loaisp = LSP.getData1();
            return View(Loaisp);
        }
        public ActionResult SearchProductGet()
        {
            ConnectSanPham objSP = new ConnectSanPham();
            List<SanPham> listSP = objSP.getData();
            ViewBag.SL = listSP.Count();
            return View(listSP);
        }
        public ActionResult SearchProduct(string txt_Search)
        {
            ConnectSanPham objSP = new ConnectSanPham();
            List<SanPham> listSP = objSP.Search(txt_Search);
            ViewBag.SL = listSP.Count();
            return View(listSP);
        }
        public ActionResult SortProduct(int DDL_TenSP, int DDL_GiaSP)
        {
            ConnectSanPham objSP = new ConnectSanPham();
            List<SanPham> listSP = objSP.Sort(DDL_TenSP, DDL_GiaSP);
            return View(listSP);
        }
        public ActionResult DeleteProduct(string id)
        {
            ConnectSanPham objSP = new ConnectSanPham();
            objSP.Delete(id);
            return RedirectToAction("ShowProductsBySanPham", "SanPham");
        }
	}
}