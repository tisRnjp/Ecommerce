using Ecommerce.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Repository.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Categories { get; }
        ICustomerRepository Customers { get; }
        IEmployeeRepository Employees { get; }
        IOrderDetailRepository OrderDetails { get; }
        IOrderRepository Orders { get; }
        IProductRepository Products { get; }
        IShipperRepository Shippers { get; }
        ISupplierRepository Suppliers { get; }

        int Complete();
    }
}
