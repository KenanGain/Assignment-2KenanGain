using Assignment_2KenanGain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.Remoting.Lifetime;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Assignment_2KenanGain.Controllers
{
    public class J2Controller : Controller
    {
        /// <summary>
        /// J2: Epidemiology
        /// Problem Description
        /// People who study epidemiology use models to analyze the spread of disease.In this problem, we
        /// use a simple model.
        /// When a person has a disease, they infect exactly R other people but only on the very next day.No
        /// person is infected more than once. We want to determine when a total of more than P people have
        /// had the disease.
        /// (This problem was designed before the current coronavirus outbreak, and we acknowledge the
        /// distress currently being experienced by many people worldwide because of this and other diseases.
        /// We hope that including this problem at this time highlights the important roles that computer
        /// science and mathematics play in solving real-world problems.)
        /// 
        /// This MVC take 3 values as first one as number people which will be infected
        /// second one is the number of people at the beginning.
        /// third one is rate of spread by one person.
        /// 
        /// and give out result of number of day to reach entered value of people will be infected.
        /// </summary>
        /// <returns></returns>
        // GET: J2
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AssignmentJ2() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult Result2(int P, int N, int R)
        {
            Values2 NewValues2 = new Values2 
            { 
                P = P,
                N = N,
                R = R,
            
            };
            return View(NewValues2);

        }
    }
}