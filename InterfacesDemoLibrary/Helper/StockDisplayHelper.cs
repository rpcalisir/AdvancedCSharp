using InterfacesDemoLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemoLibrary.Helper
{
    public static class StockDisplayHelper
    {
        public static void StockDisplayer(IProduct product, int stockDigital, int stockPhysical)
        {
            if (product is IDigitalProduct digital)
            {
                stockDigital -= 1;
                Console.WriteLine($"For the {digital.Title} stock is: {stockDigital}");
                //digital accesses Title because IDigitalProduct implements IProduct
                //digital accesses TotalDownloadsLeft because IDigitalProduct has that variable
            }
            if (product is IPhysicalProduct physical)
            {
                stockPhysical -= 1;
                Console.WriteLine($"For the {physical.Title} stock is: {stockPhysical}");
            }
        }
    }
}
