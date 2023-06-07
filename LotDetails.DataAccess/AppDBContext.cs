using LotDetails.DataAccess.Configuration;
using LotDetails.DataAccess.Model;
using Microsoft.EntityFrameworkCore;

namespace LotDetails.DataAccess
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public DbSet<LotType> LotTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new LotTypeIndConfiguration().Configure(modelBuilder.Entity<LotType>());
        }
    }
}