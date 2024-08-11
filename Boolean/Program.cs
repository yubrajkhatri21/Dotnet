using System;

class Program
{
    static void Main()
    {
        // Input: Reading two boolean values from the user
        Console.WriteLine("Enter the first boolean value (true/false):");
        bool bool1 = bool.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second boolean value (true/false):");
        bool bool2 = bool.Parse(Console.ReadLine());

        // Using logical operators
        Console.WriteLine($"\nResults of logical expressions:");
        Console.WriteLine($"{bool1} && {bool2}: {bool1 && bool2}");
        Console.WriteLine($"{bool1} || {bool2}: {bool1 || bool2}");
        Console.WriteLine($"!{bool1}: {!bool1}");
        Console.WriteLine($"!{bool2}: {!bool2}");
    }
}
