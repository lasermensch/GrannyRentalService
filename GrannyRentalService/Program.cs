using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrannyRentalService.Data;
using GrannyRentalService.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace GrannyRentalService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<GrannyRentalContext>();
                    DbInitializer.Initialize(context);
                }
                catch (Exception epicFail)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(epicFail, "And error occurred while seeding the database");
                }
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
