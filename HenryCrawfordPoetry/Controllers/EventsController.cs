using System.Web.Mvc;

namespace HenryCrawfordPoetry.Controllers
{
    public class EventsController : Controller
    {
        //
        // GET: /Events/
        public ActionResult Index()
        {
            // goes to the events home page page
            return View();
        }

        [AllowAnonymous]
        public FileResult DownloadWorkshopSlides()
        {
            string filePathName = Server.MapPath(@"~\App_Data\Writing_Poetry_for_Electonric_Media.pdf");

            byte[] fileBytes = System.IO.File.ReadAllBytes(filePathName);
            string fileName = "Workshop_Slides.pdf";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Pdf, fileName);
        }



    }
}
