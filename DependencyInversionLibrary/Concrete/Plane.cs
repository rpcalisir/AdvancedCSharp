using DependencyInversionLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionLibrary.Concrete
{
    public class Plane : IVehicle
    {
        public void Fire()
        {
            Console.WriteLine("Plane is firing");
        }

        public void Move()
        {
            Console.WriteLine("Plane is moving");
        }
    }
}
