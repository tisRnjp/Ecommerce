using Ecommerce.EF;
using Ecommerce.EF.Model;
using Ecommerce.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Repository.Repositories
{
    public class EmployeeRepository : Repository<Employees>, IEmployeeRepository
    {
        public EmployeeRepository(northwindContext context) : base(context)
        {
        }
    }
}
