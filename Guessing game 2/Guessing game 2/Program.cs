using System;

namespace Guessing_game_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int r = rnd.Next(1, 100);
            int userEntry;
            int tries = 0;
            bool again = true;
           
            while (again)
            {
                Console.WriteLine("Please enter a number between 1 - 100");
                userEntry = Convert.ToInt32(Console.ReadLine());
                if (userEntry > r)
                {
                    Console.WriteLine("To high try again");
                }
                else if (userEntry < r)
                {
                    Console.WriteLine("No thats to low");
                }
                else if (userEntry == r)
                {
                    Console.WriteLine("good I guess");
                     tries++;
                    Console.WriteLine("You have won ");
                    Console.WriteLine("you have tried " + tries + " Times ", tries);
                    again = false;
                }
               
            }

        }
    }
}
