using System;

class Program
{
    public delegate void Notification(object message);

    public void MessageHandler(object message)
    {
        Console.WriteLine($"Notification received: {message}");
    }

    public void SendNotification(object message)
    {
        Console.WriteLine("Sending notification... "+ message);
    }

    public void call()
    {
        Notification notification;
        notification = MessageHandler;
        notification("Hello, this is a test notification!");
        notification = SendNotification;
        notification(234);
        
    }
    public int square(int x)
    {
        return x * x;
    }
    public double squareroot(double x)
    {
        return Math.Sqrt(x);
    }

    public void Functions()
    {
        Func<int, int> sq = square;
         int result = sq(5);
        Console.WriteLine($"Square of 5 is {result}");
        Func<double, double> sqrt = squareroot;
        double result2 = sqrt(25.0);
        
        
        Console.WriteLine($"Square root of 25 is {result2}");


        Func<int, int, int> add = (a, b) => a + b;
        Console.WriteLine($"Sum of 5 and 10 is {add(5, 10)}");

        Predicate<int> isEven = x => x % 2 == 0;
        Console.WriteLine($"Is 4 even? {isEven(4)}");

        Action<int> squareAction = x => Console.WriteLine($"Square of {x} is {x * x}");
        squareAction(5);
    }

    public static void Main(string[] args)
    {
        Program program = new Program();
        program.call();
        

    }

}