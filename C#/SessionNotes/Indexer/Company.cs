using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Company
    {
        public string CompanyName { get; private set; }

        private System.Collections.ArrayList theEmployees { get; set; }

        private int counter;


        public Company(string name)
        {
            this.theEmployees = null;
            this.counter = 0;
            CompanyName = name;
        }

        public Employee this[string name]
        {
            get
            {
                Employee empFound = null;

                foreach (Employee emp in theEmployees)
                {
                    if (emp.EmpName == name)
                    {
                        empFound = emp;
                        break;
                    }
                }

                return empFound;
            }
        }

        public Employee this[int id]
        {
            get
            {
                Employee empFound = null;

                foreach (Employee emp in theEmployees)
                {
                    if (emp.EmpId== id)
                    {
                        empFound = emp;
                        break;
                    }
                }

                return empFound;
            }
        }

        public void AddEmployee(string nameOfNewEmployee)
        {
            Employee emp = new Employee();
            emp.EmpId = ++this.counter;
            emp.EmpName = nameOfNewEmployee;

            if (theEmployees == null)
            {
                theEmployees = new System.Collections.ArrayList();
            }

            theEmployees.Add(emp);
        }
        public void Display()
        {
            foreach (Employee emp in theEmployees)
            {
                Console.WriteLine("{0} {1}", emp.EmpId, emp.EmpName);
            }
        }
        }
}

