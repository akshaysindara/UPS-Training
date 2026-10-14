using System;

class Program
{
    static void Main(string[] args)
    {
        int[,,] arr = {
                        { { 1, 2 }, { 3, 4 } },
                        { { 5, 6 }, { 7, 8 } }
                };
        Console.Write("The Odd Elements in the 3D Array are: ");
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int k = 0; k < arr.GetLength(2); k++)
                {
                    if (arr[i, j, k] % 2 != 0)
                    {
                        Console.Write(arr[i,j,k]+" ");
                    }
                }
            }
        }
        
        Console.WriteLine();    
        Console.Write("The Even Elements in the 3D Array are: ");
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int k = 0; k < arr.GetLength(2); k++)
                {
                    if (arr[i, j, k] % 2 == 0)
                    {
                        Console.Write(arr[i, j, k] + " ");
                    }
                }
            }
        }
    }
}