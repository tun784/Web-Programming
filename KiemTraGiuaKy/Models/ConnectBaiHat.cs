using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using KiemTraGiuaKy.Models;

namespace KiemTraGiuaKy.Models
{
    public class ConnectBaiHat
    {
        public string conStr = ConfigurationManager.ConnectionStrings["Connect1"].ConnectionString;
        public List<BaiHat> getData()
        {
            List<BaiHat> listBaiHat = new List<BaiHat>();
            SqlConnection con = new SqlConnection(conStr);
            string sql = "Select * from tbl_BaiHat";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader(); // ExecuteScalar ; NonQuery
            while (rdr.Read())
            {
                BaiHat emp = new BaiHat();
                emp.MaBH = Convert.ToInt32(rdr.GetValue(0).ToString());
                emp.TenBH= rdr.GetValue(1).ToString();
                emp.MaTL= Convert.ToInt32(rdr.GetValue(2).ToString());
                emp.MaNS= Convert.ToInt32(rdr.GetValue(3).ToString());

                listBaiHat.Add(emp);
            }
            con.Close();
            return (listBaiHat);
        }
    }
}