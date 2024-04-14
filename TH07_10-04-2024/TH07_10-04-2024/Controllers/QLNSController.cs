using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using TH07_10_04_2024.Models;
namespace TH07_10_04_2024.Controllers
{
    public class QLNSController : Controller
    {
        //
        // GET: /QLNS/
        QL_NhanSuNEntities db = new QL_NhanSuNEntities();
        public ActionResult ShowDeparments()
        {
            var DeptList = db.tbl_Deparment.ToList();
            return View(DeptList);
        }
        public ActionResult CreateDept()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateDept(tbl_Deparment dept){
            if (ModelState.IsValid)
                if (db.tbl_Deparment.ToList().Where(d => d.Name == dept.Name).Count() == 0)
                {
                    db.tbl_Deparment.Add(dept);
                    db.SaveChanges();
                    return RedirectToAction("ShowDeparments", "QLNS");
                }
            return View(dept);
        }
        public ActionResult UpdateDept(int id)
        {
            tbl_Deparment dept = db.tbl_Deparment.Single(d => d.DeptId == id);
            if (dept == null)
                return HttpNotFound();
            return View(dept);
        }
        [HttpPost]
        public ActionResult UpdateDept(tbl_Deparment dept)
        {
            if (ModelState.IsValid)
            {
                db.tbl_Deparment.Attach(dept);
                db.Entry(dept).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ShowDeparments", "QLNS");
            }
            return View(dept);
        }
        public ActionResult DetailsDept(int id)
        {
            var dept = db.tbl_Deparment.ToList().Single(d => d.DeptId == id);
            ViewBag.SoNhanVien = db.tbl_Employee.ToList().Where(e => e.DeptId == id).Count();
            return View(dept);
        }
        public ActionResult ShowEmployee()
        {
            var dept = db.tbl_Employee.ToList();
            return View(dept);
        }
        public ActionResult CreateEmployee()
        {
            ViewBag.DeptId = new SelectList(db.tbl_Deparment, "DeptId", "Name");
            return View();
        }
	}
}