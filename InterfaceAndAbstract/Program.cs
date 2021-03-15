using InterfaceAndAbstract.Abstract;
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
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new CustomerCheckManager());
            customerManager.Save(new Customer {FirstName = "Recep", LastName="Çalışır", DateOfBirth= new DateTime(1993,1,17), NationalityId = "38218197330" });

            Console.ReadLine();
        }
    }
}
