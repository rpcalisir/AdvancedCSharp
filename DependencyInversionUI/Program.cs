using DependencyInversionLibrary.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionUI
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleManager vehicleManager = new VehicleManager(new Tank());
            vehicleManager.FireVehicle();
            vehicleManager.MoveVehicle();

            Console.ReadLine();
        }
    }
}
