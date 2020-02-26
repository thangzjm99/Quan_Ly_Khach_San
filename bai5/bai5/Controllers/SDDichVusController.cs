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
    public class SDDichVusController : Controller
    {
        private Model1 db = new Model1();

        // GET: SDDichVus
        public ActionResult Index()
        {
            var sDDichVus = db.SDDichVus.Include(s => s.DICHVU).Include(s => s.PHONG).Include(s => s.THUEPHONG);
            return View(sDDichVus.ToList());
        }

        // GET: SDDichVus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SDDichVu sDDichVu = db.SDDichVus.Find(id);
            if (sDDichVu == null)
            {
                return HttpNotFound();
            }
            return View(sDDichVu);
        }

        // GET: SDDichVus/Create
        public ActionResult Create()
        {
            ViewBag.ID_MaDV = new SelectList(db.DICHVUs, "MaDV", "TenDV");
            ViewBag.ID_MaPhong = new SelectList(db.PHONGs, "MaPhong", "LoaiPhong");
            ViewBag.ID_MaHDThuePhong = new SelectList(db.THUEPHONGs, "MaHDThuePhong", "MaHDThuePhong");
            return View();
        }

        // POST: SDDichVus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_MaDV,ID_MaPhong,ID_MaHDThuePhong,SoLuong")] SDDichVu sDDichVu)
        {
            if (ModelState.IsValid)
            {
                db.SDDichVus.Add(sDDichVu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_MaDV = new SelectList(db.DICHVUs, "MaDV", "TenDV", sDDichVu.ID_MaDV);
            ViewBag.ID_MaPhong = new SelectList(db.PHONGs, "MaPhong", "LoaiPhong", sDDichVu.ID_MaPhong);
            ViewBag.ID_MaHDThuePhong = new SelectList(db.THUEPHONGs, "MaHDThuePhong", "MaHDThuePhong", sDDichVu.ID_MaHDThuePhong);
            return View(sDDichVu);
        }

        // GET: SDDichVus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SDDichVu sDDichVu = db.SDDichVus.Find(id);
            if (sDDichVu == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_MaDV = new SelectList(db.DICHVUs, "MaDV", "TenDV", sDDichVu.ID_MaDV);
            ViewBag.ID_MaPhong = new SelectList(db.PHONGs, "MaPhong", "LoaiPhong", sDDichVu.ID_MaPhong);
            ViewBag.ID_MaHDThuePhong = new SelectList(db.THUEPHONGs, "MaHDThuePhong", "MaHDThuePhong", sDDichVu.ID_MaHDThuePhong);
            return View(sDDichVu);
        }

        // POST: SDDichVus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_MaDV,ID_MaPhong,ID_MaHDThuePhong,SoLuong")] SDDichVu sDDichVu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sDDichVu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_MaDV = new SelectList(db.DICHVUs, "MaDV", "TenDV", sDDichVu.ID_MaDV);
            ViewBag.ID_MaPhong = new SelectList(db.PHONGs, "MaPhong", "LoaiPhong", sDDichVu.ID_MaPhong);
            ViewBag.ID_MaHDThuePhong = new SelectList(db.THUEPHONGs, "MaHDThuePhong", "MaHDThuePhong", sDDichVu.ID_MaHDThuePhong);
            return View(sDDichVu);
        }

        // GET: SDDichVus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SDDichVu sDDichVu = db.SDDichVus.Find(id);
            if (sDDichVu == null)
            {
                return HttpNotFound();
            }
            return View(sDDichVu);
        }

        // POST: SDDichVus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SDDichVu sDDichVu = db.SDDichVus.Find(id);
            db.SDDichVus.Remove(sDDichVu);
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
