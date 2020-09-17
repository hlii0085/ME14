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

        //control the NotAlone page
        public ActionResult NotAlone()
        {
            ViewBag.Message = "Your are not alone page.";

            return View();
        }

        //control the Contact page
        public ActionResult KnowYouBetter()
        {
            ViewBag.Message = "Know You Better page.";

            return View();
        }

        //control the info page. Info is added by me
        public ActionResult Info()
        {
            ViewBag.Message = "Your Info page.";

            return View();
        }

        //control the Suggestion1 page. Suggestion1 is added by me
        public ActionResult Suggestion1()
        {
            ViewBag.Message = "Your Suggestion1 page.";

            return View();
        }

        //control the Suggestion2 page. Suggestion2 is added by me
        public ActionResult Suggestion2()
        {
            ViewBag.Message = "Your Suggestion2 page.";

            return View();
        }

        //control the Suggestion3 page. Suggestion3 is added by me
        public ActionResult Suggestion3()
        {
            ViewBag.Message = "Your Suggestion3 page.";

            return View();
        }

      

    }
}