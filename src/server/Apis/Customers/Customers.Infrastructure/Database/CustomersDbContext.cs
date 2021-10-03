using Microsoft.EntityFrameworkCore;
using Customers.Domain.Models;
using Framework.Database;

namespace Customers.Infrastructure.Database
{
    public class CustomersDbContext : AppDbContext
    {
        public CustomersDbContext(DbContextOptions<CustomersDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
