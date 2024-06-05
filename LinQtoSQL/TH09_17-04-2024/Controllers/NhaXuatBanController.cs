using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TH09_17_04_2024.Models;
namespace TH09_17_04_2024.Controllers
{
    public class NhaXuatBanController : Controller
    {
        //
        // GET: /NhaXuatBan/
        QuanLyBanSachDataContext db = new QuanLyBanSachDataContext();
        public ActionResult NXBPartial()
        {
            var ListNXB = db.NhaXuatBans.OrderBy(cd => cd.TenNXB).Take(7).ToList();
            return View(ListNXB);
        }
	}
}