using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace function_challenges.src
{
    public class UpdateProfiles
    {
        public static void UpdateProfile(ref string name, ref int age, ref string email)
        {
            Console.Write("\nEnter your new name: ");
            name = Console.ReadLine();
            Console.WriteLine("Name updated to: " + name);

            Console.Write("Enter your new age: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Age updated to: " + age);


            Console.Write("Enter your new email: ");
            email = Console.ReadLine();
            Console.WriteLine("Email updated to: " + email);
        }
    }
}