using DependencyInversionLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionLibrary.Concrete
{
    public class Tank : IVehicle
    {
        public void Fire()
        {
            Console.WriteLine("Tank is firing");
        }

        public void Move()
        {
            Console.WriteLine("Tank is moving");
        }
    }
}
