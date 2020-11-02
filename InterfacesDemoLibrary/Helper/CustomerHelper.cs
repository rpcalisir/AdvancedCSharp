using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemoLibrary.Helper
{
    public static class CustomerHelper
    {
        public static Customer GetCustomer()
        {
            return new Customer()
            {
                FirstName = "Recep",
                LastName = "Calisir",
                City = "Edirne",
                EmailAddress = "receco@mail",
                PhoneNumber = "123"
            };
        }
    }
}
