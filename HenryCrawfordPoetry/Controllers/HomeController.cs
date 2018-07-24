using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Models;

namespace HenryCrawfordPoetry.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Bio()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Contact()
        {
            return View();
        }

        [AllowAnonymous]
        public FileResult DownloadTakomaParkReading()
        {
            string filePathName = Server.MapPath(@"~\App_Data\Templates\American_Software_at_Takoma_Park.pdf");

            byte[] fileBytes = System.IO.File.ReadAllBytes(filePathName);
            string fileName = "American_Software_Takoma_Park.pdf";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }
        
        [AllowAnonymous]
        public FileResult DownloadTemplateCalibri()
        {
            string filePathName = Server.MapPath(@"~\App_Data\Templates\Template_Calibri.doc");

            byte[] fileBytes = System.IO.File.ReadAllBytes(filePathName);
            string fileName = "Template_Calibri.doc";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }

        [AllowAnonymous]
        public FileResult DownloadTemplateCalibriManuscript()
        {
            string filePathName = Server.MapPath(@"~\App_Data\Templates\Template_Calibri_Manuscript.doc");

            byte[] fileBytes = System.IO.File.ReadAllBytes(filePathName);
            string fileName = "Template_Calibri_Manuscript.doc";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }

        [AllowAnonymous]
        public FileResult DownloadTemplateTimesNewRoman()
        {
            string filePathName = Server.MapPath(@"~\App_Data\Templates\Template_Times_New_Roman.doc");

            byte[] fileBytes = System.IO.File.ReadAllBytes(filePathName);
            string fileName = "Template_Times_New_Roman.doc";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }

        [AllowAnonymous]
        public FileResult DownloadTemplateTimesNewRomanManuscript()
        {
            string filePathName = Server.MapPath(@"~\App_Data\Templates\Template_Times_New_Roman_Manuscript.doc");

            byte[] fileBytes = System.IO.File.ReadAllBytes(filePathName);
            string fileName = "Template_Times_New_Roman_Manuscript.doc";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }

        //------------------------------------------------------ Tools Methods ---------------------------------------------------//

        //---------- left in to keep users's links working

        [AllowAnonymous]
        public ActionResult Sestina()
        {
            ViewBag.Message = "Your Sestina Page.";

            SestinaModel sm = new SestinaModel();
            sm.Title = "";

            return View(sm);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SestinaModel model)
        {
            if (ModelState.IsValid)
            {

                int[,] poem_structure = new int[,]
                {
                  {1, 2, 3, 4, 5, 6},
                  {6, 1, 5, 2, 4, 3},
                  {3, 6, 4, 1, 2, 5},
                  {5, 3, 2, 6, 1, 4},
                  {4, 5, 1, 3, 6, 2},
                  {2, 4, 6, 5, 3, 1}
                };

                StringBuilder sb = new StringBuilder();

                string[] words = new string[]
                {
                    model.LineEnding1,
                    model.LineEnding2,
                    model.LineEnding3,
                    model.LineEnding4,
                    model.LineEnding5,
                    model.LineEnding6
                };

                string pad = "XXXXXXXX";

                sb.Append(model.Title);
                sb.Append(Environment.NewLine);
                sb.Append(Environment.NewLine);

                for (int x = 0; x < poem_structure.GetLength(0); x += 1)
                {
                    for (int y = 0; y < poem_structure.GetLength(1); y += 1)
                    {
                        int index = poem_structure[x, y];
                        sb.Append(pad + " " + words[index - 1]);
                        sb.Append(Environment.NewLine);
                    }

                    sb.Append(Environment.NewLine);
                }


                // http://classicalpoets.org/how-to-write-a-sestina-with-examples/

                // 1    2   3   4   5   6   number order
                // A    B   C   D   E   F   letter order
                // 0    1   2   3   4   5   the 0 based array

                //   (A) F, (B) E, (C) D   from how to write a sestina "circular sestina"
                //    1  6   2  5   3  4    
                //    0  5   1  4   2  3
                //   (A) F, (B) E, (C) D


                // wikipedia: https://en.wikipedia.org/wiki/Sestina
                // 2–5, 4–3, 6–1
                // B E, D C, F A
                // 

                sb.Append(words[0] + " " + words[5]);   // first envoi line

                sb.Append(Environment.NewLine);
                sb.Append(words[1] + " " + words[4]); // second envoi line

                sb.Append(Environment.NewLine);
                sb.Append(words[2] + " " + words[3]); // third envoi line

                string text = sb.ToString();

                Response.Clear();
                Response.ClearHeaders();

                Response.AppendHeader("Content-Length", text.Length.ToString());
                Response.ContentType = "text/plain";
                Response.AppendHeader("Content-Disposition", "attachment;filename=\"sestina_template.txt\"");

                Response.Write(text);
                Response.End();
            }

            // If we got this far, something failed, redisplay form
            return View("Index", model);
        }

    }
}
