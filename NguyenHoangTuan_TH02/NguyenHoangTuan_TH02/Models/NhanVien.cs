using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NguyenHoangTuan_TH02.Controllers
{
    public class NhanVien
    {
        public int MaNV;
        public string TenNV, GT, Hinh;

        public NhanVien()
        {
            MaNV = 101;
            TenNV = "Mr. Trung";
            GT = "Nam";
            Hinh = "NV01.jpg";
        }
    }
}