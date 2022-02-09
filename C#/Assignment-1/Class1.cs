using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }


            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name cannot be empty!!!");

                }
                else
                {
                    _name = value;
                }

            }


        }
        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value <= 18 || value >= 65)
                {
                    Console.WriteLine("Invalide Age group !!!");
                }
                else
                {
                    _age = value;
                }
            }
        }
    }
}
