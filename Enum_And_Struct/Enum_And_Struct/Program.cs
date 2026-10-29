using System;


//Enumerables
enum Days
{
    Sun=1, Mon, Tues, Wed, Thurs, Fri, Sat
};


//Struct

public struct Data
{
    public string Name;
    public int Age;
    public int RegNo;
    public void ds()
    {
        Console.WriteLine("\nStruct");
        Console.WriteLine("Name: "+Name+" Age: "+Age+" Regno: "+RegNo);
    }
}

class Program
{
    static void Main()
    {
       
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.DarkMagenta;

        Console.WriteLine("Enumerables");


        foreach (Days a in Enum.GetValues<Days>())
        {
            Console.WriteLine(a);
        }

        

        Data ds = new Data()
        {
            Name = "Akshay",
            Age = 12,
            RegNo = 009
        };
        ds.ds();
    }
}