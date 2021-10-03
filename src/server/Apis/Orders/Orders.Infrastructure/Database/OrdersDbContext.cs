using Microsoft.EntityFrameworkCore;
using Orders.Domain.Models;
using Framework.Database;

namespace Orders.Infrastructure.Database
{
    public class OrdersDbContext : AppDbContext
    {
        public OrdersDbContext(DbContextOptions<OrdersDbContext> options) : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
    }
}
