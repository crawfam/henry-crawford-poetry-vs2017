using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HenryCrawfordPoetry.Controllers
{
    [Authorize]
    public class PoemsController : Controller
    {

        [AllowAnonymous]
        public ActionResult Poem(string fileName)
        {
            ViewBag.PoemFileName = fileName;
            return View();
        }

        [AllowAnonymous]
        public ActionResult PoemTwo(string fileName1, string fileName2)
        {
            ViewBag.PoemFileName1 = fileName1;
            ViewBag.PoemFileName2 = fileName2;
            return View();
        }

        [AllowAnonymous]
        public ActionResult Online()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult AmericanSoftware()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Videos()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult GuestTest()
        {
            return View();
        }        

        [AllowAnonymous]
        public ActionResult WalkingOnACityStreet()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult AmSoft2(string fileName)
        {
            ViewBag.PoemFileName = fileName;
            return View();            
        }
        
    }
}
