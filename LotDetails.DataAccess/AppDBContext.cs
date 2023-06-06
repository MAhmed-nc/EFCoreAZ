using LotDetails.DataAccess.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LotDetails.DataAccess
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public DbSet<LotType> LotTypes { get; set; }
    }
}