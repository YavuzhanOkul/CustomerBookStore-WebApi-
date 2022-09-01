using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace Bookstore.Core
{
    public class CustomerServices : ICustomerServices
    {
        private readonly IMongoCollection<Customer> _customers;
        public CustomerServices(IDbCustomer IDbCustomerr) //
        {
            _customers = IDbCustomerr.GetCustomersCollection();
        }

        public Customer AddCustomer(Customer customer)
        {
            _customers.InsertOne(customer);
            return customer;
        }

        public void DeleteCustomer(string id)
        {
            _customers.DeleteOne(customer => customer.CustomerId == id);
        }

        public Customer GetCustomer(string id)
        {
            return _customers.Find(customer => customer.CustomerId == id).FirstOrDefault();
        }

        public List<Customer> GetCustomers()
        {
            return _customers.Find(customer => true).ToList();
        }

        public Customer UpdateCustomer(Customer customer)
        {
            GetCustomer(customer.CustomerId);
            _customers.ReplaceOne(c => c.CustomerId == customer.CustomerId, customer);
            return customer;
        }
    }
}
