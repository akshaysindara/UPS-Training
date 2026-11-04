using System;

class MultiThreading
{
    void Test1()
    {
        Console.WriteLine("Test1 Method");
        for (int i = 0; i < 15; i++)
        {
            Console.WriteLine("Test1 Method: " + i);
        }
        Console.WriteLine("Test1 Method Completed");
    }
    void Test2()
    {
        Console.WriteLine("Test2 Method");
        for (int i = 0; i < 15; i++)
        {
            Console.WriteLine("Test2 Method: " + i);
        }
        Console.WriteLine("Test2 Method Completed");
    }
    public static void Main(string[] args)
    {
        MultiThreading obj = new MultiThreading();
        Thread t1=new Thread(obj.Test1);
        Thread t2 = new Thread(obj.Test2);
        //t1.Start();
        Console.WriteLine("T1 Started");
        //t1.Join();
        //t2.Start();
        Console.WriteLine("T2 Started");
        //t1.Join();
        //t2.Join();
        t1.Priority = ThreadPriority.Highest;
        t2.Priority = ThreadPriority.Lowest;
        t1.Start();
        t2.Start();
        Console.WriteLine("Main Method Completed");
    }
}