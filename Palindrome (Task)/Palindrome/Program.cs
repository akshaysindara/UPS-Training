using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a string to check if it's a palindrome:");
        string str = Console.ReadLine();
        int length = str.Length;
        int start = 0, end = length - 1;
        while (start < end)
        {
            if (str[start] != str[end])
            {
                Console.WriteLine("The string is not a palindrome.");
                return;
            }
            start++;
            end--;
        }
        
        Console.WriteLine("The string is a palindrome.");

        Console.WriteLine();

        Console.WriteLine("Integer Palindrome Check");
        Console.Write("Enter an integer to check if it's a palindrome:");
        int num = Convert.ToInt32(Console.ReadLine());
        int originalNum = num;
        int reversedNum = 0;
        while (num > 0)
        {
            int digit = num % 10;
            reversedNum = reversedNum * 10 + digit;
            num /= 10;
        }
        if (originalNum == reversedNum)
        {
            Console.WriteLine("The integer is a palindrome.");
        }
        else
        {
            Console.WriteLine("The integer is not a palindrome.");
        }
    }
    
}