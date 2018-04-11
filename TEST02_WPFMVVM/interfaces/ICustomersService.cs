﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEST02_WPFMVVM.model;

namespace TEST02_WPFMVVM.interfaces
{
    public interface ICustomersService
    {
        
            void Add(CustomerModel customer);

            void Update(CustomerModel customer, string name);

            void Remove(int id);

            ICollection<CustomerModel> Get();

            CustomerModel Get(int id);

            CustomerModel Get(string name);
        
    }
}
