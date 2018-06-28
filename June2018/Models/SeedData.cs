using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace June2018.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new June2018Context(
                serviceProvider.GetRequiredService<DbContextOptions<June2018Context>>()))
            {
                // Look for any products.
                if (context.Product.Any())
                {
                    System.Diagnostics.Debug.WriteLine("products already in db...");
                    return;
                }

                context.Product.AddRange(
                    new Product
                    {
                        Sku = "100",
                        Name = "Green Hat",
                        Category = "Accessories",
                        Description = "Fitted cap",
                        //DateAdded = DateTime.Parse("2018-6-01"),
                        Price = 12.99M,
                        Cost = 4.99M,
                        Quantity = 99
                    },

                    new Product
                    {
                        Sku = "101",
                        Name = "Blue Hat",
                        Category = "Accessories",
                        Description = "Fitted cap",
                        //DateAdded = DateTime.Parse("2018-6-01"),
                        Price = 12.99M,
                        Cost = 4.99M,
                        Quantity = 95
                    },

                    new Product
                    {
                        Sku = "200",
                        Name = "Purple Polo",
                        Category = "Clothing",
                        Description = "Polo shirt",
                        //DateAdded = DateTime.Parse("2018-6-01"),
                        Price = 14.99M,
                        Cost = 5.99M,
                        Quantity = 50
                    },

                    new Product
                    {
                        Sku = "300",
                        Name = "Bottle Caps",
                        Category = "Candy",
                        Description = "Sugar rush",
                        //DateAdded = DateTime.Parse("2018-6-01"),
                        Price = 1.39M,
                        Cost = 0.49M,
                        Quantity = 200
                    }
                );
                context.SaveChanges();
            }
        }
    }
}