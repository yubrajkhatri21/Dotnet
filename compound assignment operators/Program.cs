using System;

class Program
{
    static void Main()
    {
        int num1 = 10;
        int num2 = 5;

        // Using compound assignment operators
        Console.WriteLine($"Initial values: num1 = {num1}, num2 = {num2}");

        num1 += num2;
        Console.WriteLine($"After num1 += num2: num1 = {num1}");

        num1 -= num2;
        Console.WriteLine($"After num1 -= num2: num1 = {num1}");

        num1 *= num2;
        Console.WriteLine($"After num1 *= num2: num1 = {num1}");

        num1 /= num2;
        Console.WriteLine($"After num1 /= num2: num1 = {num1}");
    }
}
