using System;
using System.Collections.Generic;
using Customers.Application.Interfaces;
using Customers.Domain.Models;

namespace Customers.Application.Services
{
    public class CustomerService : ICustomerService
    {
        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Save(Customer customer)
        {
            throw new NotImplementedException();
        }

        public bool Update(Customer customer)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}