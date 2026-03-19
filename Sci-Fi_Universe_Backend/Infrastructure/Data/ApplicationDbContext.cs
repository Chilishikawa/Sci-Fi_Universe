using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    // DbContext = puente entre C# y la base de datos (EF Core)
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        // Tabla Characters
        public DbSet<Character> Characters { get; set; }
    }
}
