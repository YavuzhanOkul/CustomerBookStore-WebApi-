using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.Core
{
   public interface IDbClient
    {
        IMongoCollection<Book> GetBooksCollection();
      
    }

    public interface IDbCustomer
    {
        IMongoCollection<Customer> GetCustomersCollection();

    }
    public interface IDbOrder
    {
        IMongoCollection<Order> GetOrdersCollection();

    }


}
