using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CheckingTmp
    {
        //when method is static must be properties static 
        static public float Temp { get; set; }
        static public string Describe { get; set; }
        static public string Recomend { get; set; }
       // static public string InputNum { get; set; }

        public CheckingTmp(float tmpIn = 0)
        {
            Temp = tmpIn;
            CalcTempeture();
        }

        static void CalcTempeture()
        {
            //if (Temp == 0)
            //{
            //    InputNum = "please, input number";
            //}
            if (Temp <= 30)
            {
                Describe = "Temperature is low";
                Recomend = "Drink Limon and cover your self ";
            }
            else if (Temp > 30 && Temp <= 38)
            {
                Describe = "Temperature is normal";
                Recomend = "Have as nice day";
            }
            else
            {
                Describe = "temperature too height";
                Recomend = "Go to hospital";
            }
        }
    }
}