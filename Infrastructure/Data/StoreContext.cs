using Core.Entities;
using Infrastructure.Config;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class StoreContext(DbContextOptions options) : DbContext(options)
{

public DbSet<Product> Products { get; set; }
    /*  public DbSet<ProductBrand> ProductBrands { get; set; }
      public DbSet<ProductType> ProductTypes { get; set; }
      public DbSet<Order> Orders { get; set; }
      public DbSet<OrderItem> OrderItems { get; set; }
      public DbSet<DeliveryMethod> DeliveryMethods { get; set; }*/

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductConfiguration).Assembly);
    }
}
