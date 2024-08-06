using System;

namespace CalculatorWithMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 5)
                {
                    Console.WriteLine("Exiting the program.");
                    break;
                }

                Console.WriteLine("Enter the first number:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;
                bool validOperation = true;

                switch (choice)
                {
                    case 1:
                        result = num1 + num2;
                        Console.WriteLine($"The result of addition is: {result}");
                        break;
                    case 2:
                        result = num1 - num2;
                        Console.WriteLine($"The result of subtraction is: {result}");
                        break;
                    case 3:
                        result = num1 * num2;
                        Console.WriteLine($"The result of multiplication is: {result}");
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine($"The result of division is: {result}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                            validOperation = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please choose a valid operation.");
                        validOperation = false;
                        break;
                }

                if (validOperation)
                {
                    Console.WriteLine($"The result is: {result}");
                }
                Console.WriteLine();
            }
        }
    }
}
