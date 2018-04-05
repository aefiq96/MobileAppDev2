using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculationService.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(String Gross, String Net)
        {
            ViewBag.Gross = "Gross =  " + Gross;
            ViewBag.Net = "Net = " + Net;

            return View();
        }
    }
}