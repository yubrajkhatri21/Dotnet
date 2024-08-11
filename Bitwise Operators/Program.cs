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

        // Display binary representation
        Console.WriteLine($"\nBinary of {num1}: {Convert.ToString(num1, 2).PadLeft(8, '0')}");
        Console.WriteLine($"Binary of {num2}: {Convert.ToString(num2, 2).PadLeft(8, '0')}");

        // Using bitwise operators
        Console.WriteLine($"\nResults of bitwise operations:");
        Console.WriteLine($"{num1} & {num2}: {num1 & num2} ({Convert.ToString(num1 & num2, 2).PadLeft(8, '0')})");
        Console.WriteLine($"{num1} | {num2}: {num1 | num2} ({Convert.ToString(num1 | num2, 2).PadLeft(8, '0')})");
        Console.WriteLine($"{num1} ^ {num2}: {num1 ^ num2} ({Convert.ToString(num1 ^ num2, 2).PadLeft(8, '0')})");
        Console.WriteLine($"~{num1}: {~num1} ({Convert.ToString(~num1, 2).PadLeft(8, '0')})");
        Console.WriteLine($"{num1} << 1: {num1 << 1} ({Convert.ToString(num1 << 1, 2).PadLeft(8, '0')})");
        Console.WriteLine($"{num1} >> 1: {num1 >> 1} ({Convert.ToString(num1 >> 1, 2).PadLeft(8, '0')})");
    }
}
