using System;


namespace Employee
{
    partial class Manager 
    {
        public void show()
        {
            Console.WriteLine("Employee Details: ");
            Console.WriteLine("Name \nDept \n");
        }

        public partial void info()
        {
            Console.WriteLine("\nPartial Method");
        }
    }
}
