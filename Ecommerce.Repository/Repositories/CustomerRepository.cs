using Ecommerce.EF;
using Ecommerce.EF.Model;
using Ecommerce.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Repository.Repositories
{
    public class CustomerRepository : Repository<Customers>, ICustomerRepository
    {
        public CustomerRepository(northwindContext context) : base(context)
        {
        }
    }
}
