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
    public class THUEPHONGsController : Controller
    {
        private Model1 db = new Model1();

        // GET: THUEPHONGs
        public ActionResult Index()
        {
            var tHUEPHONGs = db.THUEPHONGs.Include(t => t.KHACHHANG).Include(t => t.NHANVIEN).Include(t => t.PHONG);
            return View(tHUEPHONGs.ToList());
        }

        // GET: THUEPHONGs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            THUEPHONG tHUEPHONG = db.THUEPHONGs.Find(id);
            if (tHUEPHONG == null)
            {
                return HttpNotFound();
            }
            return View(tHUEPHONG);
        }

        // GET: THUEPHONGs/Create
        public ActionResult Create()
        {
            ViewBag.ID_MaKH = new SelectList(db.KHACHHANGs, "MaKH", "HoTenKH");
            ViewBag.ID_MaNV = new SelectList(db.NHANVIENs, "MaNV", "HoTenNV");
            ViewBag.ID_MaPhong = new SelectList(db.PHONGs, "MaPhong", "LoaiPhong");
            return View();
        }

        // POST: THUEPHONGs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaHDThuePhong,ID_MaNV,NgayThue,NgayTra,ID_MaKH,ID_MaPhong")] THUEPHONG tHUEPHONG)
        {
            if (ModelState.IsValid)
            {
                db.THUEPHONGs.Add(tHUEPHONG);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_MaKH = new SelectList(db.KHACHHANGs, "MaKH", "HoTenKH", tHUEPHONG.ID_MaKH);
            ViewBag.ID_MaNV = new SelectList(db.NHANVIENs, "MaNV", "HoTenNV", tHUEPHONG.ID_MaNV);
            ViewBag.ID_MaPhong = new SelectList(db.PHONGs, "MaPhong", "LoaiPhong", tHUEPHONG.ID_MaPhong);
            return View(tHUEPHONG);
        }

        // GET: THUEPHONGs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            THUEPHONG tHUEPHONG = db.THUEPHONGs.Find(id);
            if (tHUEPHONG == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_MaKH = new SelectList(db.KHACHHANGs, "MaKH", "HoTenKH", tHUEPHONG.ID_MaKH);
            ViewBag.ID_MaNV = new SelectList(db.NHANVIENs, "MaNV", "HoTenNV", tHUEPHONG.ID_MaNV);
            ViewBag.ID_MaPhong = new SelectList(db.PHONGs, "MaPhong", "LoaiPhong", tHUEPHONG.ID_MaPhong);
            return View(tHUEPHONG);
        }

        // POST: THUEPHONGs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaHDThuePhong,ID_MaNV,NgayThue,NgayTra,ID_MaKH,ID_MaPhong")] THUEPHONG tHUEPHONG)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tHUEPHONG).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_MaKH = new SelectList(db.KHACHHANGs, "MaKH", "HoTenKH", tHUEPHONG.ID_MaKH);
            ViewBag.ID_MaNV = new SelectList(db.NHANVIENs, "MaNV", "HoTenNV", tHUEPHONG.ID_MaNV);
            ViewBag.ID_MaPhong = new SelectList(db.PHONGs, "MaPhong", "LoaiPhong", tHUEPHONG.ID_MaPhong);
            return View(tHUEPHONG);
        }

        // GET: THUEPHONGs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            THUEPHONG tHUEPHONG = db.THUEPHONGs.Find(id);
            if (tHUEPHONG == null)
            {
                return HttpNotFound();
            }
            return View(tHUEPHONG);
        }

        // POST: THUEPHONGs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            THUEPHONG tHUEPHONG = db.THUEPHONGs.Find(id);
            db.THUEPHONGs.Remove(tHUEPHONG);
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
