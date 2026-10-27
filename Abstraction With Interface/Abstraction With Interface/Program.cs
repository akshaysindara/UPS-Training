using System;

interface IStaff
{
    void work();
}

interface IStudent
{
    void study();
}

interface IPrincipal
{
    void manage();
}

class College : IStaff, IStudent, IPrincipal
{
    public void work()
    {
        Console.WriteLine("Staff is working.");
    }
    public void study()
    {
        Console.WriteLine("Student is studying.");
    }
    public void manage()
    {
        Console.WriteLine("Principal is managing the college.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        College c1 = new College();
        c1.work();
        c1.study();
        c1.manage();

    }
}
