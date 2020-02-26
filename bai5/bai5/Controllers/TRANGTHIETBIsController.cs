using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using bai5;

namespace bai5.Controllers
{
    public class TRANGTHIETBIsController : Controller
    {
        private Model1 db = new Model1();

        // GET: TRANGTHIETBIs
        public ActionResult Index()
        {
            var tRANGTHIETBIs = db.TRANGTHIETBIs.Include(t => t.PHONG);
            return View(tRANGTHIETBIs.ToList());
        }

        // GET: TRANGTHIETBIs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRANGTHIETBI tRANGTHIETBI = db.TRANGTHIETBIs.Find(id);
            if (tRANGTHIETBI == null)
            {
                return HttpNotFound();
            }
            return View(tRANGTHIETBI);
        }

        // GET: TRANGTHIETBIs/Create
        public ActionResult Create()
        {
            ViewBag.ID_MaPhong = new SelectList(db.PHONGs, "MaPhong", "LoaiPhong");
            return View();
        }

        // POST: TRANGTHIETBIs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaTTB,TenTTB,ID_MaPhong,SoLuong,TinhTrang,GiaTri")] TRANGTHIETBI tRANGTHIETBI)
        {
            if (ModelState.IsValid)
            {
                db.TRANGTHIETBIs.Add(tRANGTHIETBI);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_MaPhong = new SelectList(db.PHONGs, "MaPhong", "LoaiPhong", tRANGTHIETBI.ID_MaPhong);
            return View(tRANGTHIETBI);
        }

        // GET: TRANGTHIETBIs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRANGTHIETBI tRANGTHIETBI = db.TRANGTHIETBIs.Find(id);
            if (tRANGTHIETBI == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_MaPhong = new SelectList(db.PHONGs, "MaPhong", "LoaiPhong", tRANGTHIETBI.ID_MaPhong);
            return View(tRANGTHIETBI);
        }

        // POST: TRANGTHIETBIs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaTTB,TenTTB,ID_MaPhong,SoLuong,TinhTrang,GiaTri")] TRANGTHIETBI tRANGTHIETBI)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tRANGTHIETBI).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_MaPhong = new SelectList(db.PHONGs, "MaPhong", "LoaiPhong", tRANGTHIETBI.ID_MaPhong);
            return View(tRANGTHIETBI);
        }

        // GET: TRANGTHIETBIs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TRANGTHIETBI tRANGTHIETBI = db.TRANGTHIETBIs.Find(id);
            if (tRANGTHIETBI == null)
            {
                return HttpNotFound();
            }
            return View(tRANGTHIETBI);
        }

        // POST: TRANGTHIETBIs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TRANGTHIETBI tRANGTHIETBI = db.TRANGTHIETBIs.Find(id);
            db.TRANGTHIETBIs.Remove(tRANGTHIETBI);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
