using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Oef2.Controllers
{
    public class HomeBisController : Controller
    {
        // GET: HomeBis
        public ActionResult Index(string naam)
        {
            if(!string.IsNullOrWhiteSpace(naam))
            {
                Session["naam"] = naam;
                return RedirectToAction("SecondPage");                                
            }
            else
            {
                return View();
            }
        }

        public ActionResult SecondPage()
        {
            if (string.IsNullOrWhiteSpace(Session["naam"].ToString()))
                Response.Redirect(".");

            ViewBag.naam = Session["naam"];
            return View();
        }
    }
}