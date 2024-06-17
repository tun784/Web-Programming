using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TranMinhKhanh_2033216449_KT2.Models;

namespace TranMinhKhanh_2033216449_KT2.Controllers
{
    public class NguoiDungController : Controller
    {
        // GET: NguoiDung
        KTLan2_DTDDDataContext db = new KTLan2_DTDDDataContext();
        public ActionResult DangKy()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DangKy(KhachHang KH)
        {
            ViewData["DK"] = KH;
            if (!ModelState.IsValid)
            {
                return View(KH);
            }
            else
            {
                db.KhachHangs.InsertOnSubmit(KH);
                db.SubmitChanges();
                return RedirectToAction("DangNhap", "NguoiDung");
            }
        }
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(KhachHang KH)
        {
            ViewData["DangNhap"] = KH;
            var user = db.KhachHangs.FirstOrDefault(u => u.TaiKhoan == KH.TaiKhoan && u.MatKhau == KH.MatKhau);

            if (user != null)
            {
                // Đăng nhập thành công, thực hiện các thao tác cần thiết (ví dụ: lưu thông tin người dùng vào session)
                Session["User"] = new KhachHang()
                {
                    MaKH = KH.MaKH,
                    TaiKhoan = KH.TaiKhoan,
                    MatKhau = KH.MatKhau,
                    HoTen = KH.HoTen,
                };

                ViewData["ThanhCong"] = "Đăng nhập thành công";
                return RedirectToAction("TrangChu", "SanPham"); // Chuyển hướng đến trang Dashboard hoặc trang khác
            }

            else
            {
                ViewData["ThatBai"] = "Sai tên tài khoản hoặc mật khẩu, vui lòng nhập lại!";
                ModelState.AddModelError("", "Tài khoản hoặc mật khẩu không đúng");
                return View(KH);
            }
        }
    }
}
