using Microsoft.EntityFrameworkCore;
using MyNewMarket.Dal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewMarket.Dal.Context
{
    public class MyNewMarketContext : DbContext
    {
        public MyNewMarketContext(DbContextOptions<MyNewMarketContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductSupplier>().HasKey(
                ps => new
                {
                    ps.ProductId,
                    ps.SupplierId
                }
                );

        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductSupplier> ProductSuppliers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
