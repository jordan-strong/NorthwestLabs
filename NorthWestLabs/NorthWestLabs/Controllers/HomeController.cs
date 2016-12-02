using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//Jordan, Alex, Laura, and Tyler wrote this awesome prototype
//It is just a static prototype of a new system for a pharmacutical test lab
//It is meant to be a small ERP system that tracks the production, revenue, and expenditure cycles of the business

namespace NorthWestLabs.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //all pages that we have not prototyped yet will come to here
        public ActionResult Construction()
        {
            return View();
        }

        
    }
}