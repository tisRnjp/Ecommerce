using Ecommerce.EF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.EF.EntityConfigurations
{
    class CategoryConfiguration : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> builder)
        {
            builder.HasKey(e => e.CategoryId);

            builder.ToTable("categories", "northwind");

            builder.HasIndex(e => e.CategoryName)
                    .HasName("CategoryName")
                    .IsUnique();

            builder.Property(e => e.CategoryId)
                    .HasColumnName("CategoryID")
                    .HasColumnType("int(11)");

            builder.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

            builder.Property(e => e.Description).HasColumnType("longtext");

            builder.Property(e => e.Picture).HasColumnType("longblob");
        }
    }
}
