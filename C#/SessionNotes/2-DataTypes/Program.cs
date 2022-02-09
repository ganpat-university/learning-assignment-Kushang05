using System;

namespace _2_DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            bool b = true;
            string s = "hello world";
            char c = 'A';

            int k = int.MaxValue;
            a = k + 1;

            long p= k;                 // implicit type-casting int value to long.

            p = long.MaxValue;
            
            k = (int)p;                 // explicit type-casting long value to int

            Console.WriteLine("l (long) = {0}, j (int) = {1}", p, k);


        }
    }
    }
}
