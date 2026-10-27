using System;

class Program
{
    int num;
    string name;
    public Program(int num, string name)
    {
        this.num = num; 
        this.name = name; 
    }
    static void Main(string[] args)
    {
        
        Program s1 = new Program(5, "Akshay");
        Console.WriteLine("Number: " + s1.num + ", Name: " + s1.name);
        s1.num = 10; 
        s1.name = "Ram"; 
        Console.WriteLine("Number: " + s1.num + ", Name: " + s1.name);
    }
}