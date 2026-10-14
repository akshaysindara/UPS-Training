using System;
using System.Net.Sockets;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of elements in the array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        int x = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element " + (x+1) + ": ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
            x++;
        }

        Console.WriteLine();

        int max = arr[0];
        for (int i = 0; i < n; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];

            }
        }
        Console.WriteLine("The maximum value in the array is: " + max);

        Console.WriteLine();

        int min = arr[0];

        for (int i=0; i < n; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        Console.WriteLine("The minimum value in the array is: " + min);

        Console.WriteLine();

        int sum = 0;

        for (int i=0; i < n; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine("The Sum Of The Array Is: " + sum);

        Console.WriteLine();

    }
}