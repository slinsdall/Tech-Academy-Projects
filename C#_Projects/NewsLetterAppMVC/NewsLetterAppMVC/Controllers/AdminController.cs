using System.Collections.Generic;
using System.Web.Mvc;
using NewsLetterAppMVC.ViewModels;
using NewsLetterAppMVC.Models;
using System;
using System.Linq;

namespace NewsLetterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities1 db = new NewsletterEntities1()) 
                {
                    //var signups = db.SignUps.Where(x => x.Removed == null).ToList();
                    var signups = (from c in db.SignUps where c.Removed == null select c).ToList();
                    var signupVMs = new List<SignupVM>();
                    foreach (var signup in signups) 
                    {
                        var signupVm = new SignupVM();
                        signupVm.Id = signup.Id;
                        signupVm.FirstName = signup.FirstName;
                        signupVm.LastName = signup.LastName;
                        signupVm.EmailAddress = signup.EmailAddress;
                        signupVMs.Add(signupVm);
                    }
                    
                    return View(signupVMs);
            }
        }

        public ActionResult Unsubscribe(int Id)
        {
            using(NewsletterEntities1 db = new NewsletterEntities1()) 
            {
                var signup = db.SignUps.Find(Id);
                signup.Removed = DateTime.Now;
                db.SaveChanges();
            }
           return RedirectToAction("Index");
        }
    }
}