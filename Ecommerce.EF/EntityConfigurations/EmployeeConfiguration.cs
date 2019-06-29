using Ecommerce.EF.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.EF.EntityConfigurations
{
    class EmployeeConfiguration : IEntityTypeConfiguration<Employees>
    {
        public void Configure(EntityTypeBuilder<Employees> builder)
        {
                builder.HasKey(e => e.EmployeeId);

                builder.ToTable("employees", "northwind");

                builder.HasIndex(e => e.LastName)
                    .HasName("LastName");

                builder.HasIndex(e => e.PostalCode)
                    .HasName("PostalCode");

                builder.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("int(11)");

                builder.Property(e => e.Address)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                builder.Property(e => e.City)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                builder.Property(e => e.Country)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                builder.Property(e => e.Extension)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                builder.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                builder.Property(e => e.HomePhone)
                    .HasMaxLength(24)
                    .IsUnicode(false);

                builder.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                builder.Property(e => e.Notes).HasColumnType("longtext");

                builder.Property(e => e.Photo).HasColumnType("longblob");

                builder.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                builder.Property(e => e.Region)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                builder.Property(e => e.ReportsTo).HasColumnType("int(11)");

                builder.Property(e => e.Title)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                builder.Property(e => e.TitleOfCourtesy)
                    .HasMaxLength(25)
                    .IsUnicode(false);
        }
    }
}
