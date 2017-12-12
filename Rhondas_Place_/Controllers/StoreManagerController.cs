using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Rhondas_Place_.Models;

namespace Rhondas_Place_.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class StoreManagerController : Controller
    {
        private RhondasPlaceStoreEntities db = new RhondasPlaceStoreEntities();

        // GET: StoreManager
        public ActionResult Index()
        {
            var candle = db.Candle.Include(c => c.CandleCategory).Include(c => c.CandleScent);
            return View(candle.ToList());
        }

        // GET: StoreManager/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Candle candle = db.Candle.Find(id);
            if (candle == null)
            {
                return HttpNotFound();
            }
            //ViewBag.CandleCategoryId = new SelectList(db.CandleCategory, "CandleCategoryID", "Name", candle.CandleCategoryId);
            //ViewBag.CandleScent = new SelectList(db.CandleScent, "CandleScentId", "Name", candle.CandleScent);
            ViewBag.CandleCategoryId = new SelectList(db.CandleCategory, "CandleCategoryID", "Name", candle.CandleCategoryId);
            ViewBag.CandleScent = new SelectList(db.CandleScent, "CandleScentId", "Name", candle.CandleScent);
            return View(candle);
        }

        // GET: StoreManager/Create
        public ActionResult Create()
        {
            ViewBag.CandleCategoryId = new SelectList(db.CandleCategory, "CandleCategoryID", "Name");
            ViewBag.CandleScent = new SelectList(db.CandleScent, "CandleScentId", "Name");
            return View();
        }

        // POST: StoreManager/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CandleId,CandleCategoryId,CandleScentId,Title,Price,CandleImgUrl,CandleScent")] Candle candle)
        {
            if (ModelState.IsValid)
            {
                db.Candle.Add(candle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CandleCategoryId = new SelectList(db.CandleCategory, "CandleCategoryID", "Name", candle.CandleCategoryId);
            ViewBag.CandleScent = new SelectList(db.CandleScent, "CandleScentId", "Name", candle.CandleScent);
            return View(candle);
        }

        // GET: StoreManager/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Candle candle = db.Candle.Find(id);
            if (candle == null)
            {
                return HttpNotFound();
            }
            ViewBag.CandleCategoryId = new SelectList(db.CandleCategory, "CandleCategoryID", "Name", candle.CandleCategoryId);
            ViewBag.CandleScent = new SelectList(db.CandleScent, "CandleScentId", "Name", candle.CandleScent);
            //ViewBag.CandleScent = new SelectList(db.Candle, "CandleScent.Name", "CandleScent.Name", candle.CandleScent.Name);
            return View(candle);
        }

        // POST: StoreManager/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CandleId,CandleCategoryId,CandleScentId,Title,Price,CandleImgUrl,CandleScent")] Candle candle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(candle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CandleCategoryId = new SelectList(db.CandleCategory, "CandleCategoryID", "Name", candle.CandleCategoryId);
            ViewBag.CandleScent = new SelectList(db.CandleScent, "CandleScentId", "Name", candle.CandleScent);
            return View(candle);
        }

        // GET: StoreManager/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Candle candle = db.Candle.Find(id);
            if (candle == null)
            {
                return HttpNotFound();
            }
            return View(candle);
        }

        // POST: StoreManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Candle candle = db.Candle.Find(id);
            db.Candle.Remove(candle);
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
