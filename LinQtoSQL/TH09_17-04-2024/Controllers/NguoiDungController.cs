using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TH09_17_04_2024.Models;
namespace TH09_17_04_2024.Controllers
{
    public class NguoiDungController : Controller
    {
        //
        // GET: /NguoiDung/
        QuanLyBanSachDataContext db = new QuanLyBanSachDataContext();
        [HttpGet]
        public ActionResult DangKy(){
            return View();
        }
        [HttpPost]
        public ActionResult DangKy(KhachHang kh, FormCollection f){
            var hoten = f["HotenKH"];
            var tendn = f["TenDN"];
            var matkhau = f["Matkhau"];
            var rematkhau = f["ReMatkhau"];
            var dienthoai = f["Dienthoai"];
            var ngaysinh = String.Format("{0:MM/DD/YYYY}", f["NgaySinh"]);
            var email = f["Email"];
            var diachi = f["Diachi"];
            if (String.IsNullOrEmpty(hoten))            
                ViewData["Loi1"] = "Họ Tên không được bỏ trống";
            if (String.IsNullOrEmpty(tendn))            
                ViewData["Loi2"] = "Tên đăng nhập không bỏ trống";
            if (String.IsNullOrEmpty(matkhau))            
                ViewData["Loi3"] = "Vui lòng nhập mật khẩu";
            if (String.IsNullOrEmpty(rematkhau))            
                ViewData["Loi4"] = "Vui lòng nhập mật khẩu";
            if (String.IsNullOrEmpty(dienthoai))            
                ViewData["Loi5"] = "Vui lòng nhập số điện thoại";
            if (!String.IsNullOrEmpty(hoten) && !String.IsNullOrEmpty(tendn) && !String.IsNullOrEmpty(matkhau) && !String.IsNullOrE
            {
                // Gán giá trị cho đối tượng kh
                kh.HoTen = hoten;
                kh. TaiKhoan = tendn;
                kh.MatKhau = matkhau;
                kh.NgaySinh = DateTime.Parse(ngaysinh);
                kh.DiaChi = diachi;
                kh.Email = email;
                //Kiem Tra Trung TenDN
                KhachHang cus = db.KhachHangs.SingleOrDefault(c => c.TaiKhoan == tendn);
                if (cus == null){
                    // Ghi xuống CSDL
                    db.KhachHangs.InsertOnSubmit(kh);
                    db.SubmitChanges();
                    return RedirectToAction("DangNhap", "NguoiDung");
                }
                else
                    ViewBag.TB = "Tài khoản đã tồn tại !";                
            }
            return View();
        }

        [HttpGet]
        public ActionResult DangNhap(){
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(FormCollection f){
            // Khai báo các biến nhận giá trị từ form f
            var tendn = f["TenDN"];
            var matkhau = f["Matkhau"];
            if (String.IsNullOrEmpty(tendn))
                ViewData["Loi1"] = "Tên đăng nhập không bỏ trống";
            if (String.IsNullOrEmpty(matkhau))
                ViewData["Loi2"] = "Vui lòng nhập mật khẩu";
            if (!String.IsNullOrEmpty(tendn) && !String.IsNullOrEmpty(matkhau)){
                KhachHang kh = db.KhachHangs.SingleOrDefault(c => c.TaiKhoan == tendn && c.MatKhau == matkhau);
                if (kh != null){
                    ViewBag.TB = "Đăng nhập thành công !!!";
                    Session["taikhoan"] = kh;
                    return RedirectToAction("SachPartial", "Sach");
                }
                else
                    ViewBag.TB = "Sai tên đăng nhập hoặc sai mật khẩu, vui lòng nhập lại";
            }
            return View();
        }
    }