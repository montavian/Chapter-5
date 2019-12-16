using System;

namespace TestingWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            displayDoWhile();



        }
        public static void displayForLoops()
        {
            for(int i = 10; i > 0; --i)
            {
                Console.WriteLine(i);

            }
            for (int j =10; j >= 0; --j)
            {
                Console.WriteLine(j);
            }
        }
        public static void displayDoWhile()
        {
            int count = 0;
            string response = null;

            
              do{
                Console.WriteLine(count);
                count++;
                } while (count != 10);
                do
                {
                Console.WriteLine(count);
                count--;
                } while (count != 0);
                do
                {
               
            
                Console.WriteLine("Would you like to count agian? Y or N");
                response = Console.ReadLine();

               } while ("Y" != response);
           
            
        }

        public static void displayWhileLoop() {
            int num = 100;
            bool again = true;
            while (again)
                while (num > 0)
                {

                    if (num % 2 == 0)
                    {
                        Console.WriteLine(num);
                    }
                    num = num - 5;


                }
            while (again)
            {
                num = num + 1;
                Console.WriteLine(num);
                if (num == 10)
                {
                    again = false;
                }
            }
        }
    }
}
