using System;
using System.Globalization;
using function_challenges;
using function_challenges.src;

namespace FunctionChallenges
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(StringNumProcessor.StringNumberProcessor("Hello", 100, 200, "World"));
            Game.GuessingGame();



        }

    }
}