using System;

namespace HomeSales
{
    class Program
    {
        static void Main(string[] args)
        {
            string userEntry;
            int totalD = 0;
            int totalE = 0;
            int totalF = 0;
            int allTotal;
            int saleEntry;
            bool again = true;
            while (again) {
                Console.WriteLine("Which sales person was responsible for this sale please use the initial of that person.");
                userEntry = Console.ReadLine();
                if (userEntry == "D")
                {
                    Console.WriteLine("Enter the amount that property was sold to you for.");
                    saleEntry = Convert.ToInt32(Console.ReadLine());
                    totalD = totalD + saleEntry;
                    Console.WriteLine("If you wish to see the total type quit");
                }
                else if (userEntry == "E")
                {
                    Console.WriteLine("Enter the amount that property was sold to you for.");
                    saleEntry = Convert.ToInt32(Console.ReadLine());
                    totalE = totalE + saleEntry;
                    Console.WriteLine("If you wish to see the total type quit");
                }

                else if (userEntry == "F")
                {
                    Console.WriteLine("Enter the amount that property was sold to you for.");
                    saleEntry = Convert.ToInt32(Console.ReadLine());
                    totalF = totalF + saleEntry;
                    Console.WriteLine("If you wish to see the total type quit");
                }
                else if (userEntry == "quit")
                {
                    again = false;
                }
                

            }
            if (totalF > totalE && totalF > totalD)
            {
                 allTotal = totalF + totalE + totalD;

                Console.WriteLine("The total of F is the highest at {0}. The total Of E is {1}. And the total of D is {2}", totalF, totalE, totalD);
                Console.WriteLine("The complete total of all the sales people is {0}", allTotal);
            }
            if (totalE > totalF && totalE > totalD)
            {
                allTotal = totalF + totalE + totalD;

                Console.WriteLine("The total of F is the highest at {0}. The total Of E is {1}. And the total of D is {2}", totalF, totalE, totalD);
                Console.WriteLine("The complete total of all the sales people is {0}", allTotal);
            }
            if (totalD > totalE && totalD > totalF)
            {
                allTotal = totalF + totalE + totalD;

                Console.WriteLine("The total of F is the highest at {0}. The total Of E is {1}. And the total of D is {2}", totalF, totalE, totalD);
                Console.WriteLine("The complete total of all the sales people is {0}", allTotal);
            }
        }
    }
}
