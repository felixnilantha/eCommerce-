using eCommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eCommerce.DAL.Data;

namespace eCommerce.DAL.Repositories
{
    public class CustomerRepository : RepositoryBase<Customer>
    {
        public CustomerRepository(DataContext context) : base(context)
        {
            if (context == null)
                throw new ArgumentNullException();
        }
    }
}
