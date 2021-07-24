using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;
namespace Web.Controllers.Home
{
    public class HomeController : Controller
    {

        SneakerEntities db = new SneakerEntities();

        public ActionResult Index()
        {
            var slide = db.SLIDEPHOTOes.ToList();
            return View(slide);
        }
        public ActionResult HD_MuaHang()
        {
            return View();
        }
        public ActionResult GioiThieu()
        {
            return View();
        }
        public ActionResult LienHe()
        {
            return View();
        }
     
    }
}
