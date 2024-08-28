using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace function_challenges
{
    public class StringNumProcessor
    {
       public static string StringNumberProcessor(string world, int number, int number2, string world2)
        {
            string sum = Convert.ToString(number + number2);
            return world + " " + world2 + "; " + sum;

        } 
    }
}