using Microsoft.EntityFrameworkCore;

namespace ECommerce.Api.Orders.Db
{
    public class OrdersContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public OrdersContext(DbContextOptions options) : base(options)
        {

        }
    }
}
