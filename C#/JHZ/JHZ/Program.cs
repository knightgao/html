using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JHZ
{
    class Program
    {
        class Employee
        {
            public string FirstName;
            public string LastName;
            public string Salary = "Not enough";
        }
        static void Main()
        {
            Employee employee1 = new Employee();
            Employee employee2;
            employee2 = new Employee();

            employee1.FirstName = "Inigo";
            employee1.LastName = "Montoya";
            employee1.Salary = "Too Little";
            IncreaseSalary(employee1);
            System.Console.WriteLine(
                "{0} {1}: {2}", employee1.FirstName, employee1.LastName, employee1.Salary
            );
        }
        static void IncreaseSalary(Employee employee)
        {
            employee.Salary = "Enough to survive on";
        }
    }
}
