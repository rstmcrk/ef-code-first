﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEfCodeFirst1.Entities
{
    public class Customer
    {
        public Customer()
        {
            Orders = new List<Order>();
        }
        public string CustomerID { get; set; }
        public string ContactName { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public List<Order> Orders { get; set; }
    }
}
