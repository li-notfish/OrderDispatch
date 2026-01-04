using Microsoft.EntityFrameworkCore;
using OrderDispatch.WebApi.Models;

namespace OrderDispatch.WebApi.Datebase
{
    public class DispatchContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public DbSet<Rider> Riders { get; set; }

        public DbSet<Business> Businesses { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DispatchContext(DbContextOptions<DispatchContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Rider>().ToTable("Rider");
            modelBuilder.Entity<Business>().ToTable("Business");
            modelBuilder.Entity<OrderItem>().ToTable("OrderItem");
        }
    }
}
