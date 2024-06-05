using API_Bai1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace API_Bai1.Controllers
{
    public class BaiHatController : Controller
    {
        // GET: BaiHat
        
            ApiBaiHatController api_BH = new ApiBaiHatController();
            public ActionResult ShowDataBaiHat()
            {
                List<tbl_BaiHat> ListBH = api_BH.GetBaiHatLists();
                return View(ListBH);
            }
            public ActionResult ShowDetailBaiHat(int id)
            {
                tbl_BaiHat song = api_BH.GetBaiHat(id);
                return View(song);
            }
        
    }
}