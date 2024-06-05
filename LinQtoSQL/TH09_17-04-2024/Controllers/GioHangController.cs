using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.DateTime;
using TH09_17_04_2024.Models;
namespace TH09_17_04_2024.Controllers
{
    public class GioHangController : Controller
    {
        QuanLyBanSachDataContext db = new QuanLyBanSachDataContext();
        public List<GioHang> LayGioHang()
        {
            List<GioHang> lstGioHang = Session["GioHang"] as List<GioHang>;
            if (lstGioHang == null)
            {
                // nếu lstGioHang chưa tồn tại thì khởi tạo
                lstGioHang = new List<GioHang>();
                Session["GioHang"] = lstGioHang;
            }
            return lstGioHang;
        }
        public ActionResult ThemGioHang(int ms, string strURL)
        {
            List<GioHang> lstGioHang = LayGioHang();
            // Kiểm tra sách này có tồn tại trong Session["GioHang"] chưa ?
            GioHang SanPham = lstGioHang.Find(sp => sp.iMaSach == ms);
            if (SanPham == null)
            {
                SanPham = new GioHang(ms);
                lstGioHang.Add(SanPham);
                return Redirect(strURL);
            }
            else
            {
                SanPham.iSoLuong++;
                return Redirect(strURL);
            }
        }
        private int TongSoLuong()
        {
            int tsl = 0;
            List<GioHang> lstGioHang = Session["GioHang"] as List<GioHang>;
            if (lstGioHang != null)
                tsl += lstGioHang.Sum(sp => sp.iSoLuong);
            return tsl;
        }
        private double TongThanhTien()
        {
            double ttt = 0;
            List<GioHang> lstGioHang = Session["GioHang"] as List<GioHang>;
            if (lstGioHang != null)
                ttt += lstGioHang.Sum(sp => sp.dThanhTien);
            return ttt;
        }
        public ActionResult GioHang()
        {
            if (Session["GioHang"] == null)
                return RedirectToAction("SachAll", "Sach");
            List<GioHang> lstGioHang = LayGioHang();
            ViewBag.TongSoLuong = TongSoLuong();
            ViewBag.TongThanhTien = TongThanhTien();
            return View(lstGioHang);
        }
        public ActionResult GioHangPartial()
        {
            ViewBag.TongSoLuong = TongSoLuong();
            ViewBag.TongThanhTien = TongThanhTien();
            return PartialView();
        }
        public ActionResult XoaGioHang(int MaSP)
        {
            List<GioHang> lstGioHang = LayGioHang();
            GioHang sp = lstGioHang.Single(s => s.iMaSach == MaSP);
            if (sp != null)
            {
                lstGioHang.RemoveAll(s => s.iMaSach == MaSP);
                return RedirectToAction("GioHang", "GioHang");
            }
            if (lstGioHang.Count == 0)
                return RedirectToAction("SachAll", "Sach");
            return RedirectToAction("GioHang", "GioHang");
        }
        public ActionResult XoaGioHang_All()
        {
            List<GioHang> lstGioHang = LayGioHang();
            lstGioHang.Clear();
            return RedirectToAction("SachAll", "Sach");
        }
        public ActionResult CapNhatGioHang(int MaSP, FormCollection f)
        {
            List<GioHang> lstGioHang = LayGioHang();
            GioHang sp = lstGioHang.Single(s => s.iMaSach == MaSP);
            if (sp != null)
                sp.iSoLuong = int.Parse(f["txtSoLuong"].ToString());
            return RedirectToAction("GioHang", "GioHang");
        }
        [HttpGet]
        public ActionResult DatHang()
        {
            if (Session["taikhoan"] == null)
                return RedirectToAction("DangNhap", "NguoiDung");
            if (Session["GioHang"] == null)
                return RedirectToAction("SachPartial", "Sach");
            List<GioHang> lstGioHang = LayGioHang();
            ViewBag.TongSoLuong = TongSoLuong();
            ViewBag.TongThanhTien = TongThanhTien();
            return View(lstGioHang);
        }
        [HttpPost]
        public ActionResult DatHang(FormCollection f)
        {
            // Thêm đơn hàng
            DonHang ddh = new DonHang();
            KhachHang kh = (KhachHang)Session["taikhoan"];
            List<GioHang> gh = LayGioHang();
            ddh.MaKH = kh.MaKH;
            ddh.NgayDat = DateTime.Now;
            var ngaygiao = String.Format("{0:MM/dd/yyyy)", f["NgayGiao"]);
            ddh.NgayGiao = DateTime.Parse(ngaygiao);
            ddh.TinhTrangGiaoHang = 0;
            ddh.DaThanhToan = "Chua";
            db.DonHangs.InsertOnSubmit(ddh);
            db.SubmitChanges();
            // Thêm chi tiết đơn hàng
            foreach (var item in gh)
            {
                ChiTietDonHang ctDH = new ChiTietDonHang();
                ctDH.MaDonHang = ddh.MaDonHang;
                ctDH.MaSach = item.iMaSach;
                ctDH.SoLuong = item.iSoLuong;
                ctDH.DonGia = (decimal)item.dDonGia;
                db.ChiTietDonHangs.InsertOnSubmit(ctDH);
            }
            db.SubmitChanges();
            Session["GioHang"] = null;
            return RedirectToAction("XacNhanDonHang", "GioHang");
        }
        public ActionResult XacNhanDonHang()
        {
            return View();
        }
    }
}