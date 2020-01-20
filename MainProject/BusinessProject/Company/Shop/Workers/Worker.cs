using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Shop.Workers
{
    public class Worker
    {
        public string FirstName { get; set; }
     
        public string LastName { get; set; }

        public string EmployeePosition { get; set; }

        public decimal Salary { get; set; }

        public Worker(string firstName, string lastName, string employeePosition, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            EmployeePosition = employeePosition;
            Salary = salary;
        }

        public override string ToString()
        {
            return "Name: " + this.FirstName + " " + this.LastName + "; Position: " + this.EmployeePosition + "; Salary " + this.Salary;
        }
    }
}
