﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillyGYM.Infrastucture.ViewModel
{
    public class CustomerModel
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }    
        public string Region { get; set; }
        public string PostalIndex { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
    }
}
