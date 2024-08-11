using System;

class Program
{
    static void Main()
    {
        int number = 10;

        // Display initial value
        Console.WriteLine($"Initial value: {number}");

        // Increment operation
        Console.WriteLine($"After increment (number++): {number++}");
        Console.WriteLine($"Value after increment operation: {number}");

        // Decrement operation
        Console.WriteLine($"After decrement (number--): {number--}");
        Console.WriteLine($"Value after decrement operation: {number}");
    }
}
