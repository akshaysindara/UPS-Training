using System;
using System.Collections.Generic;
using System.Text;
using Linq.models;  

namespace Linq.datas
{
    public class EmployeeData
    {
        public static List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Id=101,Name="Akshay",Salary=50000,department="IT"},
                new Employee(){Id=102,Name="Ramesh",Salary=60000,department="HR"},
                new Employee(){Id=103,Name="Suresh",Salary=70000,department="IT"},
                new Employee(){Id=104,Name="Mahesh",Salary=80000,department="Finance"},
                new Employee(){Id=105,Name="Rajesh",Salary=90000,department="IT"},
                new Employee(){Id=106,Name="Dinesh",Salary=100000,department="HR"},
                new Employee(){Id=107,Name="Naresh",Salary=110000,department="Finance"},
                new Employee(){Id=108,Name="Ganesh",Salary=120000,department="IT"},
                new Employee(){Id=109,Name="Rakesh",Salary=130000,department="HR"},
                new Employee(){Id=110,Name="Sandeep",Salary=140000,department="Finance"}
            };
            return employees;
        }
         
        public static List<Manager> GetAllManagers()
        {
            List<Manager> managers = new List<Manager>()
            {
                new Manager(){Id=201,Name="Akshay",Salary=50000,department="IT"},
                new Manager(){Id=202,Name="Ramesh",Salary=60000,department="HR"},
                new Manager(){Id=203,Name="Suresh",Salary=70000,department="IT"},
                new Manager(){Id=204,Name="Mahesh",Salary=80000,department="Finance"},
                new Manager(){Id=205,Name="Rajesh",Salary=90000,department="IT"},
                new Manager(){Id=206,Name="Dinesh",Salary=100000,department="HR"},
                new Manager(){Id=207,Name="Naresh",Salary=110000,department="Finance"},
                new Manager(){Id=208,Name="Ganesh",Salary=120000,department="IT"},
                new Manager(){Id=209,Name="Rakesh",Salary=130000,department="HR"},
                new Manager(){Id=210,Name="Sandeep",Salary=140000,department="Finance"}
            };
            return managers;
        }
    }
}
