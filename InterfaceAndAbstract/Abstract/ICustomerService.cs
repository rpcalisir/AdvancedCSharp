using InterfaceAndAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstract.Abstract
{
    public interface ICustomerService
    {
        void Save(IEntity entity); 
    }
}
