using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai1_MVC.Models
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