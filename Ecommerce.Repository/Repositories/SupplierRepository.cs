using Ecommerce.EF;
using Ecommerce.EF.Model;
using Ecommerce.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Repository.Repositories
{
    public class SupplierRepository : Repository<Suppliers>, ISupplierRepository
    {
        public SupplierRepository(northwindContext context) : base(context)
        {
        }
    }
}
