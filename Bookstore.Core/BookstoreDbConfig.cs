using System;
using System.Collections.Generic;
using System.Text;

namespace Bookstore.Core
{
    public class BookstoreDbConfig
    {
        public string Database_Name { get; set; } // UPDATEONE 
        public string Books_Collection_Name { get; set; }
        public string Connection_String { get; set; }
        public string Orders_Collection_Name { get; set; }
        public string Customers_Collection_Name { get; set; }
    }
}
