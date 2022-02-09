using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            GenericType<int> intVariable = new GenericType<int>();
            intVariable.Value = 10;
            intVariable.DisplayInfo();

            GenericType<string> strVariable = new GenericType<string>();
            strVariable.Value = "hello world";
            strVariable.DisplayInfo();

            GenericType<Employee> empVariable = new GenericType<Employee>();
            empVariable.Value = new Employee()
            {
                EmployeeId = 10,
                EmployeeName = "First Employee"
            };
            empVariable.DisplayInfo();
        }
    }
}
