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

        //control the Cause page. Cause is added by me
        public ActionResult Cause()
        {
            ViewBag.Message = "Your Cause page.";

            return View();
        }

        //control the Risk page. Risk is added by me
        public ActionResult Risk()
        {
            ViewBag.Message = "Your Risk page.";

            return View();
        }

        //control the Preventation page. Preventation is added by me
        public ActionResult Preventation()
        {
            ViewBag.Message = "Your Preventation page.";

            return View();
        }

        //control the Doctor page. Doctor is added by me
        public ActionResult Doctor()
        {
            ViewBag.Message = "Your Doctor page.";

            return View();
        }

    }
}