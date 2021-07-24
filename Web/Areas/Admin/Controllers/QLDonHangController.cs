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
    public class QLDonHangController : Controller
    {
        private SneakerEntities db = new SneakerEntities();

        //
        // GET: /Admin/QLDonHang/

        public ActionResult Index()
        {
            return View(db.DATHANGs.ToList());
        }

        //
        // GET: /Admin/QLDonHang/Details/5

        public ActionResult Details(int id = 0)
        {
            DATHANG dathang = db.DATHANGs.Find(id);
            if (dathang == null)
            {
                return HttpNotFound();
            }
            return View(dathang);
        }

        //
        // GET: /Admin/QLDonHang/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Admin/QLDonHang/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DATHANG dathang)
        {
            if (ModelState.IsValid)
            {
                db.DATHANGs.Add(dathang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dathang);
        }

        //
        // GET: /Admin/QLDonHang/Edit/5

        public ActionResult Edit(int id = 0)
        {
            DATHANG dathang = db.DATHANGs.Find(id);
            if (dathang == null)
            {
                return HttpNotFound();
            }
            return View(dathang);
        }

        //
        // POST: /Admin/QLDonHang/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DATHANG dathang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dathang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dathang);
        }

        //
        // GET: /Admin/QLDonHang/Delete/5

        public ActionResult Delete(int id = 0)
        {
            DATHANG dathang = db.DATHANGs.Find(id);
            if (dathang == null)
            {
                return HttpNotFound();
            }
            return View(dathang);
        }

        //
        // POST: /Admin/QLDonHang/Delete/5

        [HttpPost, ActionName("Xoá")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DATHANG dathang = db.DATHANGs.Find(id);
            db.DATHANGs.Remove(dathang);
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