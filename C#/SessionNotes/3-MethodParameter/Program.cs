using System;

namespace _3_MethodParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Pass By Value");
            a = 20;
            Console.WriteLine(a);
            PassByValue(a);
            Console.WriteLine("a={0}", a);



            Console.WriteLine("Pass By Refrence");
            a = 10;
            PassByRefrence(ref a);
            Console.WriteLine("a={0}",a);

            Console.WriteLine("Pass By Out");
            a = 10;
            PassByOut(out a);
            Console.WriteLine("a={0}", a);

        }

        static void PassByValue( int a)
        {
            a = 100;
            Console.WriteLine("after passing a={0]", a);
        }

        static void PassByRefrence(ref int a)
        {
            a = 200;
            Console.WriteLine("after passing a={0]", a);
        }
        static void PassByOut(out int a)
        {
            a = 300;
            Console.WriteLine("after passing a={0]", a);
        }


    }
}
