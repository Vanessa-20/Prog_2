using Microsoft.EntityFrameworkCore;
using PSIUWeb.Models;
using static System.Net.WebRequestMethods;

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


                if (!context.Midias.Any())
                {
                    context.Midias.AddRange(
                    new Midia
                    {
                        MidiaId = 614,
                        URL = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fpt.vecteezy.com%2Ffotos-gratis%2F3d&psig=AOvVaw2KiVIB40NmJA6Lz5kt5L0B&ust=1699572366312000&source=images&cd=vfe&ved=0CBEQjRxqFwoTCNjnhs7GtYIDFQAAAAAdAAAAABAE ",
                        TipoMidia = "Foto"

                    },
                    new Midia
                    {
                        MidiaId = 555,
                        URL = "https://www.google.com/url?sa=i&url=http%3A%2F%2Fcbissn.ibict.br%2Findex.php%2Fimagens%2F1-galeria-de-imagens-01%2Fdetail%2F3-imagem-3-titulo-com-ate-45-caracteres&psig=AOvVaw2KiVIB40NmJA6Lz5kt5L0B&ust=1699572366312000&source=images&cd=vfe&ved=0CBEQjRxqFwoTCNjnhs7GtYIDFQAAAAAdAAAAABAI ",
                        TipoMidia = "Foto"
                    }

                    ) ;

                    context.SaveChanges();
                }

            }

        }

    }
}
