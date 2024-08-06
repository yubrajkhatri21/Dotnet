using System;

namespace NumberPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i > 40)
                {
                    break; // Stop the loop if the number exceeds 40
                }

                if (i % 3 == 0)
                {
                    continue; // Skip multiples of 3
                }

                Console.WriteLine(i);
            }
        }
    }
}
