using AuctionApp.Data;
using Microsoft.EntityFrameworkCore;

namespace AuctionApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AuctionAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AuctionAppContext>>()))
            {
                // Look for any Product.
                if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }
                context.Product.AddRange(
                    new Product
                    {
                        Name = "Rower",
                        Description = "Rower górski co szybko jeździ",
                        Category = "Sport",
                        Price = 177.99M
                    },
                    new Product
                    {
                        Name = "Obraz",
                        Description = "Obraz znanego artysty",
                        Category = "Sztuka",
                        Price = 75.99M
                    },
                    new Product
                    {
                        Name = "Nóż kuchenny",
                        Description = "Nóż do krojenia warzyw",
                        Category = "Kuchnia",
                        Price = 17.99M
                    },
                    new Product
                    {
                        Name = "Telewizor",
                        Description = "Kolorowy telewizor",
                        Category = "Elektronika",
                        Price = 70.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
