using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using Assignment_2KenanGain.Models;

namespace Assignment_2KenanGain.Controllers
{
    /// <summary>
    /// Problem J1: Dog Treats
    /// Problem Description
    /// Barley the dog loves treats.At the end of the day he is either happy or sad depending on the number and size of treats he receives throughout the day.The treats come in three sizes: small,medium, and large.His happiness score can be measured using the following formula:
    /// 1 × S + 2 × M + 3 × L
    /// where S is the number of small treats, M is the number of medium treats and L is the number of large treats.
    /// If Barley’s happiness score is 10 or greater then he is happy.Otherwise, he is sad.Determine
    /// whether Barley is happy or sad at the end of the day.
    /// 
    /// This mvc take input 3 values using html form first one is for small treat, next one for medium & third for large
    /// after calculation it will provide output to the user
    /// if result of value after happiness counter is higher than 10 happiness counter will give out happy result viseversa for sad.
    ///
    /// </summary>
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
            // assigning entered values
            Values NewValues = new Values
            {
                SmallTreat = SmallTreat,
                MediumTreat = MediumTreat,
                LargeTreat = LargeTreat,


            };
            // returning new values
            return View(NewValues);

           

        
        }

    }
}