using System;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to find the sum of its digits:");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int temp = Math.Abs(number); // Use absolute value to handle negative numbers

            while (temp > 0)
            {
                sum += temp % 10;
                temp /= 10;
            }

            Console.WriteLine($"The sum of the digits of {number} is: {sum}");
        }
    }
}
