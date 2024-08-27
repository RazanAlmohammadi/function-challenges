using System;

namespace FunctionChallenges
{
    class Program
    {
        static string StringNumberProcessor(string world, int number, int number2, string world2)
        {
            string sum = Convert.ToString(number + number2);
            return world + " " + world2 + "; " + sum;

        }

        static void Main(string[] args)
        {
            Console.WriteLine(StringNumberProcessor("Hello", 100, 200, "World"));
        }
    }
}