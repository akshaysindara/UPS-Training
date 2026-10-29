using System;
using System.Diagnostics;
using System.Text;

class Program
{
    public static void Main()
    {
        Stopwatch s1 = new Stopwatch();
        
        s1.Start();
        StringBuilder s = new StringBuilder();
        s.Append("HI");
        int a = s.Capacity;
        Console.WriteLine("String : " + s + "\nCapacity : " + a);
        s.Append(" Im Akshay Sindar");
        a = s.Capacity;
        Console.WriteLine("String : " + s + "\nCapacity : " + a);
        s1.Stop();
        Console.WriteLine("Elasped time: " + s1.ElapsedMilliseconds);

        
        
    }
}