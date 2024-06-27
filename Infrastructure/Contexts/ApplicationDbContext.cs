using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Game>Games => Set<Game>();
        public DbSet<Image>Images => Set<Image>();

    }
}
