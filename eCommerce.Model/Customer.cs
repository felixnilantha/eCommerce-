﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eCommerce.Model
{
    public class Customer
    {
       
        public int CustomerId { get; set; }
        public string CunstomerName { get; set; }
        public string Address1 { get; set; }
        public string Town { get; set; }
        public string PostCode { get; set; }

    }
}