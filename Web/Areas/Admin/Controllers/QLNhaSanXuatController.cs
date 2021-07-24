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
    public class QLNhaSanXuatController : Controller
    {
        private SneakerEntities db = new SneakerEntities();

        //
        // GET: /Admin/QLNhaSanXuat/

        public ActionResult Index()
        {
            return View(db.NHASXes.ToList());
        }

        //
        // GET: /Admin/QLNhaSanXuat/Details/5

        public ActionResult Details(int id = 0)
        {
            NHASX nhasx = db.NHASXes.Find(id);
            if (nhasx == null)
            {
                return HttpNotFound();
            }
            return View(nhasx);
        }

        //
        // GET: /Admin/QLNhaSanXuat/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Admin/QLNhaSanXuat/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NHASX nhasx)
        {
            if (ModelState.IsValid)
            {
                db.NHASXes.Add(nhasx);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nhasx);
        }

        //
        // GET: /Admin/QLNhaSanXuat/Edit/5

        public ActionResult Edit(int id = 0)
        {
            NHASX nhasx = db.NHASXes.Find(id);
            if (nhasx == null)
            {
                return HttpNotFound();
            }
            return View(nhasx);
        }

        //
        // POST: /Admin/QLNhaSanXuat/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(NHASX nhasx)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhasx).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nhasx);
        }

        //
        // GET: /Admin/QLNhaSanXuat/Delete/5

        public ActionResult Delete(int id = 0)
        {
            NHASX nhasx = db.NHASXes.Find(id);
            if (nhasx == null)
            {
                return HttpNotFound();
            }
            return View(nhasx);
        }

        //
        // POST: /Admin/QLNhaSanXuat/Delete/5

        [HttpPost, ActionName("Xoá")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NHASX nhasx = db.NHASXes.Find(id);
            db.NHASXes.Remove(nhasx);
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