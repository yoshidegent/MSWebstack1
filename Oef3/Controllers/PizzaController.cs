using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Oef3.Models;

namespace Oef3.Controllers
{
    public class PizzaController : Controller
    {
        // GET: Pizza
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PizzaToon(Pizza p)
        {
            if (p.ExtraKaas)
                ViewBag.ExtraKaas = "Extra Kaas";
            else
                ViewBag.ExtraKaas = "Geen extra Kaas";
            return View(p);
        }
    }
}