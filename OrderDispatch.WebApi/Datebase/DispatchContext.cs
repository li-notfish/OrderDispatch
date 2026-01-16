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
            modelBuilder.Entity<Order>(order =>
            {
                order.ToTable("Orders");
                order.HasKey(o => o.Id);

                order.HasMany(o => o.Items)
                .WithOne(oi => oi.Order)
                .HasForeignKey(oi => oi.OrderId);

                order.HasOne(o => o.Business)
                .WithMany(b => b.BusOrders)
                .HasForeignKey(o => o.BusinessId);

                order.HasOne(o => o.Rider)
                .WithMany(r => r.RiderOrders)
                .HasForeignKey(o => o.RiderId);
            });

            modelBuilder.Entity<Rider>()
                .ToTable("Riders")
                .HasKey(r => r.Id);

            modelBuilder.Entity<Business>()
                .ToTable("Businesses")
                .HasKey(b => b.Id);

            modelBuilder.Entity<OrderItem>()
                .ToTable("OrderItems")
                .HasKey(oi => new { oi.Id,oi.OrderId });
        }
    }
}
