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
    public class QLSanPhamController : Controller
    {
        private SneakerEntities db = new SneakerEntities();

        //
        // GET: /Admin/QLSanPham/

        public ActionResult Index()
        {
            var sanphams = db.SANPHAMs;
            return View(sanphams.ToList());
        }

        //
        // GET: /Admin/QLSanPham/Details/5

        public ActionResult Details(int id)
        {
            SANPHAM sanpham = db.SANPHAMs.Find(id);
            if (sanpham == null)
            {
                return HttpNotFound();
            }
            return View(sanpham);
        }

        //
        // GET: /Admin/QLSanPham/Create

        public ActionResult Create()
        {
            ViewBag.ID_CATALOGY = new SelectList(db.CATALOGies, "ID_CATALOGY", "NAME");
            ViewBag.ID_NHASX = new SelectList(db.NHASXes, "ID_NHASX", "NAME");
            ViewBag.ID_SIZE = new SelectList(db.SIZEs, "ID_SIZE", "SIZE1");
            return View();
        }

        //
        // POST: /Admin/QLSanPham/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SANPHAM sanpham)
        {
            if (ModelState.IsValid)
            {
                db.SANPHAMs.Add(sanpham);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_CATALOGY = new SelectList(db.CATALOGies, "ID_CATALOGY", "NAME", sanpham.ID_CATALOGY);
            ViewBag.ID_NHASX = new SelectList(db.NHASXes, "ID_NHASX", "NAME", sanpham.ID_NHASX);
            ViewBag.ID_SIZE = new SelectList(db.SIZEs, "ID_SIZE", "SIZE1", sanpham.ID_SIZE);
            return View(sanpham);
        }

        //
        // GET: /Admin/QLSanPham/Edit/5

        public ActionResult Edit(int id)
        {
            SANPHAM sanpham = db.SANPHAMs.Find(id);
            if (sanpham == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_CATALOGY = new SelectList(db.CATALOGies, "ID_CATALOGY", "NAME", sanpham.ID_CATALOGY);
            ViewBag.ID_NHASX = new SelectList(db.NHASXes, "ID_NHASX", "NAME", sanpham.ID_NHASX);
            ViewBag.ID_SIZE = new SelectList(db.SIZEs, "ID_SIZE", "SIZE1", sanpham.ID_SIZE);
            return View(sanpham);
        }

        //
        // POST: /Admin/QLSanPham/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SANPHAM sanpham)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sanpham).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_CATALOGY = new SelectList(db.CATALOGies, "ID_CATALOGY", "NAME", sanpham.ID_CATALOGY);
            ViewBag.ID_NHASX = new SelectList(db.NHASXes, "ID_NHASX", "NAME", sanpham.ID_NHASX);
            ViewBag.ID_SIZE = new SelectList(db.SIZEs, "ID_SIZE", "SIZE1", sanpham.ID_SIZE);
            return View(sanpham);
        }

        //
        // GET: /Admin/QLSanPham/Delete/5

        public ActionResult Delete(int id = 0)
        {
            SANPHAM sanpham = db.SANPHAMs.Find(id);
            if (sanpham == null)
            {
                return HttpNotFound();
            }
            return View(sanpham);
        }

        //
        // POST: /Admin/QLSanPham/Delete/5

        [HttpPost, ActionName("Xoá")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SANPHAM sanpham = db.SANPHAMs.Find(id);
            db.SANPHAMs.Remove(sanpham);
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