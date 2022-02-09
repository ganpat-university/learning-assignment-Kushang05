using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Driver2
    {

        public void Drive(object objVehicle)
        {
            Console.WriteLine("--- Driver is now driving a vehicle!");
            if (objVehicle is Car)                                  
            {
                Car car = objVehicle as Car;                        
                car.DriveCar();
            }
            else if (objVehicle is Bike)
            {
                Bike objScooter = objVehicle as Bike;         
                objScooter.Drive();
            }
            Console.WriteLine();
        }
    }
}
