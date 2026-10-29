using System;


//Nested Class 
class Employee
{
    public class Dept
    {
        public class Cse
        {
            public void show()
            {
                Console.WriteLine("Nested Class \n");
            }
        }
         
    }
}

//Static Class

static class College
{
    public static void Dept()
    {
        Console.WriteLine("Static Class\n");
    }
}

//Sealed Class

sealed class Developer : Employee
{
    public void show()
    {
        Console.WriteLine("Sealed Class.\n");
    }
}

//Generic Class

class Generic<T>
{
    T value;
    public Generic(T value)
    {
        this.value = value;
    }
    public void show()
    {
        Console.WriteLine("Generic Class With Type: " + typeof(T)+"\n");
    }
}

// Record Class

record Loyola(int a, string b);



class Program
{
    public static void Main()
    {
        Employee.Dept.Cse s = new Employee.Dept.Cse();
        s.show();
        College.Dept();
        Developer d = new Developer();
        d.show();
        Generic<int> g = new Generic<int>(4);
        g.show();
        Loyola a = new Loyola(5, "Akshay");
        Console.Write("Record Class With Data -- ");
        Console.WriteLine("Name: " + a.b + " & Age: " + a.a);
    }
}