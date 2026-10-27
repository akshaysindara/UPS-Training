using System;

class StudentInfo  //Multilevel Inheritance Example
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }
    public StudentInfo(string name, int age, string grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Grade: {Grade}");
    }
}

class TeacherInfo : StudentInfo
{
    public string Subject { get; set; }
    public TeacherInfo(string name, int age, string grade, string subject) : base(name, age, grade)
    {
        Subject = subject;
    }
    public void DisplayTeacherInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Grade: {Grade}, Subject: {Subject}");
    }
}

class DepartmentInfo : TeacherInfo
{
    public string Department { get; set; }
    public DepartmentInfo(string name, int age, string grade, string subject, string department) : base(name, age, grade, subject)
    {
        Department = department;
    }
    public void DisplayDepartmentInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Grade: {Grade}, Subject: {Subject}, Department: {Department}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        StudentInfo student = new StudentInfo("Alice", 20, "A");
        student.DisplayInfo();
        TeacherInfo teacher = new TeacherInfo("Bob", 35, "B", "Mathematics");
        teacher.DisplayTeacherInfo();
        DepartmentInfo department = new DepartmentInfo("Charlie", 40, "C", "Physics", "Science");
        department.DisplayDepartmentInfo();
    }
}
        