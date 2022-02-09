using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
   

        interface IVehicle
        {
            void Drive();
        }

        class Driver3
        {
            public void Drive(IVehicle objVehicle)
            {
                Console.WriteLine("--- Driver is now driving a vehicle!");
                objVehicle.Drive();
                Console.WriteLine();
            }

        }
   
}
