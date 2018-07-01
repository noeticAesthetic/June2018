//Build an MVC application that does inventory management system
//Features:
//-------------1. Ability to add items
//-------------2. Ability to modify cost / units and description of items
//-------------3. Ability to delete items
//4. Ability to add items to order and checkout(doesn’t need payment)
//5. Ability to print invoices after order is complete and for historical orders.
//6. Ability to generate web reports for profit and loss
//Technical Requirements:
//-------------Should be build using MVC
//-------------Should have separate Data layer
//-------------Should have separate business logic layer
// Do not use built in crud operations plugins.

using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using June2018.Models;
using System;
using Microsoft.Extensions.Logging;

namespace June2018
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    var context = services.GetRequiredService<June2018Context>();
                    context.Database.Migrate();
                    SeedData.Initialize(services);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred seeding the DB.");
                }

                host.Run();
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
