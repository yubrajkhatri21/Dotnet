using System;

class Program
{
    static void Main()
    {
        // Input: Reading two integers from the user
        Console.WriteLine("Enter the first integer:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second integer:");
        int num2 = int.Parse(Console.ReadLine());

        // Performing the operations
        int addition = num1 + num2;
        int subtraction = num1 - num2;
        int multiplication = num1 * num2;
        double division = (double)num1 / num2;  // Casting to double for accurate division
        int modulus = num1 % num2;

        // Output: Displaying the results
        Console.WriteLine($"\nResults:");
        Console.WriteLine($"{num1} + {num2} = {addition}");
        Console.WriteLine($"{num1} - {num2} = {subtraction}");
        Console.WriteLine($"{num1} * {num2} = {multiplication}");
        Console.WriteLine($"{num1} / {num2} = {division}");
        Console.WriteLine($"{num1} % {num2} = {modulus}");
    }
}
