using System.Collections.Generic;
using System.Web.Mvc;
using NewsLetterAppMVC.ViewModels;
using NewsLetterAppMVC.Models;

namespace NewsLetterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities db = new NewsletterEntities()) {
                var signups = db.SignUps;
                var signupVMs = new List<SignupVM>();
                foreach (var signup in signups) {
                    var signupVm = new SignupVM();
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVMs.Add(signupVm);
                }
                
                return View(signupVMs);
            }
        }
    }
}