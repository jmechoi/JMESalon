using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JMESalon.Controllers
{
    [Authorize]
    public class StylistController : Controller
    {
        // GET: Stylist
        public ActionResult Index()
        {
            return View(DAL.Stylist.Stylists);
        }

        // GET: Stylist/Details/5
        public ActionResult Details(int id)
        {
            var stylist = DAL.Stylist.Stylists.FirstOrDefault(cm => cm.Id == id);
            return View(stylist);
        }

        // GET: Stylist/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Stylist/Create
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

        // GET: Stylist/Edit/5
        public ActionResult Edit(int id)
        {
            var stylist = DAL.Stylist.Stylists.FirstOrDefault(cm => cm.Id == id);
            return View(stylist);
        }

        // POST: Stylist/Edit/5
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

        // GET: Stylist/Delete/5
        public ActionResult Delete(int id)
        {
            var stylist = DAL.Stylist.Stylists.FirstOrDefault(cm => cm.Id == id);
            return View(stylist);
        }

        // POST: Stylist/Delete/5
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
