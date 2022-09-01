using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.Core
{
    public class DbClient : IDbClient
    {
        private readonly IMongoCollection<Book> _books;
        public DbClient(IOptions<BookstoreDbConfig> bookstoreDbConfig)
        {
            var client = new MongoClient(bookstoreDbConfig.Value.Connection_String);
            var database = client.GetDatabase(bookstoreDbConfig.Value.Database_Name);
            _books = database.GetCollection<Book>(bookstoreDbConfig.Value.Books_Collection_Name);
        }
        public IMongoCollection<Book> GetBooksCollection()
        {
            return _books;
        }

       
    }


    public class DbClientCustomer : IDbCustomer
    {
        private readonly IMongoCollection<Customer> _customers;
        public DbClientCustomer(IOptions<BookstoreDbConfig> bookstoreDbConfig)
        {
            var client = new MongoClient(bookstoreDbConfig.Value.Connection_String);
            var database = client.GetDatabase(bookstoreDbConfig.Value.Database_Name);
            _customers = database.GetCollection<Customer>(bookstoreDbConfig.Value.Customers_Collection_Name);
        }
        public IMongoCollection<Customer> GetCustomersCollection()
        {
            return _customers;
        }


    }
    public class DbClientOrder : IDbOrder
    {
        private readonly IMongoCollection<Order> _orders;
        public DbClientOrder(IOptions<BookstoreDbConfig> bookstoreDbConfig)
        {
            var client = new MongoClient(bookstoreDbConfig.Value.Connection_String);
            var database = client.GetDatabase(bookstoreDbConfig.Value.Database_Name);
            _orders = database.GetCollection<Order>(bookstoreDbConfig.Value.Orders_Collection_Name);
        }
        public IMongoCollection<Order> GetOrdersCollection()
        {
            return _orders;
        }


    }
}
