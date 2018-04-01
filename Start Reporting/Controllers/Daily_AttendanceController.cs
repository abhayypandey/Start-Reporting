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
    public class Daily_AttendanceController : Controller
    {
        private Start_Reportingv1Context db = new Start_Reportingv1Context();

        // GET: Daily_Attendance
        public ActionResult Index()
        {
            return View(db.Daily_Attendance.ToList());
        }

        // GET: Daily_Attendance/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Daily_Attendance daily_Attendance = db.Daily_Attendance.Find(id);
            if (daily_Attendance == null)
            {
                return HttpNotFound();
            }
            return View(daily_Attendance);
        }

        // GET: Daily_Attendance/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Daily_Attendance/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,HereEmailId,IDay,Status,subnature,nature,UnplannedCount")] Daily_Attendance daily_Attendance)
        {
            if (ModelState.IsValid)
            {
                daily_Attendance.HereEmailId = User.Identity.Name.Split('\\')[1];
                //daily_Attendance.UnplannedCount = 
                db.Daily_Attendance.Add(daily_Attendance);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(daily_Attendance);
        }

        // GET: Daily_Attendance/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Daily_Attendance daily_Attendance = db.Daily_Attendance.Find(id);
            if (daily_Attendance == null)
            {
                return HttpNotFound();
            }
            return View(daily_Attendance);
        }

        // POST: Daily_Attendance/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,HereEmailId,IDay,Status,subnature,nature,UnplannedCount")] Daily_Attendance daily_Attendance)
        {
            if (ModelState.IsValid)
            {
                db.Entry(daily_Attendance).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(daily_Attendance);
        }

        // GET: Daily_Attendance/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Daily_Attendance daily_Attendance = db.Daily_Attendance.Find(id);
            if (daily_Attendance == null)
            {
                return HttpNotFound();
            }
            return View(daily_Attendance);
        }

        // POST: Daily_Attendance/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Daily_Attendance daily_Attendance = db.Daily_Attendance.Find(id);
            db.Daily_Attendance.Remove(daily_Attendance);
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
