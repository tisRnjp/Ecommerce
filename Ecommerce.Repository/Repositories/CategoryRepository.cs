using Ecommerce.EF;
using Ecommerce.EF.Model;
using Ecommerce.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Repository.Repositories
{
    public class CategoryRepository : Repository<Categories>, ICategoryRepository
    {
        public CategoryRepository(northwindContext context) : base(context)
        {

        }
    }
} 