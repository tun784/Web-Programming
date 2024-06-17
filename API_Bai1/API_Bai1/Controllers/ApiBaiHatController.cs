using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API_Bai1.Models;
namespace API_Bai1.Controllers
{
    public class ApiBaiHatController : ApiController
    {
        [HttpGet]
        public List<tbl_BaiHat> GetBaiHatLists()
        {
            DBBaiHatDataContext db = new DBBaiHatDataContext();
            return db.tbl_BaiHats.ToList();
        }
        [HttpGet]
        public tbl_BaiHat GetBaiHat(int id)
        {
            DBBaiHatDataContext db = new DBBaiHatDataContext();
            return db.tbl_BaiHats.FirstOrDefault(s => s.MaBH == id);
        }
        [HttpPost]
        public int InsertNewBaiHat(string TenBH, int MaTL, int MaNS)
        {
            try
            {
                DBBaiHatDataContext db = new DBBaiHatDataContext();
                tbl_BaiHat s = new tbl_BaiHat();
                s.TenBH = TenBH;
                s.MaTL = MaTL;
                s.MaNS = MaNS;
                db.tbl_BaiHats.InsertOnSubmit(s);
                db.SubmitChanges();
                return 1;
            }
            catch {
                return 0;
            }
        }
    }
}
