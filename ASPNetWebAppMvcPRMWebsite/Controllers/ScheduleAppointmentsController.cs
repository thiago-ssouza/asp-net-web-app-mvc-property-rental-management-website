using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ASPNetWebAppMvcPRMWebsite.DAL;
using ASPNetWebAppMvcPRMWebsite.Models;
using EntityState = System.Data.Entity.EntityState;

namespace ASPNetWebAppMvcPRMWebsite.Controllers
{
    public class ScheduleAppointmentsController : Controller
    {
        private PRMContext db = new PRMContext();

        // GET: ScheduleAppointments
        public ActionResult Index()
        {
            return View(db.ScheduleAppointments.ToList());
        }

        // GET: ScheduleAppointments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ScheduleAppointment scheduleAppointment = db.ScheduleAppointments.Find(id);
            if (scheduleAppointment == null)
            {
                return HttpNotFound();
            }
            return View(scheduleAppointment);
        }

        // GET: ScheduleAppointments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ScheduleAppointments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SA_Id,ScheduleAppointmentId,PropertyManagerId,TenantId,ScheduleAppointmentDate,Status")] ScheduleAppointment scheduleAppointment)
        {
            if (ModelState.IsValid)
            {
                db.ScheduleAppointments.Add(scheduleAppointment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(scheduleAppointment);
        }

        // GET: ScheduleAppointments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ScheduleAppointment scheduleAppointment = db.ScheduleAppointments.Find(id);
            if (scheduleAppointment == null)
            {
                return HttpNotFound();
            }
            return View(scheduleAppointment);
        }

        // POST: ScheduleAppointments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SA_Id,ScheduleAppointmentId,PropertyManagerId,TenantId,ScheduleAppointmentDate,Status")] ScheduleAppointment scheduleAppointment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(scheduleAppointment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(scheduleAppointment);
        }

        // GET: ScheduleAppointments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ScheduleAppointment scheduleAppointment = db.ScheduleAppointments.Find(id);
            if (scheduleAppointment == null)
            {
                return HttpNotFound();
            }
            return View(scheduleAppointment);
        }

        // POST: ScheduleAppointments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ScheduleAppointment scheduleAppointment = db.ScheduleAppointments.Find(id);
            db.ScheduleAppointments.Remove(scheduleAppointment);
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
