using System;

namespace EvenNumbersPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 2; // Start from the first even number

            Console.WriteLine("Even numbers from 1 to 100:");

            while (number <= 100)
            {
                Console.WriteLine(number);
                number += 2; // Move to the next even number
            }
        }
    }
}
