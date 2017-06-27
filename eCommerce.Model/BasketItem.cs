﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eCommerce.Model
{
    public class BasketItem
    {

        public int BasketItemId { get; set; }
        public int ProductId { get; set; }
        public Guid BasketId { get; set; }

        public int Quantity { get; set; }

        public virtual Product Product { get; set; }
        


    }
}
