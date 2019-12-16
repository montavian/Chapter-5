using System;

namespace SumInt
{
    class Program
    {
        static void Main(string[] args)
        {
            displayEnterLowerCase();
        }
        public static void displaySumInt()
        {
            int entry;
            int total = 0;

            do
            {
                Console.WriteLine("enter a number");
                entry = Convert.ToInt32(Console.ReadLine());
                total = total + entry;

            } while (entry != 999);
            Console.WriteLine(total);

        }
        public static void displayEnterLowerCase()
        {
            char userEntry = 'A';

            
            do
            {
                Console.WriteLine("please enter a lower case letter.");
                userEntry = Convert.ToChar(Console.ReadLine());
                if (Char.IsLower(userEntry))
                    Console.WriteLine("OK");
                else if (userEntry != '!')
                {
                    Console.WriteLine("The letter that was typed is not a lower case letter plaease inter an lowere cases latter.");
                }
            } while (userEntry != '!');

             
             
            


        }
    }
}
