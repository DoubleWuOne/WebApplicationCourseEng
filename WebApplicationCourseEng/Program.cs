using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApplicationCourseEng.Data;

namespace WebApplicationCourseEng
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
           var host = CreateHostBuilder(args).Build();
           using var scope = host.Services.CreateScope();
           var services = scope.ServiceProvider;
           try
           {
               var context = services.GetRequiredService<DataContext>();
               await context.Database.MigrateAsync();
               await Seed.SeedUsers(context);
           }
           catch (Exception e)
           {
               var logger = services.GetRequiredService<ILogger<Program>>();
               logger.LogError(e,"an error occured durning migration");
           }

           await host.RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
