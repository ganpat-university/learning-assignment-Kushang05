using System;

namespace IComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[5];

            employees[0] = new Employee();
            employees[0].EmployeeID = 1;
            employees[0].EmployeeName = "First";
            employees[0].Salary = 100000M;

            // Object Initializer
            employees[1] = new Employee()
            {
                EmployeeID = 2,
                EmployeeName = "Second",
                Salary = 20000M
            };

            employees[2] = new Employee()
            {
                EmployeeID = 3,
                EmployeeName = "Third",
                Salary = 450000M
            };

            employees[3] = new Employee()
            {
                EmployeeID = 4,
                EmployeeName = "Fourth ",
                Salary = 500000M
            };

            employees[4] = new Employee()
            {
                EmployeeID = 5,
                EmployeeName = "Fifth ",
                Salary = 270000M
            };

            Console.WriteLine(" List of employees:");
            foreach (Employee e in employees)
            {
                Console.WriteLine("{0} {1,-20} {2,15}", e.EmployeeID, e.EmployeeName, e.Salary);
            }
            Console.WriteLine();

            Array.Sort(employees);

            Console.WriteLine(" List of employees AFTER SORTING:");
            foreach (Employee e in employees)
            {
                Console.WriteLine("{0} {1,-20} {2,15}", e.EmployeeID, e.EmployeeName, e.Salary);
            }
            Console.WriteLine();
        }
    }
}
