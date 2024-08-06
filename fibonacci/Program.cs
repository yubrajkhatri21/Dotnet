using System;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of terms for the Fibonacci series:");
            int terms = Convert.ToInt32(Console.ReadLine());

            int firstNumber = 0, secondNumber = 1, nextNumber;

            Console.WriteLine("Fibonacci series up to " + terms + " terms:");
            for (int i = 1; i <= terms; i++)
            {
                Console.Write(firstNumber + " ");
                nextNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = nextNumber;
            }
        }
    }
}
