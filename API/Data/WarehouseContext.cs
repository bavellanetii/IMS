using System.Reflection;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class WarehouseContext : DbContext   
    {
        public WarehouseContext(DbContextOptions<WarehouseContext> options) : base(options)
        {
        }

    
        public DbSet<Product> Products { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<LotNumber> LotNumbers { get; set; }
        public DbSet<Packaging> Packaging { get; set; }
        public DbSet<Status> Statuses { get; set; }
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}