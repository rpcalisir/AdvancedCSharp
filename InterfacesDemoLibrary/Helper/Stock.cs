using InterfacesDemoLibrary.Interface;
using System.Collections.Generic;
using System.Linq;

namespace InterfacesDemoLibrary.Helper
{
    public static class Stock
    {
        public static int GetPhysicalStock(List<IProduct> products)
        {
            return products.OfType<PhysicalProduct>().Count();
        }
        public static int GetDigitalStock(List<IProduct> products)
        {
            int result = products.OfType<DigitalProduct>().Count();
            return result;
        }

    }
}
