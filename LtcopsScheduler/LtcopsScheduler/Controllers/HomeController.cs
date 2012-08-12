using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LtcopsScheduler.Models;

namespace LtcopsScheduler.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            var model = new RestaurantReview() {
            Name = "Pollo Tropical", 
            Rating = 9 
            
            }; 
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Location = "Tampa, Fl" ; 
            return View();
        }
    }
}
