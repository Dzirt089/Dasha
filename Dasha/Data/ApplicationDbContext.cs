using Dasha.Model;
using Microsoft.EntityFrameworkCore;

namespace Dasha.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            Database.EnsureCreated();
        }

        public DbSet<Students> Students { get; set; }
    }
}
