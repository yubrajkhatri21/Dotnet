using System;

namespace PyramidPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = 4; // You can adjust the number of rows as needed

            for (int i = 1; i <= numberOfRows; i++)
            {
                // Print leading spaces
                for (int j = numberOfRows - i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                // Print stars
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

                // Move to the next line
                Console.WriteLine();
            }
        }
    }
}
