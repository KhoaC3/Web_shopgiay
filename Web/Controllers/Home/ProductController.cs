using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers.Home
{
    public class ProductController : Controller
    {
        SneakerEntities db = new SneakerEntities();

        public ActionResult Index()
        {
            return View(db.CATALOGies);
        }
        public ActionResult ProductId(int id)
        {
            return View(db.SANPHAMs.Where(m => m.ID_CATALOGY == id));
        }
        public ActionResult Details(int id)
        {
            return View(db.SANPHAMs.Find(id));
        }
        public ActionResult Top5Product()
        {
            return PartialView(db.SANPHAMs.Take(5));
        }

    }
}
