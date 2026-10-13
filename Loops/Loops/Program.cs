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

        Console.WriteLine();
        Console.WriteLine("Working With Nested For Loops:");

        int rows = 4;
        int columns=5;

        for (int r=0;r<rows; r++)
        {
            for (int c = 0; c < columns; c++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Printing Matrix With 1-10 numsbers:");

        int i = 0;
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < columns; c++)
            {
                i++;
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Working With For-Each Loops:");

        int [] arr= { 1, 2, 3, 4, 5 };

        foreach (int k in arr)
        {
            Console.WriteLine(k);
        }



    }
}
