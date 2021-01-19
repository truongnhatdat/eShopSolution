using eShopSolution.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.EF
{
    public class EShopDbContext : DbContext
    {
        public EShopDbContext( DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<ProductTransaction> ProductTransactions { get; set; }
        public DbSet<CatogriesTransacsion> CatogriesTransacsions { get; set; }
        public DbSet<Promotios> Promotios { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<AppConfig> AppConfigs { get; set; }
    }
}
