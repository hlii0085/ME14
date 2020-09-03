using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ME14.Controllers
{
    public class HomeController : Controller
    {
        //control the index page
        public ActionResult Index()
        {
            return View();
        }

        //control the About page
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //control the Contact page
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //control the info page. Info is added by me
        public ActionResult Info()
        {
            ViewBag.Message = "Your Info page.";

            return View();
        }
    }
}