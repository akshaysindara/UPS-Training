using System;
class Student
{
    private string name;
    private int mark;
    public void SetName(string studentName)
    {
        name = studentName;
    }
    public string GetName()
    {
        return name;
    }
    public void SetMark(int Mark)
    {
        if (Mark > 0)
        {
            mark = Mark;
        }
        else
        {
            Console.WriteLine("Mark must be a positive number.");
        }
    }
    public int GetMark()
    {
        return mark;
    }

    public void DisplayStudentInfo()
    {
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Student Mark: " + mark);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        student.SetName("Akshay");
        student.SetMark(78);
        //student.age = 20; Error: Cannot access private field 'age' outside the class
       /* Console.WriteLine("Student Name: " + student.GetName());
        Console.WriteLine("Student Mark: " + student.GetMark());*/
        student.DisplayStudentInfo();
    }
}