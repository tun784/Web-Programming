using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai3_KhoaCNTT.Models
{
    public class KhoaModel
    {
        public string TenKhoa;
        public int NamThanhLap;
        public string Message;
        public KhoaModel()
        {
            TenKhoa = "Khoa Công Nghệ Thông Tin";
            NamThanhLap = 2003;
            Message = "FIT-HUIT";
        }
    }
}