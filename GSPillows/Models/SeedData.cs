using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GSPillows.Data;
using System;
using System.Linq;

namespace GSPillows.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GSPillowsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<GSPillowsContext>>()))
            {
                // Look for any movies.
                if (context.Pillow.Any())
                {
                    return;   // DB has been seeded
                }

                context.Pillow.AddRange(
                    new Pillow
                    {
                        Brand = "Abc",
                        Size = "Small",
                        Color = "red",
                        Material = "soft",
                        Rating = '5'
                    },
                    new Pillow
                    {
                        Brand = "Aquagel",
                        Size = "Small",
                        Color = "White",
                        Material = "soft",
                        Rating = '3'
                    },
                    new Pillow
                    {
                        Brand = "Fieldcrest",
                        Size = "Medium",
                        Color = "Brown",
                        Material = "Hard",
                        Rating = '5'
                    },
                    new Pillow
                    {
                        Brand = "Bio-Soy",
                        Size = "Large",
                        Color = "Blue",
                        Material = "soft",
                        Rating = '2'
                    },
                    new Pillow
                    {
                        Brand = "Heavenly",
                        Size = "Small",
                        Color = "Black",
                        Material = "Hard",
                        Rating = '5'
                    },
                    new Pillow
                    {
                        Brand = "KingsDown",
                        Size = "Medium",
                        Color = "Purple",
                        Material = "soft",
                        Rating = '1'
                    },
                    new Pillow
                    {
                        Brand = "Simba",
                        Size = "Small",
                        Color = "Green",
                        Material = "soft",
                        Rating = '4'
                    },
                    new Pillow
                    {
                        Brand = "Ploom",
                        Size = "Small",
                        Color = "White",
                        Material = "Hard",
                        Rating = '3'
                    },
                    new Pillow
                    {
                        Brand = "Graphene",
                        Size = "Large",
                        Color = "Gray",
                        Material = "soft",
                        Rating = '5'
                    },
                    new Pillow
                    {
                        Brand = "Naturtex",
                        Size = "Small",
                        Color = "red",
                        Material = "Hard",
                        Rating = '3'
                    }

                );
                context.SaveChanges();
            }
        }
    }
}