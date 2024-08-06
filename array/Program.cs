using System;

namespace ArraySumAndAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in the array:");
            int numberOfElements = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[numberOfElements];
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < numberOfElements; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < numberOfElements; i++)
            {
                sum += array[i];
            }

            double average = (double)sum / numberOfElements;

            Console.WriteLine("The sum of the elements is: " + sum);
            Console.WriteLine("The average of the elements is: " + average);
        }
    }
}
