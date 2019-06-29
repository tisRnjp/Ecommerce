using Ecommerce.EF.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using Ecommerce.EF.Model;

namespace Ecommerce.EF
{
    public partial class northwindContext : DbContext
    {
        public northwindContext()
        {
        }

        public northwindContext(DbContextOptions<northwindContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Shippers> Shippers { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;database=northwind;user=root;password=1MySQLRootPassword.;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ShipperConfiguration());
            modelBuilder.ApplyConfiguration(new SupplierConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());

            //modelBuilder.Entity<Categories>(entity =>
            //{
            //    entity.HasKey(e => e.CategoryId);

            //    entity.ToTable("categories", "northwind");

            //    entity.HasIndex(e => e.CategoryName)
            //        .HasName("CategoryName")
            //        .IsUnique();

            //    entity.Property(e => e.CategoryId)
            //        .HasColumnName("CategoryID")
            //        .HasColumnType("int(11)");

            //    entity.Property(e => e.CategoryName)
            //        .IsRequired()
            //        .HasMaxLength(15)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Description).HasColumnType("longtext");

            //    entity.Property(e => e.Picture).HasColumnType("longblob");
            //});

            //modelBuilder.Entity<Customers>(entity =>
            //{
            //    entity.HasKey(e => e.CustomerId);

            //    entity.ToTable("customers", "northwind");

            //    entity.HasIndex(e => e.City)
            //        .HasName("City");

            //    entity.HasIndex(e => e.CompanyName)
            //        .HasName("CompanyName");

            //    entity.HasIndex(e => e.PostalCode)
            //        .HasName("PostalCode");

            //    entity.HasIndex(e => e.Region)
            //        .HasName("Region");

            //    entity.Property(e => e.CustomerId)
            //        .HasColumnName("CustomerID")
            //        .HasMaxLength(5)
            //        .IsUnicode(false)
            //        .ValueGeneratedNever();

            //    entity.Property(e => e.Address)
            //        .HasMaxLength(60)
            //        .IsUnicode(false);

            //    entity.Property(e => e.City)
            //        .HasMaxLength(15)
            //        .IsUnicode(false);

            //    entity.Property(e => e.CompanyName)
            //        .IsRequired()
            //        .HasMaxLength(40)
            //        .IsUnicode(false);

            //    entity.Property(e => e.ContactName)
            //        .HasMaxLength(30)
            //        .IsUnicode(false);

            //    entity.Property(e => e.ContactTitle)
            //        .HasMaxLength(30)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Country)
            //        .HasMaxLength(15)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Fax)
            //        .HasMaxLength(24)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Image).HasColumnType("longblob");

            //    entity.Property(e => e.ImageThumbnail).HasColumnType("longblob");

            //    entity.Property(e => e.Phone)
            //        .HasMaxLength(24)
            //        .IsUnicode(false);

            //    entity.Property(e => e.PostalCode)
            //        .HasMaxLength(10)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Region)
            //        .HasMaxLength(15)
            //        .IsUnicode(false);
            //});

            //modelBuilder.Entity<Employees>(entity =>
            //{
            //    entity.HasKey(e => e.EmployeeId);

            //    entity.ToTable("employees", "northwind");

            //    entity.HasIndex(e => e.LastName)
            //        .HasName("LastName");

            //    entity.HasIndex(e => e.PostalCode)
            //        .HasName("PostalCode");

            //    entity.Property(e => e.EmployeeId)
            //        .HasColumnName("EmployeeID")
            //        .HasColumnType("int(11)");

            //    entity.Property(e => e.Address)
            //        .HasMaxLength(60)
            //        .IsUnicode(false);

            //    entity.Property(e => e.City)
            //        .HasMaxLength(15)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Country)
            //        .HasMaxLength(15)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Extension)
            //        .HasMaxLength(4)
            //        .IsUnicode(false);

            //    entity.Property(e => e.FirstName)
            //        .IsRequired()
            //        .HasMaxLength(10)
            //        .IsUnicode(false);

            //    entity.Property(e => e.HomePhone)
            //        .HasMaxLength(24)
            //        .IsUnicode(false);

            //    entity.Property(e => e.LastName)
            //        .IsRequired()
            //        .HasMaxLength(20)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Notes).HasColumnType("longtext");

            //    entity.Property(e => e.Photo).HasColumnType("longblob");

            //    entity.Property(e => e.PostalCode)
            //        .HasMaxLength(10)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Region)
            //        .HasMaxLength(15)
            //        .IsUnicode(false);

            //    entity.Property(e => e.ReportsTo).HasColumnType("int(11)");

            //    entity.Property(e => e.Title)
            //        .HasMaxLength(30)
            //        .IsUnicode(false);

            //    entity.Property(e => e.TitleOfCourtesy)
            //        .HasMaxLength(25)
            //        .IsUnicode(false);
            //});

            //modelBuilder.Entity<OrderDetails>(entity =>
            //{
            //    entity.HasKey(e => new { e.OrderId, e.ProductId });

            //    entity.ToTable("order details", "northwind");

            //    entity.HasIndex(e => e.OrderId)
            //        .HasName("OrderID");

            //    entity.HasIndex(e => e.ProductId)
            //        .HasName("ProductID");

            //    entity.Property(e => e.OrderId)
            //        .HasColumnName("OrderID")
            //        .HasColumnType("int(11)");

            //    entity.Property(e => e.ProductId)
            //        .HasColumnName("ProductID")
            //        .HasColumnType("int(11)");

            //    entity.Property(e => e.Discount).HasDefaultValueSql("0");

            //    entity.Property(e => e.Quantity)
            //        .HasColumnType("int(11)")
            //        .HasDefaultValueSql("1");

            //    entity.Property(e => e.UnitPrice)
            //        .HasColumnType("decimal(19,4)")
            //        .HasDefaultValueSql("0.0000");
            //});

            //modelBuilder.Entity<Orders>(entity =>
            //{
            //    entity.HasKey(e => e.OrderId);

            //    entity.ToTable("orders", "northwind");

            //    entity.HasIndex(e => e.CustomerId)
            //        .HasName("CustomerID");

            //    entity.HasIndex(e => e.EmployeeId)
            //        .HasName("EmployeeID");

            //    entity.HasIndex(e => e.OrderDate)
            //        .HasName("OrderDate");

            //    entity.HasIndex(e => e.ShipPostalCode)
            //        .HasName("ShipPostalCode");

            //    entity.HasIndex(e => e.ShippedDate)
            //        .HasName("ShippedDate");

            //    entity.Property(e => e.OrderId)
            //        .HasColumnName("OrderID")
            //        .HasColumnType("int(11)");

            //    entity.Property(e => e.CustomerId)
            //        .HasColumnName("CustomerID")
            //        .HasMaxLength(5)
            //        .IsUnicode(false);

            //    entity.Property(e => e.EmployeeId)
            //        .HasColumnName("EmployeeID")
            //        .HasColumnType("int(11)");

            //    entity.Property(e => e.Freight)
            //        .HasColumnType("decimal(19,4)")
            //        .HasDefaultValueSql("0.0000");

            //    entity.Property(e => e.ShipAddress)
            //        .HasMaxLength(60)
            //        .IsUnicode(false);

            //    entity.Property(e => e.ShipCity)
            //        .HasMaxLength(15)
            //        .IsUnicode(false);

            //    entity.Property(e => e.ShipCountry)
            //        .HasMaxLength(15)
            //        .IsUnicode(false);

            //    entity.Property(e => e.ShipName)
            //        .HasMaxLength(40)
            //        .IsUnicode(false);

            //    entity.Property(e => e.ShipPostalCode)
            //        .HasMaxLength(10)
            //        .IsUnicode(false);

            //    entity.Property(e => e.ShipRegion)
            //        .HasMaxLength(15)
            //        .IsUnicode(false);

            //    entity.Property(e => e.ShipVia).HasColumnType("int(11)");
            //});

            //modelBuilder.Entity<Products>(entity =>
            //{
            //    entity.HasKey(e => e.ProductId);

            //    entity.ToTable("products", "northwind");

            //    entity.HasIndex(e => e.CategoryId)
            //        .HasName("CategoryID");

            //    entity.HasIndex(e => e.ProductName)
            //        .HasName("ProductName");

            //    entity.HasIndex(e => e.SupplierId)
            //        .HasName("SupplierID");

            //    entity.Property(e => e.ProductId)
            //        .HasColumnName("ProductID")
            //        .HasColumnType("int(11)");

            //    entity.Property(e => e.CategoryId)
            //        .HasColumnName("CategoryID")
            //        .HasColumnType("int(11)");

            //    entity.Property(e => e.Discontinued)
            //        .HasColumnType("tinyint(1)")
            //        .HasDefaultValueSql("0");

            //    entity.Property(e => e.ProductName)
            //        .IsRequired()
            //        .HasMaxLength(40)
            //        .IsUnicode(false);

            //    entity.Property(e => e.QuantityPerUnit)
            //        .HasMaxLength(20)
            //        .IsUnicode(false);

            //    entity.Property(e => e.ReorderLevel)
            //        .HasColumnType("int(11)")
            //        .HasDefaultValueSql("0");

            //    entity.Property(e => e.SupplierId)
            //        .HasColumnName("SupplierID")
            //        .HasColumnType("int(11)");

            //    entity.Property(e => e.UnitPrice)
            //        .HasColumnType("decimal(19,4)")
            //        .HasDefaultValueSql("0.0000");

            //    entity.Property(e => e.UnitsInStock)
            //        .HasColumnType("int(11)")
            //        .HasDefaultValueSql("0");

            //    entity.Property(e => e.UnitsOnOrder)
            //        .HasColumnType("int(11)")
            //        .HasDefaultValueSql("0");
            //});

            //modelBuilder.Entity<Shippers>(entity =>
            //{
            //    entity.HasKey(e => e.ShipperId);

            //    entity.ToTable("shippers", "northwind");

            //    entity.Property(e => e.ShipperId)
            //        .HasColumnName("ShipperID")
            //        .HasColumnType("int(11)");

            //    entity.Property(e => e.CompanyName)
            //        .IsRequired()
            //        .HasMaxLength(40)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Phone)
            //        .HasMaxLength(24)
            //        .IsUnicode(false);
            //});

            //modelBuilder.Entity<Suppliers>(entity =>
            //{
            //    entity.HasKey(e => e.SupplierId);

            //    entity.ToTable("suppliers", "northwind");

            //    entity.HasIndex(e => e.CompanyName)
            //        .HasName("CompanyName");

            //    entity.HasIndex(e => e.PostalCode)
            //        .HasName("PostalCode");

            //    entity.Property(e => e.SupplierId)
            //        .HasColumnName("SupplierID")
            //        .HasColumnType("int(11)");

            //    entity.Property(e => e.Address)
            //        .HasMaxLength(60)
            //        .IsUnicode(false);

            //    entity.Property(e => e.City)
            //        .HasMaxLength(15)
            //        .IsUnicode(false);

            //    entity.Property(e => e.CompanyName)
            //        .IsRequired()
            //        .HasMaxLength(40)
            //        .IsUnicode(false);

            //    entity.Property(e => e.ContactName)
            //        .HasMaxLength(30)
            //        .IsUnicode(false);

            //    entity.Property(e => e.ContactTitle)
            //        .HasMaxLength(30)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Country)
            //        .HasMaxLength(15)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Fax)
            //        .HasMaxLength(24)
            //        .IsUnicode(false);

            //    entity.Property(e => e.HomePage).HasColumnType("longtext");

            //    entity.Property(e => e.Phone)
            //        .HasMaxLength(24)
            //        .IsUnicode(false);

            //    entity.Property(e => e.PostalCode)
            //        .HasMaxLength(10)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Region)
            //        .HasMaxLength(15)
            //        .IsUnicode(false);
            //});
        }
    }
}
