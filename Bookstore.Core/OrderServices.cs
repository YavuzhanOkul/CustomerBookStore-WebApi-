using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Net;

namespace Bookstore.Core
{
    public class OrderServices : IOrderServices
    {
        private readonly IMongoCollection<Order> _orders;
        private readonly IMongoCollection<Book> _books;
        public OrderServices(IDbOrder IDbOrderr, IDbClient IDbBookss)
        {
            _books = IDbBookss.GetBooksCollection();
            _orders = IDbOrderr.GetOrdersCollection();
        }

        public Order AddOrder(Order order)
        {
            var book = _books.Find(x => x.BookId == order.BookId).FirstOrDefault();
            if (book != null) {
                _orders.InsertOne(order);
                book.Stock--;
               _books.ReplaceOne(o => o.BookId == order.BookId, book);
                return order;
            }
            else
            {
                return null;
            }
           
        }

        public void DeleteOrder(string id)
        {
            _orders.DeleteOne(order => order.OrderId == id);
        }

        public Order GetOrder(string id)
        {
            return _orders.Find(customer => customer.OrderId == id).FirstOrDefault();
        }
        public List<Order> GetCustomerOrder(string customerId )
        {
            return _orders.Find(x => x.CustomerId == customerId).ToList();
        }

        public List<Order> GetOrders()
        {
            return _orders.Find(order => true).ToList();
        }

        public Order UpdateOrder(Order order)
        {
            GetOrder(order.OrderId);
            _orders.ReplaceOne(o => o.OrderId == order.OrderId, order);
            return order;
        }
    }
}
