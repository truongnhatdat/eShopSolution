using eShopSolution.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configuaration
{
    public class CategoryTransactionConfiguration : IEntityTypeConfiguration<CatogriesTransacsion>
    {
        public void Configure(EntityTypeBuilder<CatogriesTransacsion> builder)
        {
            builder.ToTable("CategoryTransactions");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();


            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);

            builder.Property(x => x.SeoAlias).IsRequired().HasMaxLength(200);

            builder.Property(x => x.SeoDescription).HasMaxLength(500);

            builder.Property(x => x.SeoTitle).HasMaxLength(200);

            builder.Property(x => x.LanguageId).IsUnicode(false).IsRequired().HasMaxLength(5);

            builder.HasOne(x => x.Language).WithMany(x => x.CatogriesTransacsions).HasForeignKey(x => x.LanguageId);

            builder.HasOne(x => x.Category).WithMany(x => x.CatogriesTransacsions).HasForeignKey(x => x.CategoryId);
        }
    }
}
