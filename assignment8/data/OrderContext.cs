using Microsoft.EntityFrameworkCore;
using webAPI.Models;

namespace webAPI.data
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
    }
}


