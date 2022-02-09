using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Bike: IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Bike is being driven");
        }
    }
}
