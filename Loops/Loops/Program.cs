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

        int i = 0;
        Console.WriteLine("Enter A No");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        while (num>0)
        {
            int temp = num % 10;
            sum = sum +temp;
            num = num/10;
        }
        Console.WriteLine("Sum of digits: " + sum);


    }
}
