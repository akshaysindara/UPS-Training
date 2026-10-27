using System;

class Program
{
    static void Main(string[] args)
    {
        MathTeacher t1 = new MathTeacher();
        t1.TimeTable();
        t1.work();
        t1.classroom();
        t1.show();

        ScienceTeacher t2 = new ScienceTeacher();
        t2.TimeTable();
        t2.work();
        t2.classroom();
        t2.show();

    }
}

abstract class Teacher
{

    public abstract void TimeTable();

    public abstract void work();

    public abstract void classroom();

    public void show()
    {
        Console.WriteLine("This is a teacher class");
    }

}

 class MathTeacher : Teacher
{
    public override void TimeTable()
    {
        Console.WriteLine("Math Teacher Time Table");
    }
    public override void work()
    {
        Console.WriteLine("Math Teacher Work");
    }
    public override void classroom()
    {
        Console.WriteLine("Math Teacher Classroom");
    }
}

class ScienceTeacher : Teacher
{
    public override void TimeTable()
    {
        Console.WriteLine("Science Teacher Time Table");
    }
    public override void work()
    {
        Console.WriteLine("Science Teacher Work");
    }
    public override void classroom()
    {
        Console.WriteLine("Science Teacher Classroom");
    }
}


