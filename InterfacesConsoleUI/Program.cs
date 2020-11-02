using InterfacesDemoLibrary;
using InterfacesDemoLibrary.Helper;
using InterfacesDemoLibrary.Interface;
using System;
using System.Collections.Generic;

namespace InterfacesConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IProduct> cart = ProductHelper.AddSampleData();
            Customer customer = CustomerHelper.GetCustomer();

            int stockDigital = Stock.GetDigitalStock(cart);
            int stockPhysical = Stock.GetPhysicalStock(cart);

            foreach (var product in cart)
            {
                product.ShipItem(customer);
                //StockDisplayHelper.StockDisplayer(product, stockDigital, stockPhysical);

                if (product is IDigitalProduct digital)
                {
                    stockDigital -= 1;
                    Console.WriteLine($"Stock for the {digital.Title, -10} : {stockDigital, 2}\n");
                    //digital accesses Title because IDigitalProduct implements IProduct
                    //digital accesses TotalDownloadsLeft because IDigitalProduct has that variable
                }
                if (product is IPhysicalProduct physical)
                {
                    stockPhysical -= 1;
                    Console.WriteLine($"Stock for the {physical.Title, -10} : {stockPhysical, 2}\n");
                }
            }
            Console.ReadLine();
        }
    }
}
