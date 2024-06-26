using LearnEF.Entities;
using Microsoft.EntityFrameworkCore;

namespace LearnEF.Repositories;

public class AppDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Product>  Products { get; set; }
    public DbSet<Purchase> Purchases { get; set; }
    public DbSet<PurchaseDetail> PurchaseDetails { get; set; } 

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433;User=sa;Password=P@ssword123;Database=enigmat_shop;TrustServerCertificate=True");
    }
}