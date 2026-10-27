using System;
class Program
{
    string name;
    public Program()//default
    {
        Console.WriteLine("Default constructor called.");
    }
    
    public Program(string name)//parameterized
    {
        this.name= name;
        Console.WriteLine($"Parameterized constructor called with name: {this.name}");
    }

    static Program()//static 
    {
        Console.WriteLine("Static constructor called.");
    }

    public Program(Program p)//copy 
    {
        this.name = p.name;
        Console.WriteLine($"Copy constructor called with name: {this.name}");
    }

    private Program(int x)//private
    {
        Console.WriteLine($"Private constructor called with value: {x}");
    }
    static void Main(string[] args)
    {
        Program program = new Program();
        Program program2 = new Program("Akshay");
        Program program3 = new Program(5);
    }
}