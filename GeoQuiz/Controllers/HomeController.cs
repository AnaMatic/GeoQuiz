﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GeoQuiz.Models;
using System.Web.UI;

namespace GeoQuiz.Controllers
{
    
    public class HomeController : Controller
    {
        Random rand = new Random();
        List<string> drzave = new List<string>();
        [HttpGet] 
        public ActionResult Index()
        {
            return View();
        }



        [HttpGet]
        public ActionResult Play()
        {
            
            drzave.Add("Croatia");
            drzave.Add("Serbia & Montenegro");
            drzave.Add("Bosnia & Herzegovina");
            drzave.Add("Germany");
            drzave.Add("Switzerland");
            int r = rand.Next(drzave.Count);

            ViewBag.ListDrzave = drzave;
            ViewBag.Random = ((string)drzave[r]); //OVO JE DRZAVA KOJA SE SALJE U Play.cshtml U 20. LINIJU KODA
            ViewBag.Message = "Test lista";
            Console.WriteLine(ViewBag.Random);


            
            return View(new CheckContinent());
        }

        [HttpPost]
        public string Show(FormCollection postedForm, CheckContinent model)
        {

            string val = "";

            foreach (var con in model.Continents)
            {

                if (postedForm[con].ToString().Contains("true"))
                {

                    val = val + " " + con;

                }

            }

            return "Selected continents are: <b>" + val + "</b>";
        }

        public ActionResult Instructions()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [ChildActionOnly]
        public ActionResult RandomDrzava()
        {
            drzave.Add("Croatia");
            drzave.Add("Serbia & Montenegro");
            drzave.Add("Bosnia & Herzegovina");
            drzave.Add("Germany");
            drzave.Add("Switzerland");
            int r = rand.Next(drzave.Count);
            string odabrana = ((string)drzave[r]);
           /* ScriptManager.RegisterStartupScript(this,
                                                        this.GetType(),
                                                        "Funct",
                                                        "drz = " + odabrana + ";",
                                                        true);*/

            return Content(odabrana, "text/html");
        }
    }
}