using InterfaceAndAbstract.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstract.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool IsPersonReal(IEntity customer)
        {
            bool result;

            try
            {
                using (MernisServiceReference.KPSPublicSoapClient client = new MernisServiceReference.KPSPublicSoapClient())
                {
                    result = client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId), customer.FirstName, customer.LastName, customer.DateOfBirth.Year);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = false;
            }
            return result;
        }
    }
}
