using eShopSolution.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configuaration
{
    public class ProductTransacsionConfiguration : IEntityTypeConfiguration<ProductTransaction>
    {
        public void Configure(EntityTypeBuilder<ProductTransaction> builder)
        {
            builder.ToTable("ProductTransacsion");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);

            builder.Property(x => x.SeoAlias).IsRequired().HasMaxLength(200);

            builder.Property(x => x.Detail).HasMaxLength(500);


            builder.Property(x => x.LanguageId).IsUnicode(false).IsRequired().HasMaxLength(5);

            builder.HasOne(x => x.Language).WithMany(x => x.ProductTransactions).HasForeignKey(x => x.LanguageId);

            builder.HasOne(x => x.Product).WithMany(x => x.ProductTransactions).HasForeignKey(x => x.ProductId);
        }
    }
}
