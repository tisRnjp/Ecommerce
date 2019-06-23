using Ecommerce.EF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.EF.EntityConfigurations
{
    class ShipperConfiguration : IEntityTypeConfiguration<Shippers>
    {
        public void Configure(EntityTypeBuilder<Shippers> builder)
        {
                builder.HasKey(e => e.ShipperId);

                builder.ToTable("shippers", "northwind");

                builder.Property(e => e.ShipperId)
                    .HasColumnName("ShipperID")
                    .HasColumnType("int(11)");

                builder.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                builder.Property(e => e.Phone)
                    .HasMaxLength(24)
                    .IsUnicode(false);
        }
    }
}
