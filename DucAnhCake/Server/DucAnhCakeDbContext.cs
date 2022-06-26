using Microsoft.EntityFrameworkCore;
using DucAnhCake.Shared;

namespace DucAnhCake.Server
{
    public class DucAnhCakeDbContext : DbContext
    {
        public DucAnhCakeDbContext(DbContextOptions<DucAnhCakeDbContext> options)
          : base(options) { }

        public DbSet<Cake> Cakes { get; set; } = default!;
        public DbSet<Order> Orders { get; set; } = default!;
        public DbSet<Customer> Customers { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var cakeEntity = modelBuilder.Entity<Cake>();
            cakeEntity.HasKey(cake => cake.Id);
            cakeEntity.Property(cake => cake.Name)
            .HasMaxLength(80);
            cakeEntity.Property(cake => cake.Price)
            .HasColumnType("money");
            cakeEntity.Property(cake => cake.Sugar)
            .HasConversion<string>();

            var ordersEntity = modelBuilder.Entity<Order>();
            ordersEntity.HasKey(order => order.Id);
            ordersEntity.HasOne(order => order.Customer);
            ordersEntity.HasMany(order => order.Cakes)
            .WithMany(cake => cake.Orders);

            var customerEntity = modelBuilder.Entity<Customer>();
            customerEntity.HasKey(customer => customer.Id);
            customerEntity.Property(customer => customer.Name)
            .HasMaxLength(100);
            customerEntity.Property(customer => customer.Street)
            .HasMaxLength(50);
            customerEntity.Property(customer => customer.City)
            .HasMaxLength(50);
        }
    }
}