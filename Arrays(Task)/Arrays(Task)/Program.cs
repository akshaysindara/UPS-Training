using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter The No of Elements: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter Element {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();
        Console.Write("The Odd Elements in the Array are: ");
        for (int i = 0; i<n; i++)
        {
            if (arr[i] % 2 != 0)
            {
                Console.Write(arr[i] + " ");
            }
        }
        Console.WriteLine();
        Console.Write("The Even Elements in the Array are: ");
        for (int i = 0; i<n; i++)
        {
            if (arr[i] % 2 == 0)
            {
                Console.Write(arr[i] + " ");
            }
        }

    }

}