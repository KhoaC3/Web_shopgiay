using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Areas.Admin.Controllers
{
    public class QLDanhMucController : Controller
    {
        private SneakerEntities db = new SneakerEntities();

        //
        // GET: /Admin/QLDanhMuc/

        public ActionResult Index()
        {
            return View(db.CATALOGies.ToList());
        }

        //
        // GET: /Admin/QLDanhMuc/Details/5

        public ActionResult Details(int id = 0)
        {
            CATALOGY catalogy = db.CATALOGies.Find(id);
            if (catalogy == null)
            {
                return HttpNotFound();
            }
            return View(catalogy);
        }

        //
        // GET: /Admin/QLDanhMuc/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Admin/QLDanhMuc/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CATALOGY catalogy)
        {
            if (ModelState.IsValid)
            {
                db.CATALOGies.Add(catalogy);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(catalogy);
        }

        //
        // GET: /Admin/QLDanhMuc/Edit/5

        public ActionResult Edit(int id = 0)
        {
            CATALOGY catalogy = db.CATALOGies.Find(id);
            if (catalogy == null)
            {
                return HttpNotFound();
            }
            return View(catalogy);
        }

        //
        // POST: /Admin/QLDanhMuc/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CATALOGY catalogy)
        {
            if (ModelState.IsValid)
            {
                db.Entry(catalogy).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(catalogy);
        }

        //
        // GET: /Admin/QLDanhMuc/Delete/5

        public ActionResult Delete(int id = 0)
        {
            CATALOGY catalogy = db.CATALOGies.Find(id);
            if (catalogy == null)
            {
                return HttpNotFound();
            }
            return View(catalogy);
        }

        //
        // POST: /Admin/QLDanhMuc/Delete/5

        [HttpPost, ActionName("Xoá")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CATALOGY catalogy = db.CATALOGies.Find(id);
            db.CATALOGies.Remove(catalogy);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}