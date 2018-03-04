using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;


namespace MySite.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime JoinDate { get; set; }
        public int Age { get; set; }
    }

    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext()
        { }
        public DbSet<Employee> Employees { get; set; }
    }

}
