using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bai3_KhoaCNTT.Controllers
{
    public class KhoaController : Controller
    {
        //
        // GET: /Test/
        public ActionResult Index()
        {
            Models.KhoaModel khoacntt = new Models.KhoaModel();
            return View(khoacntt);
        }
	}
}