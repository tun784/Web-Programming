using BanHoa.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BanHoa.Models
{
    public class FlowerDbContext : DbContext
    {
        public FlowerDbContext(DbContextOptions<FlowerDbContext> options)
        : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
