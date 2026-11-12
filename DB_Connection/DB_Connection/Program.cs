using MySql.Data.MySqlClient;
using System;

class Program
{
    static void Main(string[] args)
    {
        var connectionString = "Server=localhost;Database=employee;User=root;Password=Akshay@2005;";
        try
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                Console.WriteLine("Connection successful!");

                Console.WriteLine("How many records do you want to insert?");
                int recordCount = Convert.ToInt32(Console.ReadLine());
                var empid = 0;
                var name = "";
                var email = "";
                var phone = 0;
                for (int i = 0; i < recordCount; i++)
                {
                    Console.WriteLine($"Enter details for record {i + 1}:");
                    Console.Write("Employee ID: ");
                    empid = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    Console.Write("Email: ");
                    email = Console.ReadLine();
                    Console.Write("Phone: ");
                    phone = Convert.ToInt32(Console.ReadLine());

                    using (var cmd = new MySqlCommand("INSERT INTO employeedetails (empid, name, email, phone) VALUES (@empid, @name, @email, @phone)", conn))
                    {
                        cmd.Parameters.AddWithValue("@empid", empid);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        Console.WriteLine($"{rowsAffected} record(s) inserted successfully.");
                    }
                }


                Console.WriteLine("Do you want to update email record? (yes/no)");
                string updateChoice = Console.ReadLine().ToLower();
                if (updateChoice != "y")
                {
                    Console.WriteLine("No records will be updated.");
                    return;
                }
                Console.WriteLine($"Enter Employee ID to update email: ");
                empid = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Enter details for record: ");


                Console.Write("Email: ");
                email = Console.ReadLine();

                using (var cmd = new MySqlCommand("UPDATE employeedetails set email=@email where empid=@empid", conn))
                {

                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@empid", empid);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} record(s) updated successfully.");
                }

                Console.WriteLine("Employee details after update:");
                var selectCmd = new MySqlCommand("SELECT * FROM employeedetails", conn);
                using (var reader = selectCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Employee ID: {reader["empid"]}, Name: {reader["name"]}, Email: {reader["email"]}, Phone: {reader["phone"]}");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}