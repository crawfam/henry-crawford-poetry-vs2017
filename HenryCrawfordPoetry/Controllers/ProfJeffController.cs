using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HenryCrawfordPoetry.Controllers
{
    public class ProfJeffController : Controller
    {
     
        // GET: /ProfJeff/
        public ActionResult Index()
        {
            return View("Index", "_LayoutProfJeff");
        }

    }
}
