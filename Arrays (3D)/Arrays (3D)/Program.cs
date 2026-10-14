using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of Layers: ");
        int layers = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of Rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of Columns: ");
        int columns = Convert.ToInt32(Console.ReadLine());

        int[,,] arr = new int[layers, rows, columns];

        for (int i=0; i<layers; i++)
        {
            for (int j=0; j < rows; j++)
            {
                for(int k=0; k < columns; k++)
                {
                    Console.Write("Enter the Value for  arr[{0},{1},{2}]: ", i, j, k);
                    arr[i, j, k] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}