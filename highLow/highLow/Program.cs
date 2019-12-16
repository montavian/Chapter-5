using System;

namespace highLow
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
                }

                tries = tries + 1;
                if (tries == 6)
                {
                  Console.WriteLine("You have run out of guesses");
                  again = false;
                }
                else if (tries < 6)
                {
                    Console.WriteLine("You have won ");
                    again = false;
                }
               
            }

        }
    }
}
