using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eCommerce.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public int OrderItemId { get; set; }
    }
}
