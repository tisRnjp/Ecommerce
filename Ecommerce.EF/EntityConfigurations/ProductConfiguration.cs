using Ecommerce.EF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.EF.EntityConfigurations
{
    class ProductConfiguration : IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
                builder.HasKey(e => e.ProductId);

                builder.ToTable("products", "northwind");

                builder.HasIndex(e => e.CategoryId)
                    .HasName("CategoryID");

                builder.HasIndex(e => e.ProductName)
                    .HasName("ProductName");

                builder.HasIndex(e => e.SupplierId)
                    .HasName("SupplierID");

                builder.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasColumnType("int(11)");

                builder.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .HasColumnType("int(11)");

                builder.Property(e => e.Discontinued)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                builder.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                builder.Property(e => e.QuantityPerUnit)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                builder.Property(e => e.ReorderLevel)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                builder.Property(e => e.SupplierId)
                    .HasColumnName("SupplierID")
                    .HasColumnType("int(11)");

                builder.Property(e => e.UnitPrice)
                    .HasColumnType("decimal(19,4)")
                    .HasDefaultValueSql("0.0000");

                builder.Property(e => e.UnitsInStock)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                builder.Property(e => e.UnitsOnOrder)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
        }
    }
}
