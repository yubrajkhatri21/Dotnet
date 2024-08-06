using System;

namespace PrimeNumbersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the start number:");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the end number:");
            int end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Prime numbers between {start} and {end} are:");

            for (int number = start; number <= end; number++)
            {
                if (IsPrime(number))
                {
                    Console.WriteLine(number);
                }
            }
        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
