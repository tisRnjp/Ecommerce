using Ecommerce.EF.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.EF.EntityConfigurations
{
    class OrderConfiguration : IEntityTypeConfiguration<Orders>
    {
        public void Configure(EntityTypeBuilder<Orders> builder)
        {
                builder.HasKey(e => e.OrderId);

                builder.ToTable("orders", "northwind");

                builder.HasIndex(e => e.CustomerId)
                    .HasName("CustomerID");

                builder.HasIndex(e => e.EmployeeId)
                    .HasName("EmployeeID");

                builder.HasIndex(e => e.OrderDate)
                    .HasName("OrderDate");

                builder.HasIndex(e => e.ShipPostalCode)
                    .HasName("ShipPostalCode");

                builder.HasIndex(e => e.ShippedDate)
                    .HasName("ShippedDate");

                builder.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasColumnType("int(11)");

                builder.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                builder.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("int(11)");

                builder.Property(e => e.Freight)
                    .HasColumnType("decimal(19,4)")
                    .HasDefaultValueSql("0.0000");

                builder.Property(e => e.ShipAddress)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                builder.Property(e => e.ShipCity)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                builder.Property(e => e.ShipCountry)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                builder.Property(e => e.ShipName)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                builder.Property(e => e.ShipPostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                builder.Property(e => e.ShipRegion)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                builder.Property(e => e.ShipVia).HasColumnType("int(11)");
        }
    }
}
