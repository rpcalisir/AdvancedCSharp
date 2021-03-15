using InterfaceAndAbstract.Abstract;
using InterfaceAndAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstract.Concrete.Validation
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool IsPersonReal(IEntity customer)
        {
            return false;
        }
    }
}
