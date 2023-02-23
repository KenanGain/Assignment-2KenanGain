using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment_2KenanGain.Models;

namespace Assignment_2KenanGain.Controllers
{
    public class J1Controller : Controller
    {
        // GET: J1
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Assignment()
        {
            return View();
        }
       [HttpPost]
        public ActionResult Result(int SmallTreat, int MediumTreat, int LargeTreat) 
        {

            Values NewValues = new Values
            {
                SmallTreat = SmallTreat,
                MediumTreat = MediumTreat,
                LargeTreat = LargeTreat,


            };
            return View(NewValues);

           

        
        }

    }
}