using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TranMinhKhanh_2033216449_KT2.Models
{
    public class GioHang
    {
        KTLan2_DTDDDataContext db = new KTLan2_DTDDDataContext();
        public int iMaSP { get; set; }
        public string sTenSP { get; set; }
        public string sAnh { get; set; }
        public double dGiaBan { get; set; }
        public int iSoLuong { get; set; }
        public double dThanhTien
        {
            get { return iSoLuong * dGiaBan; }
        }

        // Khởi tạo giỏ hàng
        public GioHang(int MaSP)
        {
            iMaSP = MaSP;
            SanPham sp = db.SanPhams.Single(s => s.MaSP == iMaSP);
            sTenSP = sp.TenSP;
            sAnh = sp.Anh;
            dGiaBan = double.Parse(sp.GiaBan.ToString());
            iSoLuong = 1;
        }
    }
}