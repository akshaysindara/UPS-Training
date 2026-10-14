using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter The Row Size: ");
        int r= Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter The Column Size: ");
        int c= Convert.ToInt32(Console.ReadLine());
        int[,] arr= new int[r, c];
        for (int i=0; i < r; i++)
        {
            for (int j=0; j < c; j++)
            {
                Console.Write($"Enter The Element For Row {i} Column {j}: ");
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        int max = arr[0, 0];
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++) 
            {
                if (arr[i, j] > max)
                {
                    max = arr[i, j];
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("The Maximum Element in the 2D Array is " + max);

        int min = arr[0, 0];
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                if (arr[i, j] < min)
                {
                    min = arr[i, j];
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("The Minimum Element in the 2D Array is " + min);

    }
}