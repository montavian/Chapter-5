using System;

namespace multiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.Write(i + "\t");
                for (int x = 1; x <= 10; x++)
                {
                    if (i > 0)
                        Console.Write(i * x + "\t");
                    else
                        Console.Write(x + "\t");
                }
                Console.Write("\n");
            }
        }
    }
}
