using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Constructor
{
    internal class Demo1
    {

    }

    class Base
    {
        public Base()  
        {
            Console.WriteLine("Base Default Constructor");

        }

        public Base(int id)
        {
            Console.WriteLine("Base Parameterized Constructor");
        }
    }


    class Derive:Base
    {


        //public Derive(int id) : base(id); // used for clling base class parameterised const  only
        public Derive(int id)   
        {
            Console.WriteLine("Derive Parameterized Constructor");
        }
    }
}
