using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    delegate void DriveHandler();

    internal class Driver
    { public void DriveVehicle(DriveHandler objD)
        {
            Console.WriteLine("Driver is now driving some vehicle!");
            objD();
        }
    }
}
