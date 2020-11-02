using InterfacesDemoLibrary.Helper;
using InterfacesDemoLibrary.Interface;
using System;

namespace InterfacesDemoLibrary
{
    public class DigitalProduct : IDigitalProduct
    {
        public string Title { get; set; }
        public int TotalDownloadsLeft { get; private set; } = 5;
        public bool HasOrderBeenCompleted { get; private set; }
        public void ShipItem(Customer customer)
        {
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating emailing {Title} to {customer.FirstName} to {customer.EmailAddress}");
                TotalDownloadsLeft -= 1;
                if (TotalDownloadsLeft < 1)
                {
                    HasOrderBeenCompleted = true;
                    Console.WriteLine("Product is out of stock!");
                    TotalDownloadsLeft = 0;
                }
            }
            //if (HasOrderBeenCompleted == false)
            //{
            //    Console.WriteLine($"Simulating emailing {Title} to {customer.FirstName} to {customer.EmailAddress}");
            //    stock -= 1;
            //    Console.WriteLine($"For the {Title} you have {stock} downloads left");
            //    if (stock<1)
            //    {
            //        HasOrderBeenCompleted = true;
            //        Console.WriteLine("Product is out of stock!");
            //        stock = 0;
            //    }
            //}
        }
    }
}
