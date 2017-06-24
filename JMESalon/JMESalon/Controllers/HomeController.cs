using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JMESalon.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Stylists()
        {
            List<DAL.Stylist> stylists = new List<DAL.Stylist>();

            foreach (var item in DAL.Stylist.Stylists)
            {
                stylists.Add(item);
            }

            /*stylists.Add(
                new DAL.Stylist()
                {
                    FirstName = "Jamie",
                    LastName = "Choi",
                    Phone = "703",
                    Email = "jme.com",
                    Title = "Director",
                    associatedImg = "http://placehold.it/300x150",
                    Bio = "This is me."
                });*/

            return View(stylists);
        }

        public ActionResult Services()
        {
            List<DAL.Service> services = new List<DAL.Service>();

            foreach (var item in DAL.Service.Services)
            {
                services.Add(item);
            }

            /*services.Add(
                new DAL.Service()
                {
                    Name = "Hair Cut - Short/Medium",
                    Cost = 25.0,
                    Hours = "1-2 Hours",
                    associatedImg = "http://placehold.it/300x150",
                    description = "A dream haircut for clients with short or medium hair length."
                });

            services.Add(
                new DAL.Service()
                {
                    Name = "Hair Cut - Long",
                    Cost = 35.0,
                    Hours = "1-2 Hours",
                    associatedImg = "http://placehold.it/300x150",
                    description = "A dream haircut for clients with long hair length."
                });

            services.Add(
                new DAL.Service()
                {
                    Name = "Balayage - Short/Medium",
                    Cost = 150.0,
                    Hours = "2-5 Hours",
                    associatedImg = "http://placehold.it/300x150",
                    description = "A coloring service with beautiful, highlights with a specialized technique for clients with short or medium length hair."
                });

            services.Add(
                new DAL.Service()
                {
                    Name = "Balayage - Long",
                    Cost = 225.0,
                    Hours = "2-6 Hours",
                    associatedImg = "http://placehold.it/300x150",
                    description = "A coloring service with beautiful, highlights with a specialized technique for clients with short or medium length hair."
                });

            services.Add(
                new DAL.Service()
                {
                    Name = "Makeup - Formal Event",
                    Cost = 75.0,
                    Hours = "1-3 Hours",
                    associatedImg = "http://placehold.it/300x150",
                    description = "A full-face makeover for all your formal events - weddings, proms, dinners, etc."
                });*/

            return View(services);
        }
    }
}