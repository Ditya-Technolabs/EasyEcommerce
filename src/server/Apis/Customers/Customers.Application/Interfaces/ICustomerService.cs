using System;
using System.Collections.Generic;
using Customers.Domain.Models;

namespace Customers.Application.Interfaces
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAll();

        Customer Get(Guid id);

        bool Save(Customer customer);

        bool Update(Customer customer);

        bool Delete(Guid id);
    }
}