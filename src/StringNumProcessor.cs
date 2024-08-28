using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace function_challenges
{
    public class StringNumProcessor
    {
        public static string StringNumberProcessor(params object[] inputs)
        {
            string combinedText = "";
            int totalSum = 0;

            foreach (var item in inputs)
            {
                if (item is string)
                {
                    combinedText += (string)item + " ";
                }
                else if (item is int)
                {
                    totalSum += (int)item;
                }
            }

            combinedText = combinedText.Trim();
            return combinedText + "; " + totalSum;
        }
    }
}