using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;

namespace TH05_20_03_2024.Models
{
    public class ConnectLoai
    {
        public string conStr = ConfigurationManager.ConnectionStrings["Connect1"].ConnectionString;
        public int InsertCategory(string name)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            int rs = 0;

            //KT trung ten
            string sql1 = "Select count(*) from Loai where TenLoai = '" + name + "'";
            SqlCommand cmd1 = new SqlCommand(sql1, con);
            int kt = (int)cmd1.ExecuteScalar();
            if (kt == 0)
            {
                string sql = "Insert into Loai (TenLoai)";
                sql += "values(N'" + name + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                rs = cmd.ExecuteNonQuery();
            }
            con.Close();
            return rs;
        }
    }
}