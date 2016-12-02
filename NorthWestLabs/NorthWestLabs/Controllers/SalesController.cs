using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthWestLabs.Controllers
{
    public class SalesController : Controller
    {
        // GET: Sales
        public ActionResult CreateQuote()
        {
            return View();
        }

        //shows the final quote summary and all the information
        public ActionResult QuoteSummary()
        {
            return View();
        }
    }
}