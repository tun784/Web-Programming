using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai1_MVC.Controllers
{
    public class Employee
    {
        public int MaNV;
        public string TenNV, GT, Hinh;

        public Employee()
        {
            MaNV = 101;
            TenNV = "Mr. Trung";
            GT = "Nam";
            Hinh = "NV01.jpg";
        }
    }
}