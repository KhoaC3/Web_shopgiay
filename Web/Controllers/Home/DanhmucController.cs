using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers.Home
{
    public class DanhmucController : Controller
    {
        private SneakerEntities db = new SneakerEntities();

        //
        // GET: /Danhmuc/

        public ActionResult Index()
        {
            var danhmuc = db.CATALOGies.ToList();
            return View(danhmuc);
        }

        //
        // GET: /Danhmuc/Details/5

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
        // GET: /Danhmuc/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Danhmuc/Create

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
        // GET: /Danhmuc/Edit/5

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
        // POST: /Danhmuc/Edit/5

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
        // GET: /Danhmuc/Delete/5

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
        // POST: /Danhmuc/Delete/5

        [HttpPost, ActionName("Xoá")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CATALOGY catalogy = db.CATALOGies.Find(id);
            db.CATALOGies.Remove(catalogy);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [ChildActionOnly]
        public ActionResult LoadMenu()
        {
            var dm = db.CATALOGies.ToList();

            return PartialView(dm);
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}