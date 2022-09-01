using Bookstore.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.WebApii.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookServices _bookServices;


        public BooksController(IBookServices bookServices)
        {
            _bookServices = bookServices;

        }


        [HttpGet]
        public IActionResult GetBooks()
        {
            return Ok(_bookServices.GetBooks());
        }
        [HttpGet("{id}", Name = "GetBook")]
        public IActionResult GetBook(string id)
        {
            return Ok(_bookServices.GetBook(id));
        }

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            _bookServices.AddBook(book);
            return CreatedAtRoute("GetBook", new { id = book.BookId }, book);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(string id)
        {
            _bookServices.DeleteBook(id);
            return NoContent();
        }
        [HttpPut]
        public IActionResult UpdateBook(Book book)
        {
            return Ok(_bookServices.UpdateBook(book));
        }


    }


    
        [ApiController]
        [Route("[controller]")]
        public class CustomersController : ControllerBase
        {
            private readonly ICustomerServices _customerServices;


            public CustomersController(ICustomerServices customerServices)
            {
                _customerServices = customerServices;

            }

            [HttpGet]
            public IActionResult GetCustomers()
            {
                return Ok(_customerServices.GetCustomers());
            }
            [HttpGet("{id}", Name = "GetCustomer")]
            public IActionResult GetCustomer(string id)
            {
                return Ok(_customerServices.GetCustomer(id));
            }

            [HttpPost]
            public IActionResult AddCustomer(Customer customer)
            {
                _customerServices.AddCustomer(customer);
                return CreatedAtRoute("GetCustomer", new { id = customer.CustomerId }, customer);
            }


            [HttpDelete("{id}")]
            public IActionResult DeleteCustomer(string id)
            {
                _customerServices.DeleteCustomer(id);
                return NoContent();
            }
            [HttpPut]
            public IActionResult UpdateCustomer(Customer customer)
            {
                return Ok(_customerServices.UpdateCustomer(customer));
            }

        }


    }

    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderServices _orderServices;


        public OrdersController(IOrderServices orderServices)
        {
            _orderServices = orderServices;

        }

        [HttpGet]
        public IActionResult GetOrders()
        {
            return Ok(_orderServices.GetOrders());
        }
        [HttpGet("{id}", Name = "GetOrder")]
        public IActionResult GetOrder(string id)
        {
            return Ok(_orderServices.GetOrder(id));
        }

       [HttpGet("get/{customerId}", Name = "GetCustomerOrders")]
       public IActionResult GetCustomerOrder(string customerId)
       {
        return Ok(_orderServices.GetCustomerOrder(customerId));
       }

    [HttpPost]
        public IActionResult AddOrder(Order order)
        {
        // order models , içinde ıd olmadan oluşturup name surname 
             _orderServices.AddOrder(order);
            return CreatedAtRoute("GetOrder", new { id = order.OrderId }, order);
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteOrder(string id)
        {
        _orderServices.DeleteOrder(id);
            return NoContent();
        }
        [HttpPut]
        public IActionResult UpdateOrder(Order order)
        {
            return Ok(_orderServices.UpdateOrder(order));
        }

    }


