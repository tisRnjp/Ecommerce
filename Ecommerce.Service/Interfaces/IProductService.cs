using Ecommerce.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Ecommerce.Service.Interfaces
{
    public interface IProductService
    {
        Products Get(int id);
        IEnumerable<Products> GetAll();
        IEnumerable<Products> Find(Expression<Func<Products, bool>> predicate);
        void Add(Products entity);
        void Remove(Products entity);
    }
}
