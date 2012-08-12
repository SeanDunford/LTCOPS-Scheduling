using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LtcopsScheduler.Controllers
{
    public class CuisineController : Controller
    {

        public ActionResult Search(string name = "AMERICA!!! YEAH!")
        {
            name = Server.HtmlEncode("YAy1!!!1   " + name);
            return RedirectToAction("Index","Home");
            // return RedirectPermanent("http://www.google.com"); 
            //return Content(name);
        }

    }
}
