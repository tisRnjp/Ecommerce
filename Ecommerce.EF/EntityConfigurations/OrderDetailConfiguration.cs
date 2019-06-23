using Ecommerce.EF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.EF.EntityConfigurations
{
    class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetails>
    {
        public void Configure(EntityTypeBuilder<OrderDetails> builder)
        {
                builder.HasKey(e => new { e.OrderId, e.ProductId });

                builder.ToTable("order details", "northwind");

                builder.HasIndex(e => e.OrderId)
                    .HasName("OrderID");

                builder.HasIndex(e => e.ProductId)
                    .HasName("ProductID");

                builder.Property(e => e.OrderId)
                    .HasColumnName("OrderID")
                    .HasColumnType("int(11)");

                builder.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasColumnType("int(11)");

                builder.Property(e => e.Discount).HasDefaultValueSql("0");

                builder.Property(e => e.Quantity)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                builder.Property(e => e.UnitPrice)
                    .HasColumnType("decimal(19,4)")
                    .HasDefaultValueSql("0.0000");
        }
    }
}
