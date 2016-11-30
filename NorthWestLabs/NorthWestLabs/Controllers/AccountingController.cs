using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthWestLabs.Controllers
{
    public class AccountingController : Controller
    {
        //This controller creates the views for the accounting pages 
        // GET: Accounting
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            if (id == 1)
            {
                ViewBag.id = 1;
                return View();
            }
            else if (id == 2)
            {
                ViewBag.id = 2;
                return View();
            }
            else
            {
                ViewBag.id = 3;
                return View();
            }
         
        }
    }
}