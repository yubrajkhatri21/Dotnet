using System;

namespace RepeatedInput
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            do
            {
                Console.WriteLine("Enter a number (enter a negative number to stop):");
                number = Convert.ToInt32(Console.ReadLine());
            } 
            while (number >= 0);

            Console.WriteLine("A negative number was entered. Program ending.");
        }
    }
}
