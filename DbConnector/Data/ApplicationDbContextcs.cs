using DbConnector.Core;
using Microsoft.EntityFrameworkCore;

namespace DbConnector.Data
{
    public class ApplicationDbContextcs : DbContext
    {
        public ApplicationDbContextcs(DbContextOptions<ApplicationDbContextcs> options)
            :base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Trade> Traids { get; set; } = null!;
    }
}

