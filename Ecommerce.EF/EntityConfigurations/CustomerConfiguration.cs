using Ecommerce.EF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.EF.EntityConfigurations
{
    class CustomerConfiguration : IEntityTypeConfiguration<Customers>
    {
        public void Configure(EntityTypeBuilder<Customers> builder)
        {
            builder.HasKey(e => e.CustomerId);

            builder.ToTable("customers", "northwind");

            builder.HasIndex(e => e.City)
                .HasName("City");

            builder.HasIndex(e => e.CompanyName)
                .HasName("CompanyName");

            builder.HasIndex(e => e.PostalCode)
                .HasName("PostalCode");

            builder.HasIndex(e => e.Region)
                .HasName("Region");

            builder.Property(e => e.CustomerId)
                .HasColumnName("CustomerID")
                .HasMaxLength(5)
                .IsUnicode(false)
                .ValueGeneratedNever();

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

            builder.Property(e => e.Image).HasColumnType("longblob");

            builder.Property(e => e.ImageThumbnail).HasColumnType("longblob");

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
