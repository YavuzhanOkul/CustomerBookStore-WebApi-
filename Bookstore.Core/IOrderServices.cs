using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.Core
{
    public interface IOrderServices
    {
        List<Order> GetOrders();
        Order GetOrder(string id);
        Order AddOrder(Order order);

        void DeleteOrder(string id);

        Order UpdateOrder(Order order);
        List<Order> GetCustomerOrder(string customerId);

    }
}



