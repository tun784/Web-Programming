using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KiemTraGiuaKyLan2.Models;

namespace KiemTraGiuaKyLan2.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: SanPham
        KTLan2_DTDDDataContext db = new KTLan2_DTDDDataContext();
        //SanPhamApiController sp_Api = new SanPhamApiController();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TrangChu()
        {
            var listTrangchu = db.SanPhams.ToList();
            return View(listTrangchu);
        }
        public ActionResult SanPhamTheoLoai(int MaLoai)
        {
            // Lấy danh sách sách theo chủ đề MaCD và sắp xếp theo giá bán tăng dần
            var PKTheoLoai = db.SanPhams.Where(s => s.MaLoai == MaLoai).ToList();

            // Trả về view SachTheoCD với danh sách sách đã lấy được
            if (PKTheoLoai.Count == 0)
                ViewBag.KhongCo = "Không có sản phẩm nào thuộc loại này!";

            return View(PKTheoLoai);
        }
        public ActionResult XemChitiet(int msp)
        {
            var Masp = db.SanPhams.SingleOrDefault(s => s.MaSP == msp);
            return View(Masp);
        }
        //public ActionResult ShowDataSp()
        //{
        //    List<SanPhamMix> listSP = sp_Api.GetListSanPhamsInfo();
        //    return View(listSP);
        //}
        //public ActionResult ShowDetailsSp(int id)
        //{
        //    SanPhamMix sp = sp_Api.GetSanPham(id);
        //    return View(sp);
        //}
    }
}