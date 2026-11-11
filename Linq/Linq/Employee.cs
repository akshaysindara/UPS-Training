using System;
using System.Collections.Generic;
using System.Text;

namespace Linq.models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; } 

        public string department { get; set; }
    }

    public class Manager
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string department { get; set; }
    }
    
}
