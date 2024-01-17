using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai01_17_01_2024.Models
{
    public class Khoa
    {
        public string TenKhoa;
        public int NamThanhLap;
        public string Message;
        public Khoa()
        {
            TenKhoa = "Khoa Công Nghệ Thông Tin";
            NamThanhLap = 2003;
            Message = "FIT-HUIT";
        }
    }
}