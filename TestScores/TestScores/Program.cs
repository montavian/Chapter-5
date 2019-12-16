using System;

namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            int userEntry;
            string userEntry2;
            int total = 0;
            int classAverage;
            const int LOW = 0;
            const int HIGH = 100;
            bool again = true;
            Console.WriteLine("enter your test scores");
            while (again) 
            {
               userEntry = Convert.ToInt32(Console.ReadLine());
                userEntry2 = Console.ReadLine();
                total = total + userEntry;
                if (userEntry < LOW || userEntry > HIGH)
                {
                    Console.WriteLine("this input is not withen the correct values.");
                }
                else if (userEntry2 == "quit")
                {
                    again = false;
                    classAverage = total % total;
                    Console.WriteLine("the average of the class score is {0}.", userEntry);
                }
            } 
               

            
            Console.WriteLine("The score is not withen the limits of a propere score. ");

        }
    }
}
