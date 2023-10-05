using Microsoft.EntityFrameworkCore;
using PSIUWeb.Models;

namespace PSIUWeb.Data
{
    public static class SeedData
    {

        public static void EnsurePopulated( 
            IApplicationBuilder app 
        )
        {
            AppDbContext context =
                app.ApplicationServices.CreateScope()
                .ServiceProvider.GetRequiredService<AppDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            { 
                context.Database.Migrate();
            }

            if (!context.Pacients.Any())
            {
                context.Pacients.AddRange(
                    new Pacient
                    {
                        Name = "Mauricio",
                        BirthDate = new DateTime(1984, 7, 5),
                        Race = Race.Pardo,
                        Height = 180,
                        Weight = 88
                    },
                    new Pacient
                    {
                        Name = "Marcos",
                        BirthDate = new DateTime(1987, 2, 28),
                        Race = Race.Pardo,
                        Height = 175,
                        Weight = 90
                    }
                );

                context.SaveChanges();
            }

            if (!context.Psicos.Any())
            {
                context.Psicos.AddRange(
                    new Psico
                    {
                        Name = "Bianca",
                        BirthDate = new DateTime(1854, 6, 4),
                        Race = Race.Pardo,
                        Crp = 98745236,
                        Cep = 59746632
                    },
                    new Psico
                    {
                        Name = "Geovana",
                        BirthDate = new DateTime(1968, 5, 18),
                        Race = Race.Pardo,
                        Crp = 86325745,
                        Cep = 659458870
                    }
                );

                context.SaveChanges();
            }

        }

    }
}
