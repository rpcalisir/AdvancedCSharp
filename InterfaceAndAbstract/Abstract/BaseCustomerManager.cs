using InterfaceAndAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstract.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(IEntity entity)
        {
            Console.WriteLine("Saved to db: " + entity.FirstName);
        }
    }
}
