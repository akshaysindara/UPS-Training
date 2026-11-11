using System;
using Linq.datas;
using Linq.models;
class Program
{
    static void Main(string[] args)
    {
        int[] marks = { 90, 80, 70, 60, 50,20,34,98,56,87,89 };
        Console.WriteLine("Without Using LINQ:");
        foreach (var mark in marks)
        {
            if (mark >= 70)
            {
                Console.Write(mark + " ");
            }
        }

        Console.WriteLine("\nWith Using LINQ(Syntax Method): ");
        var highest= marks.Where(m => m >= 70);
        foreach (var mark in highest)
        {
            Console.Write(mark + " ");
        }

        Console.WriteLine("\nWith Using LINQ(Query Method): ");
        var highestQuery = from mark in marks
                           where mark >= 70
                           select mark;
        foreach (var mark in highestQuery)
        {
            Console.Write(mark + " ");
        }
        var cnt = marks.Count();
        Console.WriteLine("\nCount of elements in array: " + cnt);

        var max = marks.Max();
        Console.WriteLine("\nMaximum element in array: " + max);

        var min = marks.Min();  
        Console.WriteLine("\nMinimum element in array: " + min);

        var sum = marks.Sum();
        Console.WriteLine("\nSum of elements in array: " + sum);

        var avg = marks.Average();
        Console.WriteLine("\nAverage of elements in array: " + avg);

        var ele=  marks.ElementAt(3);
        Console.WriteLine("\nElement at index 3: " + ele);

        var firs = marks.First();
        Console.WriteLine("\nFirst element in array: " + firs);

        var fi=from mark in marks
                select marks.First();
        Console.WriteLine("\nFirst element in array using query method: " + fi.First());

        var emp = EmployeeData.GetAllEmployees();
        var man = EmployeeData.GetAllManagers();

        var grp= from ep in emp group ep by ep.department;
        Console.WriteLine("\nGroup by department: ");
        foreach (var group in grp)
        {
            Console.WriteLine("Department: " + group.Key);
            foreach (var employee in group)
            {
                Console.WriteLine("  - " + employee.Name);
            }
        }

        //var join = from ep in emp
        //           join mn in man on ep.department equals mn.department
        //           select new { EmployeeName = ep.Name, ManagerName = mn.Name, Department = ep.department };
        //Console.WriteLine("\nJoined Employee and Manager data: ");
        //foreach (var item in join)
        //{
        //    Console.WriteLine($"Employee: {item.EmployeeName}, Manager: {item.ManagerName}, Department: {item.Department}");
        //}

        List<Employee> std= emp.Where(s=>s.department == "IT").ToList();
        Console.WriteLine("\nEmployees in IT department: ");
        foreach (var employee in std)
        {
            Console.WriteLine("  - " + employee.Name);
        }

        Employee[] empArray = std.ToArray();
        Console.WriteLine("\nEmployees in IT department (Array): ");
        foreach (var employee in empArray)
        {
            Console.WriteLine("  - " + employee.Name);
        }

        Dictionary<int, string> empDict = emp.ToDictionary(e => e.Id, e => e.Name);
        Console.WriteLine("Dictionary of Employees (Id, Name): ");
        foreach (var kvp in empDict)
        {
            Console.WriteLine($"Id: {kvp.Key}, Name: {kvp.Value}");
        }
    }
}