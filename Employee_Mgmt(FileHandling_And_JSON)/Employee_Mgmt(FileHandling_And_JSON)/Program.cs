using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

class Employee
{
    public int EmpId { get; set; }
    public string Name { get; set; } = "";
    public string Department { get; set; } = "";
    public decimal Salary { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        string txtPath = "Employees.txt";
        string jsonPath = "Employees.json";

        // Load existing employee data from JSON
        List<Employee> employees = new List<Employee>();

        if (File.Exists(jsonPath))
        {
            string existingData = File.ReadAllText(jsonPath);

            if (!string.IsNullOrWhiteSpace(existingData))
            {
                employees = JsonSerializer.Deserialize<List<Employee>>(existingData)
                            ?? new List<Employee>();
            }
        }

        string ans = "y";

        while (ans == "y")
        {
            Console.WriteLine("\n========== EMPLOYEE MANAGEMENT ==========");

            Employee emp = new Employee();

            Console.Write("Enter Employee ID: ");
            emp.EmpId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            emp.Name = Console.ReadLine() ?? "";

            Console.Write("Enter Department: ");
            emp.Department = Console.ReadLine() ?? "";

            Console.Write("Enter Salary: ");
            emp.Salary = Convert.ToDecimal(Console.ReadLine());

            // Add employee object to List
            employees.Add(emp);

            // STEP 1: Write employee details into TXT file
            using (FileStream fs = new FileStream(
                txtPath, FileMode.Append, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                if (fs.Length == 0)
                {
                    sw.WriteLine("EMPLOYEE DETAILS");
                    sw.WriteLine("----------------------------------------");
                    sw.WriteLine("ID | Name | Department | Salary");
                }

                string details =
                    $"{emp.EmpId} | {emp.Name} | {emp.Department} | {emp.Salary}";

                sw.WriteLine(details);
            }

            Console.WriteLine("\nEmployee added to TXT file successfully!");

            
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string jsonData = JsonSerializer.Serialize(employees, options);

        
            File.WriteAllText(jsonPath, jsonData);

            Console.WriteLine("Employee data converted and saved to JSON!");

            Console.Write("\nDo you want to add another employee? (Y/N): ");
            ans = (Console.ReadLine() ?? "n").ToLower();
        }

        Console.WriteLine("\n========== TXT FILE CONTENT ==========");

        using (FileStream fs = new FileStream(
            txtPath, FileMode.Open, FileAccess.Read))
        using (StreamReader sr = new StreamReader(fs))
        {
            string content = sr.ReadToEnd();
            Console.WriteLine(content);
        }

        Console.WriteLine("\n========== JSON DESERIALIZATION ==========");

        string jdata = File.ReadAllText(jsonPath);

        List<Employee>? result =
            JsonSerializer.Deserialize<List<Employee>>(jdata);

        if (result != null)
        {
            foreach (Employee e in result)
            {
                Console.WriteLine(
                    $"ID: {e.EmpId}, Name: {e.Name}, " +
                    $"Department: {e.Department}, Salary: {e.Salary}");
            }
        }

        Console.WriteLine("\nProgram completed successfully!");
    }
}
