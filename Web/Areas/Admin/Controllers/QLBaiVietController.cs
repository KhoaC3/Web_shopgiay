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
    public class QLBaiVietController : Controller
    {
        private SneakerEntities db = new SneakerEntities();

        //
        // GET: /Admin/QLBaiViet/

        public ActionResult Index()
        {
            return View(db.TINTUCs.ToList());
        }

        //
        // GET: /Admin/QLBaiViet/Details/5

        public ActionResult Details(int id = 0)
        {
            TINTUC tintuc = db.TINTUCs.Find(id);
            if (tintuc == null)
            {
                return HttpNotFound();
            }
            return View(tintuc);
        }

        //
        // GET: /Admin/QLBaiViet/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Admin/QLBaiViet/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TINTUC tintuc)
        {
            if (ModelState.IsValid)
            {
                db.TINTUCs.Add(tintuc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tintuc);
        }

        //
        // GET: /Admin/QLBaiViet/Edit/5

        public ActionResult Edit(int id = 0)
        {
            TINTUC tintuc = db.TINTUCs.Find(id);
            if (tintuc == null)
            {
                return HttpNotFound();
            }
            return View(tintuc);
        }

        //
        // POST: /Admin/QLBaiViet/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TINTUC tintuc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tintuc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tintuc);
        }

        //
        // GET: /Admin/QLBaiViet/Delete/5

        public ActionResult Delete(int id = 0)
        {
            TINTUC tintuc = db.TINTUCs.Find(id);
            if (tintuc == null)
            {
                return HttpNotFound();
            }
            return View(tintuc);
        }

        //
        // POST: /Admin/QLBaiViet/Delete/5

        [HttpPost, ActionName("Xoá")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TINTUC tintuc = db.TINTUCs.Find(id);
            db.TINTUCs.Remove(tintuc);
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