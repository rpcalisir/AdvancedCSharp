using InterfaceAndAbstract.Abstract;
using InterfaceAndAbstract.Concrete.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstract.Concrete.Manager
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private readonly ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            //Tight couplingi kaldırmak için instantiate edilecek sınıf constructor'a parametre olarak verilmeli
            //_customerValidation = new CustomerCheckManager();
            _customerCheckService = customerCheckService;
        }
        public override void Save(IEntity entity)
        {
            if (_customerCheckService.IsPersonReal(entity))
            {
                base.Save(entity);
            }
            else
            {
                Console.WriteLine("Person is not valid!");
            }
        }
    }
}
