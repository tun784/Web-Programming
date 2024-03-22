using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;

namespace TH05_20_03_2024.Models
{
    public class ConnectSanPham
    {
        public string conStr = ConfigurationManager.ConnectionStrings["Connect1"].ConnectionString;
        public List<SanPham> getData()
        {
            List<SanPham> listProducts = new List<SanPham>();
            SqlConnection con = new SqlConnection(conStr);
            string sql = "Select * from SanPham";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                SanPham sp = new SanPham();
                sp.Masp = Convert.ToInt32(rdr.GetValue(0).ToString());
                sp.Tensp = rdr.GetValue(1).ToString();
                sp.Hinh = rdr.GetValue(2).ToString();
                sp.Gia = float.Parse(rdr.GetValue(3).ToString());
                sp.Mota = rdr.GetValue(4).ToString();
                sp.Maloai = Convert.ToInt32(rdr.GetValue(5).ToString());

                listProducts.Add(sp);
            }
            con.Close();
            return (listProducts);
        }
        public List<LoaiSanPham> getData1()
        {
            List<LoaiSanPham> listCategoryProducts = new List<LoaiSanPham>();
            SqlConnection con = new SqlConnection(conStr);
            string sql = "select TenLoai, Loai.MaLoai, TenSP, MaSP, DuongDan, Gia, MoTa  from Loai, SanPham where Loai.MaLoai = SanPham.MaLoai";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                LoaiSanPham Loaisp = new LoaiSanPham();
                Loaisp.TenLoai = rdr.GetValue(0).ToString();
                Loaisp.MaLoai = rdr.GetValue(1).ToString();

                listCategoryProducts.Add(Loaisp);
            }
            con.Close();
            return (listCategoryProducts);
        }
        public List<SanPham> Search(string txt_Search)
        {
            List<SanPham> listSP = new List<SanPham>();
            SqlConnection con = new SqlConnection(conStr);
            string sql = "Select * from SanPham where TenSP like '%' + @ten + '%'";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            SqlParameter par = new SqlParameter("@ten", txt_Search);
            cmd.Parameters.Add(par);

            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                SanPham sp = new SanPham();
                sp.Masp = Convert.ToInt32(rdr.GetValue(0).ToString());
                sp.Tensp = rdr.GetValue(1).ToString();
                sp.Hinh = rdr.GetValue(2).ToString();
                sp.Gia = float.Parse(rdr.GetValue(3).ToString());
                sp.Mota = rdr.GetValue(4).ToString();
                sp.Maloai = Convert.ToInt32(rdr.GetValue(5).ToString());

                listSP.Add(sp);
            }
            con.Close();
            return (listSP);
        }
    }
}