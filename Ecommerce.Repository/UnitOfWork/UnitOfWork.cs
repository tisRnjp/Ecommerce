using System;
using System.Collections.Generic;
using System.Text;
using Ecommerce.EF;
using Ecommerce.Repository.Interface;
using Ecommerce.Repository.Repositories;

namespace Ecommerce.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly northwindContext _context;

        public UnitOfWork()
        {
            _context = new northwindContext();

            Categories = new CategoryRepository(_context);
            Customers = new CustomerRepository(_context);
            Employees = new EmployeeRepository(_context);
            OrderDetails = new OrderDetailRepository(_context);
            Orders = new OrderRepository(_context);
            Products = new ProductRepository(_context);
            Shippers = new ShipperRepository(_context);
            Suppliers = new SupplierRepository(_context);
        }

        public ICategoryRepository Categories { get; private set; }
        public ICustomerRepository Customers { get; private set; }

        public IEmployeeRepository Employees { get; private set; }

        public IOrderDetailRepository OrderDetails { get; private set; }

        public IOrderRepository Orders { get; private set; }

        public IProductRepository Products { get; private set; }

        public IShipperRepository Shippers { get; private set; }

        public ISupplierRepository Suppliers { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
