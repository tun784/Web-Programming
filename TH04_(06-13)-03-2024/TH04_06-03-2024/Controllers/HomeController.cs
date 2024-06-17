using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using TH04_06_03_2024.Models;
namespace TH04_06_03_2024.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowEmployees()
        {
            List<Employee> listEmployee = new List<Employee>();
            try
            {
                using (SqlConnection con = new SqlConnection())
                {
                    //string conStr = "Data Source=A105PC27;Initial Catalog=QL_NhanSu;Integrated Security=True";
                    string conStr = ConfigurationManager.ConnectionStrings["Connect1"].ConnectionString;
                    con.ConnectionString = conStr;
                    string sql = "Select * from tbl_Employee";
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    da.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        var emp = new Employee();
                        emp.ID = (int)row["Id"];
                        emp.Name = row["Name"].ToString();
                        emp.Gender = row["Gender"].ToString();
                        emp.City = row["City"].ToString();

                        listEmployee.Add(emp);
                    }
                }
                return View(listEmployee);
            }
            catch
            {
                return RedirectToAction("Error", "Home");
            }
        }
        public ActionResult ShowEmployees1()
        {
            ConnectEmployee obj = new ConnectEmployee();
            List<Employee> ListEm = obj.getData();
            return View(ListEm);
        }
        public ActionResult CreateEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateEmployee(FormCollection fc)
        {
            ConnectEmployee obj = new ConnectEmployee();
            var name = fc["FullName"];
            var gender = fc["Gender"];
            var city = fc["City"];
            var deptID = int.Parse(fc["DeptID"]);

            int kt = obj.InsertEmployee(name, gender, city, deptID);
            if (kt == 1)
                ViewBag.ThongBao = "Them thanh cong";
            else
                ViewBag.ThongBao = "Them khong thanh cong";
            return View();
        }
	}
}