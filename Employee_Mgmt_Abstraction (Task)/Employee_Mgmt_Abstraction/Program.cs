using System;
public abstract class  Employee
{
    public abstract void Display_Details();
    public abstract void Display_Salary();
    public abstract void Display_role();
}
public class Manager : Employee
{
    public override void Display_Details()
    {
        Console.WriteLine("Manager Details");
    }
    public override void Display_Salary()
    {
        Console.WriteLine("Manager Salary");
    }
    public override void Display_role()
    {
        Console.WriteLine("Manager Role");
    }
}
public class Developer : Employee
{
    public override void Display_Details()
    {
        Console.WriteLine("Developer Details");
    }
    public override void Display_Salary()
    {
        Console.WriteLine("Developer Salary");
    }
    public override void Display_role()
    {
        Console.WriteLine("Developer Role");
    }
}class Program
{
    static void Main(string[] args)
    {
        Employee emp1 = new Manager();
        emp1.Display_Details();
        emp1.Display_Salary();
        emp1.Display_role();
        Employee emp2 = new Developer();
        emp2.Display_Details();
        emp2.Display_Salary();
        emp2.Display_role();
    }
}