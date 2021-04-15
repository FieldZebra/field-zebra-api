using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Field_Zebra_Api.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Field_Zebra_Api.Api
{
    public class Program
    {
        public static void Main(string[] args)

        {
            var host = CreateHostBuilder(args).Build();
            CreateDbIfNotExists(host);
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        
        private static void CreateDbIfNotExists(IHost host)
        {
            using(var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var logger = services.GetRequiredService<ILogger<Program>>();

                try {
                    var context = services.GetRequiredService<StoreContext>();
                    context.Database.EnsureCreated();
                    Field.Zebra.Data.DbInitializer.Initializer(context, (ILogger)logger);

                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "Error occured creating the database.");
                }
            }
        }
        

        



    }

    internal interface ILoggerProvider<T>
    {
    }
}
