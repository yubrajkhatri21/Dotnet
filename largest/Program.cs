using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            int largestNumber = firstNumber;

            if (secondNumber > largestNumber)
            {
                largestNumber = secondNumber;
            }

            if (thirdNumber > largestNumber)
            {
                largestNumber = thirdNumber;
            }

            Console.WriteLine("The largest number is: " + largestNumber);
        }
    }
}
