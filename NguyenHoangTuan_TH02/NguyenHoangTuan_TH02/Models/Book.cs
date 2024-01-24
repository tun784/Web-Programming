using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NguyenHoangTuan_TH02.Models
{
    public class Sach
    {
        public string MaSach, TenSach, AnhBia;
        public int Gia;

        public Sach(string id, string name, int pri, string avatar) {
            MaSach = id;
            TenSach = name;
            Gia = pri;
            AnhBia = avatar;
        }
    }
}