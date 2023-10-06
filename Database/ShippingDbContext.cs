using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CargoTrack_Backend.Models;

namespace CargoTrack_Backend.Database
{
    public class ShippingDbContext : DbContext
    {
        public ShippingDbContext(DbContextOptions<ShippingDbContext> options) : base(options)
        {

        }

        public DbSet<Shipping> Shippings { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shipping>().ToTable("Shipping");
            modelBuilder.Entity<Customer>().ToTable("Customer");
        }
    }
}