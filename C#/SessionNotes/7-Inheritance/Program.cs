using System;

namespace _7_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Base obj=new Base();
            obj.Something();


            Another obj2 = new Another();
            obj2.Something();

            Base obj3=new Another();
            obj3.Something();
        }
    }
}
