using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_2KenanGain.Models
{
    public class Values
    {
        public int SmallTreat { get; set; }
        public int MediumTreat { get; set; }
        public int LargeTreat { get; set; }

        public int HappinessScore()
        {
            return 1 * SmallTreat+ 2 * MediumTreat + 3 * LargeTreat;
        }
       

        
    }
}