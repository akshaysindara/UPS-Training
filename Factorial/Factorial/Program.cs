using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number to calculate its factorial:");
        int number = Convert.ToInt32(Console.ReadLine());
        int ans=1;
        while (number > 0)
        {
            ans *= number;
            number -= 1;
        }
        Console.WriteLine($"Factorial is: {ans}");
    }
}