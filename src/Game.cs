using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace function_challenges.src
{
    public class Game
    {
       public static void GuessingGame()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(10);
            Console.WriteLine("Guss a number (0-9) ");
            int number = -1;

            while (randomNumber != number)
            {
                number = Convert.ToInt32(Console.ReadLine());
                if (number < 0 || number > 9)
                {
                    Console.WriteLine("Please enter a valid number between 0 and 9.");
                    continue;
                }

                if (randomNumber == number)
                {
                    Console.WriteLine("You guessed the number!!!");
                }
                else if (randomNumber < number)
                {
                    Console.WriteLine("Too high");

                }
                else if (randomNumber > number)
                {
                    Console.WriteLine("Too low");
                }

            }

        }
    }
}