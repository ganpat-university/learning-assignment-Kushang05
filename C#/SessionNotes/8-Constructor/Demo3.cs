using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Constructor
{
    class Demo3
    {

        public static void Run()
        {
            X objX = new Y();

            Y objY = new Y();

            X objZ = new X();

        }
    }



    class X
    {
        public X()
        {
            Console.WriteLine("Instance constructor of A() called");
        }

        static X()
        {
            Console.WriteLine("Type constructor of A() called");
        }
    }


    class Y: X
    {
        public Y()
        {
            Console.WriteLine("Instance constructor of B() called");
        }

        static Y()
        {
            Console.WriteLine("Type constructor of B() called");
        }
    }
}
