using InterfacesDemoLibrary.Interface;
using System;
using System.Collections.Generic;

namespace InterfacesDemoLibrary
{
    public class PhysicalProduct : IPhysicalProduct
    {
        public string Title { get; set; }
        public bool HasOrderBeenCompleted { get; private set; }

        public void ShipItem(Customer customer)
        {
            if (HasOrderBeenCompleted==false)
            {
                Console.WriteLine($"Simulating shipping {Title} to {customer.FirstName} in {customer.City}");
                HasOrderBeenCompleted = true;
            }
        }
    }
}
