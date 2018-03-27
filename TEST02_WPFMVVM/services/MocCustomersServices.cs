using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEST02_WPFMVVM.interfaces;
using TEST02_WPFMVVM.model;

namespace TEST02_WPFMVVM.services
{
    public class MocCustomersServices : ICustomersService
    {
        private ICollection<CustomerModel> customers;

        public MocCustomersServices()
        {
            customers = new List<CustomerModel>
            {
                new CustomerModel {Id=1, Name = "Name01" },
                new CustomerModel {Id=2, Name = "Name02" },
                new CustomerModel {Id=3, Name = "Name03" },
            };
        }

        public void Add(CustomerModel customer)
        {
            customer.Id = customers.Max(c => c.Id) + 1;
            customers.Add(customer);
        }

        public ICollection<CustomerModel> Get()
        {
            return customers;
        }

        public CustomerModel Get(int id)
        {
            return customers.Single(c => c.Id == id);//wyrażenie Linq
        }

        public CustomerModel Get(string name)
        {
            //jeśli będzie więcej niż 1 to zwróci wyjątek
            return customers.Single(c => c.Name == name);

            //jeśli będzie więcej niż 1 to zwraca pierwszy element
            // return products.First(p => p.Name == name);
        }

        public void Remove(int id)
        {
            var customer = Get(id);
            customers.Remove(customer);
        }

        public void Update(CustomerModel customer)
        {
            throw new NotImplementedException();
        }
    }
}
