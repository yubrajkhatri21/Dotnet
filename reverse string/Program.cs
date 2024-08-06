using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to reverse:");
            string input = Console.ReadLine();

            string reversed = ReverseString(input);
            Console.WriteLine("Reversed string: " + reversed);
        }

        static string ReverseString(string str)
        {
            char[] charArray = new char[str.Length];
            int index = 0;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                charArray[index++] = str[i];
            }

            return new string(charArray);
        }
    }
}
