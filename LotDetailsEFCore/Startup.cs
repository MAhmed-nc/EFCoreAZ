using LotDetails.DataAccess;
using LotDetails.DataAccess.Model;
using LotDetails.DataAccess.Repository;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: FunctionsStartup(typeof(LotDetailsEFCore.Startup))]
namespace LotDetailsEFCore
{
    public class Startup : FunctionsStartup
    {
        private IConfiguration _config;

        public Startup()
        {
            
        }
        public Startup(IConfiguration config)
        {
            _config = config;
        }

        public override void Configure(IFunctionsHostBuilder builder)
        {
            string connectionString = Environment.GetEnvironmentVariable("ConnectionString");

            builder.Services.AddDbContextPool<AppDBContext>(
                      options => options.UseSqlServer(connectionString));

            //builder.Services.AddScoped<IEntityBaseRepository<LotType>, EntityBaseRepository<LotType>>();
            builder.Services.AddScoped(typeof(IEntityBaseRepository<>), typeof(EntityBaseRepository<>));
        }
    }
}
