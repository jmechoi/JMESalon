using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace JMESalon.Controllers
{
    [Authorize]
    public class ServiceController : Controller
    {
        // GET: Service
        public ActionResult Index()
        {
            return View(DAL.Service.Services);
        }

        // GET: Service/Details/5
        public ActionResult Details(int id)
        {
            var service = DAL.Service.Services.FirstOrDefault(cm => cm.Id == id);
            return View(service);
        }

        // GET: Service/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Service/Create
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

        // GET: Service/Edit/5
        public ActionResult Edit(int id)
        {
            var service = DAL.Service.Services.FirstOrDefault(cm => cm.Id == id);
            return View(service);
        }

        // POST: Service/Edit/5
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

        // GET: Service/Delete/5
        public ActionResult Delete(int id)
        {
            var service = DAL.Service.Services.FirstOrDefault(cm => cm.Id == id);
            return View(service);
        }

        // POST: Service/Delete/5
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
