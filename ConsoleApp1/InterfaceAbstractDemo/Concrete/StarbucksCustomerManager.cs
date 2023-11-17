using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarbucksCustomerManager:BaseCustomerManager
    {

        private ICustomerCheckService _customerChackService;

        public StarbucksCustomerManager(ICustomerCheckService customerChackService)
        {
            _customerChackService = customerChackService;
        }

        public override void Save(Customer customer)
        {
            if (_customerChackService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
            
        }

        private void CheckIfRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }

    }
}
