using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Start_Reporting.Models;

namespace Start_Reporting.Controllers
{
    public class SmeItemsController : Controller
    {
        private Start_Reportingv2Context db = new Start_Reportingv2Context();

        // GET: SmeItems
        public ActionResult Index()
        {
            return View(db.SmeItems.ToList());
        }

        // GET: SmeItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SmeItem smeItem = db.SmeItems.Find(id);
            if (smeItem == null)
            {
                return HttpNotFound();
            }
            return View(smeItem);
        }

        // GET: SmeItems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SmeItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,HereEmailId,Work_Type,Sub_Type,Description,StartTime,EndTime,TotalElapsedTime")] SmeItem smeItem)
        {
            if (ModelState.IsValid)
            {
                smeItem.HereEmailId = User.Identity.Name.Split('\\')[1];
                smeItem.EndTime = DateTime.Now.ToString();
                //smeItem.TotalElapsedTime=
                db.SmeItems.Add(smeItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(smeItem);
        }

        // GET: SmeItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SmeItem smeItem = db.SmeItems.Find(id);
            if (smeItem == null)
            {
                return HttpNotFound();
            }
            return View(smeItem);
        }

        // POST: SmeItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,HereEmailId,Work_Type,Sub_Type,Description,StartTime,EndTime,TotalElapsedTime")] SmeItem smeItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(smeItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(smeItem);
        }

        // GET: SmeItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SmeItem smeItem = db.SmeItems.Find(id);
            if (smeItem == null)
            {
                return HttpNotFound();
            }
            return View(smeItem);
        }

        // POST: SmeItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SmeItem smeItem = db.SmeItems.Find(id);
            db.SmeItems.Remove(smeItem);
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
