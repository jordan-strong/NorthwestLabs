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

        public ActionResult QuoteSummary()
        {
            return View();
        }
    }
}