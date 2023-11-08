using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using PjVanessaRossetto.Models;

namespace PjVanessaRossetto.Data
{
    public class AppDbContext : 
        IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions options)
            : base(options) 
        {
        }

        public DbSet<Psicologo>? Psicologo { get; set; }
    }
}
