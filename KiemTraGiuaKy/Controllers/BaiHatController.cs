using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using KiemTraGiuaKy.Models;
namespace KiemTraGiuaKy.Controllers
{
    public class BaiHatController : Controller
    {
        public string conStr = ConfigurationManager.ConnectionStrings["Connect1"].ConnectionString;
        //
        // GET: /BaiHat/
        public ActionResult HomePage()
        {
            return View();
        }
        public ActionResult DangKy()
        {
            return View();
        
        }
        [HttpPost]
        public ActionResult DangKy(string Username, string Password, string RetypePassword)
        {
            try
            {
                if (!Password.Equals(RetypePassword))
                {
                    ModelState.AddModelError("", "Mật khẩu nhập lại không khớp.");
                    return View();
                }
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();

                    string sqlInsert1 = "INSERT INTO tbl_User(UserName, Password) VALUES('" + Username + "', '" + Password + "');";
                    SqlCommand sqlCommand = new SqlCommand(sqlInsert1, con);
                    int rowAffected1 = sqlCommand.ExecuteNonQuery();
                    con.Close();

                    if (rowAffected1 > 0)
                    {
                        return RedirectToAction("HomePage", "BaiHat");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Đăng ký thất bại. Vui lòng thử lại sau.");
                        return View();
                    }
                }

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Đã xảy ra lỗi khi đăng ký, xin đăng nhập lại sau");
                return View();
            }
        }
        public ActionResult LoadSongByAlbum(int idAb)
        {
            List<BaiHat> listBaiHat = new List<BaiHat>();
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    string SQL = "SELECT tbl_BaiHat.* FROM tbl_BaiHat, tbl_ChiTietAlbum WHERE tbl_ChiTietAlbum.MaAB = @idAb AND tbl_ChiTietAlbum.MaBH = tbl_BaiHat.MaBH";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(SQL, con);
                    cmd.Parameters.AddWithValue("@IdAb", idAb);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        BaiHat baiHat = new BaiHat();
                        baiHat.MaBH = Convert.ToInt32(reader["MaBH"].ToString());
                        baiHat.TenBH = reader["TenBH"].ToString();
                        baiHat.MaTL = Convert.ToInt32(reader["MaTL"].ToString());
                        baiHat.MaNS = Convert.ToInt32(reader["MaNS"].ToString());
                        listBaiHat.Add(baiHat);
                    }
                }
                ViewBag.IdAB = idAb;
                return View(listBaiHat);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }
        public ActionResult CreateAlbum(FormCollection fc)
        {
            try
            {
                string TenAlbum = fc["TenAlbum"];
                string AnhBia = fc["AnhBia"];

                using (SqlConnection con = new SqlConnection())
                {
                    con.ConnectionString = conStr;
                    con.Open();

                    string sql = "INSERT INTO tbl_Album (TenAlbum, AnhBia)";
                    sql += "VALUES (N'" + TenAlbum + "', N'" + AnhBia + "')";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.CommandType = System.Data.CommandType.Text;
                    int rs = cmd.ExecuteNonQuery();
                    con.Close();
                }

                return View();
            }
            catch (Exception ex)
            {
                return HttpNotFound();
            }
        }
        public ActionResult DeleteSongFromAlbum(int idSong, int idAB)
        {
            SqlConnection con = new SqlConnection(conStr);


            string sqlDelete = "DELETE FROM tbl_ChiTietAlbum WHERE MaAB = {idAB} AND MaBH = {idSong}";
            SqlCommand sqlCommand = new SqlCommand(sqlDelete, con);
            sqlCommand.Parameters.AddWithValue("@IdAB", idAB);
            sqlCommand.Parameters.AddWithValue("@IdSong", idSong);
            con.Open();
            int rowAffected = sqlCommand.ExecuteNonQuery();

            if (rowAffected > 0)
            {
                return RedirectToAction("LoadSongByAlbum", "BaiHat", new { idAB = idAB });
            }
            else
            {
                ModelState.AddModelError("", "Xóa bài hát khỏi album không thành công.");
                return View();
            }
            con.Close();
        }
        public ActionResult Album()
        {
            List<Album> ListAlbum = new List<Album>();
            try
            {
                using (SqlConnection con = new SqlConnection())
                {
                    con.ConnectionString = conStr;
                    string SQL = "SELECT * FROM tbl_Album";
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(SQL, con);
                    da.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        var Album = new Album();
                        Album.MaAlbum = row["MaAlbum"].ToString();
                        Album.TenAlbum = row["TenAlbum"].ToString();
                        Album.NgayTao = row["NgayTao"].ToString();
                        Album.AnhBia = row["AnhBia"].ToString();
                        ListAlbum.Add(Album);
                    }
                }
                return View(ListAlbum);
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }
	}
}