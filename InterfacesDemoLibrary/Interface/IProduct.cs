
using System.Collections.Generic;

namespace InterfacesDemoLibrary.Interface
{
    public interface IProduct
    {
        string Title { get; set; }
        bool HasOrderBeenCompleted { get; }
        void ShipItem(Customer customer);
    }
}
