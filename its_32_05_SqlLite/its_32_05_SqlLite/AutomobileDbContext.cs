using its_32_05_SqlLite.Classi;
using Microsoft.EntityFrameworkCore;

namespace its_32_05_SqlLite
{
    public class AutomobileDbContext : DbContext
    {
        public AutomobileDbContext(DbContextOptions<AutomobileDbContext> options) : base(options) { }

        public DbSet<Automobile> Automobiles { get; set; }
    }
}
