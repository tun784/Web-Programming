using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TH04_06_03_2024.Models;

namespace TH04_06_03_2024.Controllers
{
    public class DeparmentController : Controller
    {
        //
        // GET: /Department/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowDeparment()
        {
            ConnectDeparment obj = new ConnectDeparment();
            List<Deparment> ListDept = obj.getData();
            return View(ListDept);
        }
        public ActionResult ShowDetailsDeparment(string id)
        {
            ConnectDeparment obj = new ConnectDeparment();
            Deparment dept = obj.Details(id);
            ViewBag.SNV = obj.SoNV(id);
            return View(dept);
        }
        public ActionResult ShowDDLDept()
        {
            ConnectDeparment obj = new ConnectDeparment();
            List<Deparment> deptList = obj.getData();
            return View(deptList);
        }
        public ActionResult ShowListEmplByDept(string id)
        {
            ConnectDeparment obj = new ConnectDeparment();
            Deparment dept = obj.Details(id);
            List<Employee> listEmp = obj.ListEmplByDept(id);
            ViewBag.empList = listEmp;
            return View(dept);
        }
	}
}