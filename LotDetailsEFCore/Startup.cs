using LotDetailsEFCore.EntityFramework;
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
            //string sb_connection = Environment.GetEnvironmentVariable("CTGServicebus_Connection");

            //builder.Services.AddDbContextPool<AppDBContext>(
            //          options => options.UseSqlServer(Environment.GetEnvironmentVariable("ConnectionString")));

            string connectionString = Environment.GetEnvironmentVariable("ConnectionString");
            builder.Services.AddDbContext<AppDBContext>(
              options => SqlServerDbContextOptionsExtensions.UseSqlServer(options, connectionString));

            //builder.Services.AddSingleton<ILotTypesRepository, SQLLotTypesRepository>();
        }
    }
}
