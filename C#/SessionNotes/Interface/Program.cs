using System;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Demo01()
            {
                Car objCar = new Car();
                Bike objBike = new Bike();
                Driver1 objDriver = new Driver1();

                objDriver.Drive(objCar);
                objDriver.Drive(objBike);
            }

            static void Demo02()
            {
                Car objCar = new Car();
                Bike objBike = new Bike();
                Driver2 objDriver = new Driver2();

                objDriver.Drive(objCar);                
                objDriver.Drive(objBike);
            }

            static void Demo03()
            {
                Car objCar = new Car();
                Bike objBike = new Bike();
                Driver1 objDriver = new Driver1();

                objDriver.Drive(objCar);               
                objDriver.Drive(objBike);
            }
        }
    }
}
