using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HenryCrawfordPoetry.Controllers
{
    public class AmSoft2Controller : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
    }
}
