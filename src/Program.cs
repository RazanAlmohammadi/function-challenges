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
            // Console.WriteLine(StringNumProcessor.StringNumberProcessor("Hello", 100, 200, "World"));
            // Game.GuessingGame();
            //string sentence = "This is the original sentence!";
            //Console.WriteLine(sentence);
            //Console.WriteLine(ReverseWord.ReverseWords(sentence));
            string name = "John Doe";
            int age = 28;
            string email = "john@gmail.com";
            Console.WriteLine("Initial Profile:\n");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Email: " + email);

            UpdateProfiles.UpdateProfile(ref name, ref age, ref email);

            Console.WriteLine("\nUpdated Profile:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Email: " + email);


        }

    }
}