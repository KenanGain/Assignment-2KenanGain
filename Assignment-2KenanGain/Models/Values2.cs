using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment_2KenanGain.Models
{
    public class Values2
    {
        public int P { get; set; }
        public int N { get; set; }
        public int R { get; set; }

        public int DayCount()
        {
            int Count = 0;
            int infected = N;
            while (infected <= P) 
            {
                infected += N * R;
                N *= R;
                Count ++;


            
            }
           return Count;

        }
    }
}