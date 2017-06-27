using System;
using System.Collections.Generic;
using System.Data.Entity;
using eCommerce.Model;
using System.Linq;
using System.Text;

namespace eCommerce.DAL.Data
{
    public class DataContext: DbContext
    {

        public DataContext() : base("DefaultConnection")
        {
            //Configuration.LazyLoadingEnabled = false;
        }
        
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Basket> Basket { get; set; }
        public DbSet<BasketItem> BasketItem { get; set; }

        public DbSet<TestMig> TestMigs { get; set; }

        




    }
}
