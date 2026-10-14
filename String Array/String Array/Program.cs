using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the No Of Words You Want To Store In Array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter word {0}: ", i + 1);
            arr[i] = Console.ReadLine();
        }


        Console.WriteLine("\nWords in the array:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(arr[i]);
        }

    }
}