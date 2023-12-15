using InventoryTracker.Models.DomainComponents;
using InventoryTracker.Models.DomainPeripherals;
using Microsoft.EntityFrameworkCore;

namespace InventoryTracker.Data
{
    public class InventoryDbContext : DbContext
    {
        public InventoryDbContext(DbContextOptions options) : base(options)
        {
        }

        // DbSets для роботи з усіма товарами
        public DbSet<Case> Cases { get; set; }
        public DbSet<Drive> Drives { get; set; }
        public DbSet<GraphicsCard> GraphicsCards { get; set; }
        public DbSet<Motherboard> Motherboards { get; set; }
        public DbSet<PowerSupply> PowerSupplies { get; set; }
        public DbSet<Processor> Processors { get; set; }
        public DbSet<RAM> RAMs { get; set; }


        public DbSet<Keyboard> Keyboards { get; set; }
        public DbSet<Mouse> Mice { get; set; }
        public DbSet<Mousepad> Mousepads { get; set; }
    }
}
