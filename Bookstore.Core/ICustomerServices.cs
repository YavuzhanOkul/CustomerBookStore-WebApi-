using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.Core
{
    public interface ICustomerServices
    {
        List<Customer> GetCustomers();
        Customer GetCustomer(string id);
        Customer AddCustomer(Customer customer);

        void DeleteCustomer(string id);

        Customer UpdateCustomer(Customer customer);

    }
}



