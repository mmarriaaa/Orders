using Microsoft.EntityFrameworkCore;
using OrdersService.Models;

namespace OrdersService;

public sealed class DatabaseContext : DbContext
{
   
    public DbSet<Order> Orders { get; set; }

    public DatabaseContext(DbContextOptions<DatabaseContext> dbContextOptions) : base(dbContextOptions)
    {
        Database.EnsureCreated();
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>()
            .Property(order => order.Id)
            .ValueGeneratedOnAdd();
    }
}