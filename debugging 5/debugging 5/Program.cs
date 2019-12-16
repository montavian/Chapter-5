using System;

namespace debugging_5
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ITEM209 = "209";
            const string ITEM312 = "312";
            const string ITEM414 = "414";
            const double PRICE209 = 12.99, PRICE312 = 16.77, PRICE414 = 109.07;
            double price = 0;
            string stockNum;
            Console.WriteLine("Please enter the stock number of the item you want ");
            stockNum = Console.ReadLine();
            while (stockNum != ITEM209 && stockNum != ITEM312 && stockNum != ITEM414)
            {
                Console.WriteLine("Invalid stock number. Please enter again. ");
                stockNum = Console.ReadLine();

                if (stockNum == ITEM209)
                {
                    price = PRICE209;
                }

                else if (stockNum == ITEM312)
                {
                    price = PRICE414;
                }

                else
                {
                    price = PRICE312;
                }
               
            }
            Console.WriteLine("The price for item # " + stockNum + " is " + price + ".");
               
           
        }
    }
}
