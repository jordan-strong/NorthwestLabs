using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthWestLabs.Controllers
{
    public class CRMController : Controller
    {
        // GET: CRM
        public ActionResult Index()
        {
            return View();
        }

        // GET: CRM/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CRM/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: CRM/WorkOrders  This is the new page that was create to show each customer's work orders
        public ActionResult WorkOrders()
        {
            return View();
        }

        // GET: CRM/Status  This is the new page that was create to show each customer's work orders status
        public ActionResult Status()
        {
            return View();
        }

        // POST: CRM/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CRM/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CRM/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CRM/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CRM/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
