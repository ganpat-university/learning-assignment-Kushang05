using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Driver1
    {

        public void Drive(Car objCar)
        {
            Console.WriteLine("--- Driver is now driving a Car!");
            objCar.DriveCar();
            Console.WriteLine();
        }

        public void Drive(Bike objBike)
        {
            Console.WriteLine("--- Driver is now driving a Scooter!");
            objBike.Drive();
            Console.WriteLine();
        }
    }
}
