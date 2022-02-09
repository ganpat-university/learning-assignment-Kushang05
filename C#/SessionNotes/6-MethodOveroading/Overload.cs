using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_MethodOveroading
{
    internal class Overload
    {
        public void Input(object o)
        {
            if (o is int)
            {
                Console.WriteLine("Recived Integer");
            }
            else if(o is bool){
                Console.WriteLine("Recived Boolen");
            }
        }
    }
}
