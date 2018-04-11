using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEST02_WPFMVVM.interfaces;
using TEST02_WPFMVVM.model;

namespace TEST02_WPFMVVM.services
{
    public class DbCustomerService : ICustomersService
    {
        public void Add(CustomerModel customer)
        {
            throw new NotImplementedException();
        }

        public ICollection<CustomerModel> Get()
        {
            throw new NotImplementedException();
        }

        public CustomerModel Get(int id)
        {
            throw new NotImplementedException();
        }

        public CustomerModel Get(string name)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(CustomerModel customer, string name)
        {
            throw new NotImplementedException();
        }
    }
}
