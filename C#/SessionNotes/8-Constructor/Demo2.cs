using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Constructor
{
    internal class Demo2
    {
        class Employee
        {
            // instance member
            public readonly int Id;
            public readonly string Name;

            //type member for all class
            static private int count;

            //type constr to intalise typr member
            static Employee()
            {
                Employee.count = 0;
            }

            //instance constr to inatalise instance member
            public Employee(string Name)
            {
                this.Id = ++Employee.count;
                this.Name = Name;
            }
        }
    }
}
