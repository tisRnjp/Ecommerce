using Ecommerce.EF.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.EF.EntityConfigurations
{
    class SupplierConfiguration : IEntityTypeConfiguration<Suppliers>
    {
        public void Configure(EntityTypeBuilder<Suppliers> builder)
        {
                builder.HasKey(e => e.SupplierId);

                builder.ToTable("suppliers", "northwind");

                builder.HasIndex(e => e.CompanyName)
                    .HasName("CompanyName");

                builder.HasIndex(e => e.PostalCode)
                    .HasName("PostalCode");

                builder.Property(e => e.SupplierId)
                    .HasColumnName("SupplierID")
                    .HasColumnType("int(11)");

                builder.Property(e => e.Address)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                builder.Property(e => e.City)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                builder.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                builder.Property(e => e.ContactName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                builder.Property(e => e.ContactTitle)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                builder.Property(e => e.Country)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                builder.Property(e => e.Fax)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                builder.Property(e => e.HomePage).HasColumnType("longtext");

                builder.Property(e => e.Phone)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                builder.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                builder.Property(e => e.Region)
                    .HasMaxLength(15)
                    .IsUnicode(false);
        }
    }
}
