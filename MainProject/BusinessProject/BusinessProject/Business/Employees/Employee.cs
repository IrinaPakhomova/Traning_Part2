using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessProject.Business.Employees
{
    enum Position
    {
      loader,
      purchaser,
      seller,
      accountant
    }
    class Employee
    {
        //private static int totalEmployees = 0;
        public string FirstName { get;private set; }
        public string LastName { get; private set; }
        public string EmployeePosition { get; private set;} 
        public decimal Salary { get; set; }

        public Employee(string firstName, string lastName, string employeePosition, int salary)
        {
            FirstName = firstName;
            LastName = lastName;
            EmployeePosition = employeePosition;
            Salary = salary;
        }

        public override string ToString()
        {
            return "Name: " + this.FirstName + " " + this.LastName + "; Position: " + this.EmployeePosition +"; Salary " + this.Salary;
        }

        public decimal getSalary(Employee employee)
        {
            return employee.Salary;
        }

        public string getPosition(Employee employee)
        {
            return employee.EmployeePosition;
        }

    }
}
