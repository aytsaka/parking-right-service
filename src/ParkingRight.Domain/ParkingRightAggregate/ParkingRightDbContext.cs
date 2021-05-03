using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ParkingRight.Domain.ParkingRightAggregate
{
    public class ParkingRightDbContext : DbContext
    {
        public virtual DbSet<ParkRight> ParkingRights { get; set; }

        public ParkingRightDbContext(DbContextOptions<ParkingRightDbContext> dbContextOptions)
            : base(dbContextOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }
    }
}
