using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string to check if it is a palindrome:");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine($"\"{input}\" is a palindrome.");
        }
        else
        {
            Console.WriteLine($"\"{input}\" is not a palindrome.");
        }
    }

    static bool IsPalindrome(string str)
    {
        // Convert the string to lowercase and remove any non-alphanumeric characters
        str = str.ToLower();
        string cleanedStr = "";

        foreach (char c in str)
        {
            if (char.IsLetterOrDigit(c))
            {
                cleanedStr += c;
            }
        }

        // Check if the cleaned string is a palindrome
        int length = cleanedStr.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (cleanedStr[i] != cleanedStr[length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}
