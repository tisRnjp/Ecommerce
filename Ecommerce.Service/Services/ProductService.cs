using Ecommerce.EF.Model;
using Ecommerce.Repository.UnitOfWork;
using Ecommerce.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Ecommerce.Service.Services
{
    public class ProductService : IProductService
    {
        private IUnitOfWork _unitOfWork;
        public ProductService()
        {
            _unitOfWork = new UnitOfWork();
        }

        public void Add(Products entity)
        {
            _unitOfWork.Products.Add(entity);
        }

        public IEnumerable<Products> Find(Expression<Func<Products, bool>> predicate)
        {
            return _unitOfWork.Products.Find(predicate);
        }

        public Products Get(int id)
        {
            return _unitOfWork.Products.SingleOrDefault(p => p.ProductId == id);
        }

        public IEnumerable<Products> GetAll()
        {
            return _unitOfWork.Products.GetAll();
        }

        public void Remove(Products entity)
        {
            _unitOfWork.Products.Remove(entity);
        }
    }
}
