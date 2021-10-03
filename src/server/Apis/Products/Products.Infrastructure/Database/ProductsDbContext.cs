using Microsoft.EntityFrameworkCore;
using Products.Domain.Models;
using Framework.Database;

namespace Products.Infrastructure.Database
{
    public class ProductsDbContext : AppDbContext
    {
        public ProductsDbContext(DbContextOptions<ProductsDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
