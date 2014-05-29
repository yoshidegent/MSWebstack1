using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Oef1.Controllers
{
    public class SignUpController : Controller
    {
        // GET: SignUp
        public ActionResult Index(string email, string pw)
        {
            if(!string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(pw))
            {
                ViewBag.Bericht = string.Format("Sign up successful for {0}!", email);
            }
            else
            {
                ViewBag.Bericht = "";
            }
            return View();
        }

        public ActionResult SignUp(string email, string pw)
        {
            if (!string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(pw))
            {
                ViewBag.Bericht = string.Format("Sign up successful for {0}!", email);
            }
            else
            {
                ViewBag.Bericht = "";
            }
            return View();
        }
    }
}