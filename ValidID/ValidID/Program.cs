﻿using System;

namespace ValidID
{
    class Program
    {
        static void Main(string[] args)
        {
            displayValidID();
        }
        public static void displayValidID()
        {
            int idNum;
            string input;
            const int LOW = 1000;
            const int HIGH = 9999;

            Console.WriteLine("Enter an ID number");
            input = Console.ReadLine();
            idNum = Convert.ToInt32(input);

            while (idNum < LOW || idNum > HIGH)
            {
                Console.WriteLine("{0} is an invalid ID number", idNum);
                Console.WriteLine("ID number must be ");
                Console.WriteLine("Between {0} and {1} inclusive", LOW, HIGH);
                Console.WriteLine("Enter an ID number: ");
                input = Console.ReadLine();
                idNum = Convert.ToInt32(input);

            }
            Console.WriteLine("ID number {0} is valid", idNum);
        }
    }
}
