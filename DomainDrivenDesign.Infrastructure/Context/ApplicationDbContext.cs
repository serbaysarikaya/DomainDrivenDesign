using DomainDrivenDesign.Domain.Abstractions;
using DomainDrivenDesign.Domain.Categories;
using DomainDrivenDesign.Domain.Orders;
using DomainDrivenDesign.Domain.Products;
using DomainDrivenDesign.Domain.Shared;
using DomainDrivenDesign.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace DomainDrivenDesign.Infrastructure.Context;

internal sealed class ApplicationDbContext : DbContext,IUnitOfWork
{
    override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DomainDrivenDesignDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .Property(u => u.Name).HasConversion(name => name.Value, value => new(value));

        modelBuilder.Entity<User>()
            .Property(u => u.Email).HasConversion(email => email.Value, value => new(value));

        modelBuilder.Entity<User>()
            .Property(u => u.Password).HasConversion(password => password.Value, value => new(value));

        modelBuilder.Entity<User>()
            .OwnsOne(p => p.Address);

        modelBuilder.Entity<Category>()
            .Property(u => u.Name).HasConversion(name => name.Value, value => new(value));

        modelBuilder.Entity<Product>()
           .Property(u => u.Name).HasConversion(name => name.Value, value => new(value));

        modelBuilder.Entity<Product>()
          .OwnsOne(u => u.Price, priceBuilder =>
          {
              priceBuilder.Property(p => p.Currency).HasConversion(currency => currency.Code, code => Currency.FromCode(code));

              priceBuilder.Property(p => p.Amount).HasColumnType("money");

          });

        modelBuilder.Entity<OrderLine>()
       .OwnsOne(u => u.Price, priceBuilder =>
       {
           priceBuilder.Property(p => p.Currency).HasConversion(currency => currency.Code, code => Currency.FromCode(code));

           priceBuilder.Property(p => p.Amount).HasColumnType("money");

       });
        base.OnModelCreating(modelBuilder);
    }

}
