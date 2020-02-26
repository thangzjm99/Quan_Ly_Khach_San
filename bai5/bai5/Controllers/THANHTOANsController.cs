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
    public class THANHTOANsController : Controller
    {
        private Model1 db = new Model1();

        // GET: THANHTOANs
        public ActionResult Index()
        {
            var tHANHTOANs = db.THANHTOANs.Include(t => t.NHANVIEN).Include(t => t.THUEPHONG);
            return View(tHANHTOANs.ToList());
        }

        // GET: THANHTOANs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            THANHTOAN tHANHTOAN = db.THANHTOANs.Find(id);
            if (tHANHTOAN == null)
            {
                return HttpNotFound();
            }
            return View(tHANHTOAN);
        }

        // GET: THANHTOANs/Create
        public ActionResult Create()
        {
            ViewBag.ID_MaNV = new SelectList(db.NHANVIENs, "MaNV", "HoTenNV");
            ViewBag.ID_MaHDThuePhong = new SelectList(db.THUEPHONGs, "MaHDThuePhong", "MaHDThuePhong");
            return View();
        }

        // POST: THANHTOANs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaThanhToan,ID_MaHDThuePhong,ID_MaNV,NgayThanhToan,TienPhong")] THANHTOAN tHANHTOAN)
        {
            if (ModelState.IsValid)
            {
                db.THANHTOANs.Add(tHANHTOAN);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_MaNV = new SelectList(db.NHANVIENs, "MaNV", "HoTenNV", tHANHTOAN.ID_MaNV);
            ViewBag.ID_MaHDThuePhong = new SelectList(db.THUEPHONGs, "MaHDThuePhong", "MaHDThuePhong", tHANHTOAN.ID_MaHDThuePhong);
            return View(tHANHTOAN);
        }

        // GET: THANHTOANs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            THANHTOAN tHANHTOAN = db.THANHTOANs.Find(id);
            if (tHANHTOAN == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_MaNV = new SelectList(db.NHANVIENs, "MaNV", "HoTenNV", tHANHTOAN.ID_MaNV);
            ViewBag.ID_MaHDThuePhong = new SelectList(db.THUEPHONGs, "MaHDThuePhong", "MaHDThuePhong", tHANHTOAN.ID_MaHDThuePhong);
            return View(tHANHTOAN);
        }

        // POST: THANHTOANs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaThanhToan,ID_MaHDThuePhong,ID_MaNV,NgayThanhToan,TienPhong")] THANHTOAN tHANHTOAN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tHANHTOAN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_MaNV = new SelectList(db.NHANVIENs, "MaNV", "HoTenNV", tHANHTOAN.ID_MaNV);
            ViewBag.ID_MaHDThuePhong = new SelectList(db.THUEPHONGs, "MaHDThuePhong", "MaHDThuePhong", tHANHTOAN.ID_MaHDThuePhong);
            return View(tHANHTOAN);
        }

        // GET: THANHTOANs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            THANHTOAN tHANHTOAN = db.THANHTOANs.Find(id);
            if (tHANHTOAN == null)
            {
                return HttpNotFound();
            }
            return View(tHANHTOAN);
        }

        // POST: THANHTOANs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            THANHTOAN tHANHTOAN = db.THANHTOANs.Find(id);
            db.THANHTOANs.Remove(tHANHTOAN);
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
