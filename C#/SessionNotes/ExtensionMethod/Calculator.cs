using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    sealed class Calculator
    { public int Add(int a, int b)
        {
            return a + b;
        }

        public int Divide(int a, int b)
        {
            Console.WriteLine("Divide() in Calculator class executed!");
            return a / b;
        }
    }
}
