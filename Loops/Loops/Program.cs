using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 0;
        int b = 1;

        int n = 5;

        Console.WriteLine("Fibonacci series in For loop:");
        for (int j = 0; j < n; j++)
        {
            Console.WriteLine("Fibonacci series: " + a);
            int c = a + b;
            a = b;
            b = c;
        }
        Console.WriteLine();
        Console.WriteLine("Sum Of Digits in While Loop:");
        int i = 0;
        Console.Write("Enter A Number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        while (num>0)
        {
            int temp = num % 10;
            sum = sum +temp;
            num = num/10;
        }
        Console.WriteLine("Sum of digits: " + sum);
        Console.WriteLine();

        int val = 0;

        Console.WriteLine("Menu");
        do
        {
            Console.WriteLine();
            Console.WriteLine("1. BreakFast");
            Console.WriteLine("2. Lunch");
            Console.WriteLine("3. Dinner");
            Console.WriteLine("4. Exit");
            Console.WriteLine();
            Console.Write("Enter your option: ");
            int option = Convert.ToInt32(Console.ReadLine());
            val = option;
            switch (option)
            {
                case 1:
                    Console.WriteLine("You have selected BreakFast");
                    break;
                case 2:
                    Console.WriteLine("You have selected Lunch");
                    break;
                case 3:
                    Console.WriteLine("You have selected Dinner");
                    break;
                case 4:
                    Console.WriteLine("Exiting the menu");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        } while (val != 4);


    }
}
