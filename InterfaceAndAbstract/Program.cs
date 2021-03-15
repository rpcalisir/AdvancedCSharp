using InterfaceAndAbstract.Abstract;
using InterfaceAndAbstract.Adapters;
using InterfaceAndAbstract.Concrete.Manager;
using InterfaceAndAbstract.Concrete.Validation;
using InterfaceAndAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer {FirstName = "Recep", LastName="Çalışır", DateOfBirth= new DateTime(1992,1,18), NationalityId = "38218197380" });

            Console.ReadLine();
        }
    }
}
