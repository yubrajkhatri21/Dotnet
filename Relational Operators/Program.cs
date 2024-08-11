using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first integer:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second integer:");
        int num2 = int.Parse(Console.ReadLine());

        // Using relational operators
        Console.WriteLine($"\nResults of comparisons:");
        Console.WriteLine($"{num1} == {num2}: {num1 == num2}");
        Console.WriteLine($"{num1} != {num2}: {num1 != num2}");
        Console.WriteLine($"{num1} > {num2}: {num1 > num2}");
        Console.WriteLine($"{num1} < {num2}: {num1 < num2}");
        Console.WriteLine($"{num1} >= {num2}: {num1 >= num2}");
        Console.WriteLine($"{num1} <= {num2}: {num1 <= num2}");
    }
}
