using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Apis.Orders.Db
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Db.Order> Orders { get; set; }
        public DbSet<Db.OrderItem> OrderItems { get; set; }
    }
}
