using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Palindrome Checker");
        Console.Write("Enter a number: ");

        if (int.TryParse(Console.ReadLine(), out int number))
        {
            Solution solution = new Solution();
            bool isPalindrome = solution.IsPalindrome(number);

            if (isPalindrome)
            {
                Console.WriteLine($"{number} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{number} is not a palindrome.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}

public class Solution
{
    public bool IsPalindrome(int x)
    {
        // Negative numbers are not palindromes
        // Numeros negativos não são palíndromos
        if (x < 0)
        {
            return false;
        }

        int original = x;
        int reversed = 0;

        while (x > 0)
        {
            int digit = x % 10;
            reversed = reversed * 10 + digit;
            x /= 10;
        }

        return original == reversed;
    }
}
