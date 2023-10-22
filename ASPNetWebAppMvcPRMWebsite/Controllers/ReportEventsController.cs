using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ASP.NETCorePRMWebsite.Models;
using ASPNetWebAppMvcPRMWebsite.DAL;
using EntityState = System.Data.Entity.EntityState;

namespace ASPNetWebAppMvcPRMWebsite.Controllers
{
    public class ReportEventsController : Controller
    {
        private PRMContext db = new PRMContext();

        // GET: ReportEvents
        public ActionResult Index()
        {
            return View(db.ReportEvents.ToList());
        }

        // GET: ReportEvents/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReportEvent reportEvent = db.ReportEvents.Find(id);
            if (reportEvent == null)
            {
                return HttpNotFound();
            }
            return View(reportEvent);
        }

        // GET: ReportEvents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReportEvents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RE_Id,ReportEventId,ApartmentId,EventText,CreateDate")] ReportEvent reportEvent)
        {
            if (ModelState.IsValid)
            {
                db.ReportEvents.Add(reportEvent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(reportEvent);
        }

        // GET: ReportEvents/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReportEvent reportEvent = db.ReportEvents.Find(id);
            if (reportEvent == null)
            {
                return HttpNotFound();
            }
            return View(reportEvent);
        }

        // POST: ReportEvents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RE_Id,ReportEventId,ApartmentId,EventText,CreateDate")] ReportEvent reportEvent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reportEvent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reportEvent);
        }

        // GET: ReportEvents/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReportEvent reportEvent = db.ReportEvents.Find(id);
            if (reportEvent == null)
            {
                return HttpNotFound();
            }
            return View(reportEvent);
        }

        // POST: ReportEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ReportEvent reportEvent = db.ReportEvents.Find(id);
            db.ReportEvents.Remove(reportEvent);
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
