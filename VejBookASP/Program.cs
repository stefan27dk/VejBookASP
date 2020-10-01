using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
 // New
using Microsoft.Extensions.DependencyInjection;
using VejBookASP.Database;

namespace VejBookASP
{
    public class Program
    {

        // Main
        public static void Main(string[] args)
        {
            // Hostbuilder Default code
            //CreateHostBuilder(args).Build().Run();




            // Code for Test Data--------:START::--------------------------------------->
            //CreateHostBuilder not  CreateWebHostBuilder // Is outdated

            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<VejBookContext>();
                    DbInitializer.Initialize(context);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while seeding the database.");
                }
            }

            host.Run(); // Run After The Test Data "Initializer"
            // Code for Test Data--------:END::-------------------------------------------<
                                                        

        }


        // Host Builder
        public static IHostBuilder CreateHostBuilder(string[] args) =>
                Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });




    }
}
