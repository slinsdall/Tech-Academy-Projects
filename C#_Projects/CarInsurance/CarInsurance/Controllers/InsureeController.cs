using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
           
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                GetQuote(insuree.Id);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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
        public ActionResult GetQuote(int Id)
        {
            var insurees = new Insuree();
            Insuree insuree = db.Insurees.Find(Id);
            int id = insuree.Id;
            int carYear = insuree.CarYear;
            string carMake = insuree.CarMake;
            string carModel = insuree.CarModel;
            int speedingTickets = insuree.SpeedingTickets;
            bool dUI = insuree.DUI;
            bool coverageType = insuree.CoverageType;
            DateTime dateOfBirth = insuree.DateOfBirth;
            int Age = dateOfBirth.Year;
            int now = DateTime.Now.Year;
            int age = now - Age;
            decimal baseQuote = 50;
            if (age <= 18)
            {
                baseQuote += 100;
            }
            if (age >= 19 && age <= 25)
            {
                baseQuote += 50;
            }
            if (age >= 26)
            {
                baseQuote += 25;
            }
            if(carYear <= 2000)
            {
                baseQuote += 25;
            }
            if(carYear >= 2015)
            {
                baseQuote += 25;
            }
            if(carMake == "Porsche")
            {
                baseQuote += 25;
            }
            if(carMake == "Porsche" && carModel == "911 Carrera")
            {
                baseQuote += 25;
            }
            if(speedingTickets > 0)
            {
                int tTickets = speedingTickets * 10;
                decimal monthly = tTickets + baseQuote;
            }
            if(dUI == true)
            {
                baseQuote *= 1.25m;
                
            }
            if(coverageType == true)
            {
                baseQuote *= 1.5m;
            }
            insuree.Quote = baseQuote;
            db.SaveChanges();
            return RedirectToAction("Index");
            db.Insurees.Add(insuree);
            

            
        }
        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }




    }
    }
