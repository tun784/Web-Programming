using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KiemTraGiuaKyLan2.Models;

namespace KiemTraGiuaKyLan2.Controllers
{
    public class GioHangController : Controller
    {
        // GET: GioHang
        KTLan2_DTDDDataContext db = new KTLan2_DTDDDataContext();
        public List<GioHang> LayGioHang()
        {
            List<GioHang> lstGioHang = Session["GioHang"] as List<GioHang>;
            if (lstGioHang == null)
            {
                lstGioHang = new List<GioHang>();
                Session["GioHang"] = lstGioHang;
            }
            return lstGioHang;
        }
        public ActionResult ThemGioHang(int ms, string strURL)
        {
            // Lấy ra giỏ hàng

            List<GioHang> lstGioHang = LayGioHang();

            // Kiểm tra sách này có tồn tại trong trong Session["GioHang"] chưa ?

            GioHang SanPham = lstGioHang.Find(sp => sp.iMaSP == ms);

            if (SanPham == null) // Chưa có trong giỏ
            {
                SanPham = new GioHang(ms);

                lstGioHang.Add(SanPham);

                //return Redirect(strURL);

                return RedirectToAction("GioHang");
            }

            else // Đã có sản phẩm này trong giỏ
            {
                SanPham.iSoLuong++;

                //return Redirect(strURL);

                return RedirectToAction("GioHang");

            }
        }

        // Tổng số lượng

        private int TongSoLuong()
        {
            int tsl = 0;

            List<GioHang> lstGiohang = Session["GioHang"] as List<GioHang>;

            if (lstGiohang != null)
                tsl = lstGiohang.Sum(sp => sp.iSoLuong);

            return tsl;
        }

        // Tổng thành tiền

        private double TongThanhTien()
        {
            double ttt = 0;

            List<GioHang> lstGioHang = Session["GioHang"] as List<GioHang>;

            if (lstGioHang != null)
                ttt += lstGioHang.Sum(sp => sp.dThanhTien);

            return ttt;
        }

        // Xây dựng trang giỏ hàng

        public ActionResult GioHang()
        {
            if (Session["GioHang"] == null)
                return View();

            List<GioHang> lstGioHang = LayGioHang();

            ViewBag.TongSoLuong = TongSoLuong();

            ViewBag.TongThanhTien = TongThanhTien();

            return View(lstGioHang);
        }


        public ActionResult XoaGioHang(int MaSP)
        {
            // Lấy Giỏ Hàng

            List<GioHang> lstGioHang = LayGioHang();

            // Kiểm tra xem sách cần xóa có trong giỏ hàng không?

            GioHang sp = lstGioHang.Single(s => s.iMaSP == MaSP);

            // Nếu có thì tiến hành xóa

            if (sp != null)
            {
                lstGioHang.RemoveAll(s => s.iMaSP == MaSP);
                return RedirectToAction("GioHang", "GioHang");
            }

            // Nếu giỏ hàng rỗng

            if (lstGioHang.Count == 0)
                return RedirectToAction("Index", "Home");

            return RedirectToAction("GioHang", "GioHang");
        }
        public ActionResult XoaAllGioHang()
        {
            // Lấy giỏ hàng

            List<GioHang> lstGioHang = LayGioHang();

            lstGioHang.Clear();

            return RedirectToAction("TrangChu", "SanPham");
        }

        public ActionResult CapNhatGioHang(int MaSP, FormCollection f)
        {
            // Lấy giỏ hàng

            List<GioHang> lstGioHang = LayGioHang();

            // Kiểm tra xem sách cần cập nhật có trong giỏ hàng không ?

            GioHang sp = lstGioHang.Single(s => s.iMaSP == MaSP);

            // Nếu có thì tiến hành cập nhật 

            if (sp != null)
                sp.iSoLuong = int.Parse(f["txtSoLuong"].ToString());

            return RedirectToAction("GioHang", "GioHang");
        }
        [HttpGet]
        public ActionResult DatHang()
        {
            if (Session["User"] == null)
                return RedirectToAction("DangNhap", "NguoiDung");
            else if (Session["GioHang"] == null)
                return RedirectToAction("SachPartial", "Sach");
            List<GioHang> lstGioHang = LayGioHang();
            ViewBag.TongSoLuong = TongSoLuong();
            ViewBag.TongThanhTien = TongThanhTien();

            // Lấy thông tin khách hàng từ Session và truyền vào ViewBag
            KhachHang kh = Session["User"] as KhachHang;

            // Lấy thông tin HoTen của khách hàng dựa trên tài khoản
            string hoTenKhachHang = db.KhachHangs
                .Where(khachHang => khachHang.TaiKhoan == kh.TaiKhoan)
                .Select(khachHang => khachHang.HoTen)
                .FirstOrDefault();

            string DiaChi = db.KhachHangs
                .Where(khachHang => khachHang.TaiKhoan == kh.TaiKhoan)
                .Select(khachHang => khachHang.DiaChi)
                .FirstOrDefault();

            string DienThoai = db.KhachHangs
                .Where(khachHang => khachHang.TaiKhoan == kh.TaiKhoan)
                .Select(khachHang => khachHang.DienThoai)
                .FirstOrDefault();

            ViewBag.TenKhachHang = hoTenKhachHang;

            ViewBag.DiaChi = DiaChi;

            ViewBag.DienThoai = DienThoai;

            return View(lstGioHang);
        }
        [HttpPost]
        public ActionResult DatHang(FormCollection f)
        {
            DonHang ddh = new DonHang();
            KhachHang kh = (KhachHang)Session["User"];
            List<GioHang> gh = LayGioHang();
            ddh.MaKH = kh.MaKH + 1;
            ddh.NgayDat = DateTime.Now;
            var NgayGiao = String.Format("{0:MM/dd/yyyy}", f["NgayGiao"]);
            //ddh.NgayGiao = DateTime.Parse(NgayGiao);
            ddh.TinhTrangGiaoHang = 0;
            ddh.DaThanhToan = "Chưa";
            db.DonHangs.InsertOnSubmit(ddh);
            db.SubmitChanges();
            foreach (var item in gh)
            {
                ChiTietDonHang ctDH = new ChiTietDonHang();
                ctDH.MaDonHang = ddh.MaDonHang;
                ctDH.MaSP = item.iMaSP;
                ctDH.SoLuong = item.iSoLuong;
                ctDH.DonGia = (decimal)item.dGiaBan;
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
