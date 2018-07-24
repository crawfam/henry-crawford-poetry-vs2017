using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HenryCrawfordPoetry.Controllers
{
    public class EventsController : Controller
    {
        //
        // GET: /Events/
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult ThirdThursdayPoetrySeries()
        {
            return View();
        }

        public ActionResult CafeMuse()
        {
            return View();
        }

        public ActionResult WildeReadings()
        {
            return View();
        }


    }
}
