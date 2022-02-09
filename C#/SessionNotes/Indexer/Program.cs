using System;

namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company objComp= new Company("Apple");

            objComp.AddEmployee("Steve Jobs");
            objComp.AddEmployee("Bill Jobs");


            objComp.Display();
        }
    }
}
