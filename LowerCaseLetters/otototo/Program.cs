using System;

namespace otototo
{
    class Program
    {
        static void Main(string[] args)
        {
            int entry;
            int total = 0;
            for (int i = 0; i < 4; ++i)
            {
                Console.WriteLine("Please enter a number >>>>>");
                entry = Convert.ToInt32(Console.ReadLine());
                total = total + entry;
                
            }
            Console.WriteLine(total);
        }
    }
}
