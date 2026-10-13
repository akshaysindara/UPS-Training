using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        BigInteger a = 0;
        BigInteger b = 1;
        Console.Write("Enter the number of terms for Fibonacci series: ");
        if (!BigInteger.TryParse(Console.ReadLine(), out BigInteger n) || n <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        // Print exactly 'n' terms: F0 .. F(n-1)
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Fibonacci series: " + a);
            BigInteger c = a + b;
            a = b;
            b = c;
        }
    }
}
