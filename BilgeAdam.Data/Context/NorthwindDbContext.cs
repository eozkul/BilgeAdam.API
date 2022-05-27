using BilgeAdam.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BilgeAdam.Data.Context
{
    public class NorthwindDbContext : DbContext
    {
        public NorthwindDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}