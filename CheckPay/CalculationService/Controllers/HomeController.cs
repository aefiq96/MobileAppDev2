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
        // This is the information displayed on the tile.
        
        public ActionResult Index(String Gross, String Net)
        {
            //https://msdn.microsoft.com/en-us/library/system.web.mvc.controllerbase.viewbag(v=vs.118).aspx
            //viewBag allows you to dynamically share values from the controller to the view.
            ViewBag.Gross = "Gross =  " + Gross;
            ViewBag.Net = "Net = " + Net;

            return View();
        }
    }
}