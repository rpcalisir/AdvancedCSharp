using DependencyInversionLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionLibrary.Concrete
{
    public class VehicleManager
    {
        private readonly IVehicle _vehicle;
        public VehicleManager(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }
        public void FireVehicle()
        {
            _vehicle.Fire();
        }
        public void MoveVehicle()
        {
            _vehicle.Move();
        }
    }
}
