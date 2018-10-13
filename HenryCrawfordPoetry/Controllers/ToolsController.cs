using Models;
using System;
using System.Text;
using System.Web.Mvc;

namespace HenryCrawfordPoetry.Controllers
{
    public class ToolsController : Controller
    {

        //------------------------------------------------------ Tools Methods ---------------------------------------------------//

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
        public ActionResult CreateSestina(SestinaModel model)
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
            return View("Sestina", model);
        }

        [AllowAnonymous]
        public ActionResult Villanelle()
        {
            ViewBag.Message = "Your Villanelle Page.";

            VillanelleModel vm = new VillanelleModel();
            vm.Title = "";
            

            return View(vm);
        }


        // CreateVillanelle
        [HttpPost]
        [AllowAnonymous]
        public ActionResult CreateVillanelle(VillanelleModel vm)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(vm.Title);
            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);

            sb.Append(vm.Line1);
            sb.Append(Environment.NewLine);
            sb.Append(vm.Line2);
            sb.Append(Environment.NewLine);
            sb.Append(vm.Line3);

            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);

            sb.Append(vm.Line4);
            sb.Append(Environment.NewLine);
            sb.Append(vm.Line5);
            sb.Append(Environment.NewLine);
            sb.Append(vm.Line6);

            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);

            sb.Append(vm.Line7);
            sb.Append(Environment.NewLine);
            sb.Append(vm.Line8);
            sb.Append(Environment.NewLine);
            sb.Append(vm.Line9);

            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);

            sb.Append(vm.Line10);
            sb.Append(Environment.NewLine);
            sb.Append(vm.Line11);
            sb.Append(Environment.NewLine);
            sb.Append(vm.Line12);

            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);

            sb.Append(vm.Line13);
            sb.Append(Environment.NewLine);
            sb.Append(vm.Line14);
            sb.Append(Environment.NewLine);
            sb.Append(vm.Line15);

            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);

            sb.Append(vm.Line16);
            sb.Append(Environment.NewLine);
            sb.Append(vm.Line17);
            sb.Append(Environment.NewLine);
            sb.Append(vm.Line18);
            sb.Append(Environment.NewLine);
            sb.Append(vm.Line19);

            string text = sb.ToString();

            Response.Clear();
            Response.ClearHeaders();

            Response.AppendHeader("Content-Length", text.Length.ToString());
            Response.ContentType = "text/plain";
            Response.AppendHeader("Content-Disposition", "attachment;filename=\"villanelle_template.txt\"");

            Response.Write(text);
            Response.End();

            // If we got this far, something failed, redisplay form
            return View("Villanelle", vm);
        }

        [AllowAnonymous]
        public ActionResult ManuscriptTemplates()
        {
            ViewBag.Message = "Manuscript Templates";
            return View();
        }


    }
}
