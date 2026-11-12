using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;

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

                bool exit = false;

                while (!exit)
                {
                    Console.WriteLine("\n==============================");
                    Console.WriteLine("   EMPLOYEE MANAGEMENT MENU   ");
                    Console.WriteLine("==============================");
                    Console.WriteLine("1. Insert Records");
                    Console.WriteLine("2. Update Employee Email");
                    Console.WriteLine("3. Display All Records");
                    Console.WriteLine("4. Search Record by ID");
                    Console.WriteLine("5. Delete Record");
                    Console.WriteLine("6. Name Starting With Vowels");
                    Console.WriteLine("7. Exit");
                    Console.Write("Enter your choice (1-7): ");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.Write("\nHow many records do you want to insert? ");
                            int recordCount = Convert.ToInt32(Console.ReadLine());

                            for (int i = 0; i < recordCount; i++)
                            {
                                Console.WriteLine($"\nEnter details for record {i + 1}:");
                                Console.Write("Employee ID: ");
                                int empid = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Name: ");
                                string name = Console.ReadLine();
                                Console.Write("Email: ");
                                string email = Console.ReadLine();
                                Console.Write("Phone: ");
                                string phone = Console.ReadLine(); 
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
                            break;

                        case "2":
                            Console.Write("\nEnter Employee ID to update email: ");
                            int updateEmpId = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter new Email: ");
                            string newEmail = Console.ReadLine();

                            using (var cmd = new MySqlCommand("UPDATE employeedetails SET email = @email WHERE empid = @empid", conn))
                            {
                                cmd.Parameters.AddWithValue("@email", newEmail);
                                cmd.Parameters.AddWithValue("@empid", updateEmpId);

                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                    Console.WriteLine($"{rowsAffected} record(s) updated successfully.");
                                else
                                    Console.WriteLine("No employee found with that Employee ID.");
                            }
                            break;

                        case "3":
                            Console.WriteLine("\n--- All Employee Details ---");
                            using (var selectCmd = new MySqlCommand("SELECT * FROM employeedetails", conn))
                            using (var reader = selectCmd.ExecuteReader())
                            {
                                if (!reader.HasRows)
                                {
                                    Console.WriteLine("No records found in the table.");
                                }
                                else
                                {
                                    while (reader.Read())
                                    {
                                        Console.WriteLine($"ID: {reader["empid"]} | Name: {reader["name"]} | Email: {reader["email"]} | Phone: {reader["phone"]}");
                                    }
                                }
                            }
                            break;

                        case "4":
                            Console.Write("\nEnter Employee ID to search: ");
                            int searchEmpId = Convert.ToInt32(Console.ReadLine());

                            

                            using (var searchCmd = new MySqlCommand("SELECT * FROM employeedetails WHERE empid = @empid", conn))
                            {
                                searchCmd.Parameters.AddWithValue("@empid", searchEmpId);
                                int count = Convert.ToInt32(searchCmd.ExecuteScalar());
                                if (count == 0)
                                {
                                    Console.WriteLine("No employee found with that Employee ID.");
                                    break;
                                }
                                using (var reader = searchCmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        Console.WriteLine("\n--- Employee Found ---");
                                        Console.WriteLine($"ID:    {reader["empid"]}");
                                        Console.WriteLine($"Name:  {reader["name"]}");
                                        Console.WriteLine($"Email: {reader["email"]}");
                                        Console.WriteLine($"Phone: {reader["phone"]}");
                                    }
                                    else
                                    {
                                        Console.WriteLine("No employee found with that Employee ID.");
                                    }
                                }
                            }
                            break;

                        case "5":
                            Console.Write("\nEnter Employee ID to delete: ");
                            int deleteEmpId = Convert.ToInt32(Console.ReadLine());

                            using (var deleteCmd = new MySqlCommand("DELETE FROM employeedetails WHERE empid = @empid", conn))
                            {
                                deleteCmd.Parameters.AddWithValue("@empid", deleteEmpId);
                                int rowsAffected = deleteCmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                    Console.WriteLine($"{rowsAffected} record(s) deleted successfully.");
                                else
                                    Console.WriteLine("No employee found with that Employee ID.");
                            }
                            break;

                        case "6":
                            Console.WriteLine("Name Starting With Vowels..");
                            var qur = "SELECT * FROM employeedetails WHERE name LIKE 'A%' OR name LIKE 'E%'  OR name LIKE 'I%'  OR name LIKE 'O%' OR name LIKE 'U%';";
                            using (var cmd = new MySqlCommand(qur, conn))
                            {
                                using (var reader = cmd.ExecuteReader())
                                {
                                    if (!reader.HasRows)
                                    {
                                        Console.WriteLine("No records found in the table.");
                                    }
                                    else
                                    {
                                        while (reader.Read())
                                        {
                                            Console.WriteLine($"ID: {reader["empid"]} | Name: {reader["name"]} | Email: {reader["email"]} | Phone: {reader["phone"]}");
                                        }
                                    }
                                }
                            }
                            break;


                        case "7":
                            exit = true;
                            Console.WriteLine("Exiting program. Goodbye!");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 7.");
                            break;
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
