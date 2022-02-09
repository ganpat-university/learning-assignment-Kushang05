using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User!");

            MyEnum month = MyEnum.Jan;
            Console.WriteLine(month);

            month = MyEnum.march;

            Console.WriteLine("month {0} , int:{1} ", month, (int)month);


            /*MyStruct objs;
            objs.ID = 5;
            objs.Name = "Kushang";
            Console.WriteLine(" ID: {0} , Name: {1}", objs.ID, objs.Name);
            objs.Monthofyear = MyEnum.march;*/

            Class1 objc;
            objc = new Class1();

            Console.WriteLine("Enter Your Name: ");
            objc.Name = Console.ReadLine();

            Console.WriteLine("Enter Your Age");
            objc.Age = int.Parse(Console.ReadLine());
        }
    }
}
