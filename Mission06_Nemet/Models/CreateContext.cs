using Microsoft.EntityFrameworkCore;

namespace Mission06_Nemet.Models
{
    public class CreateContext : DbContext
    {
        public CreateContext(DbContextOptions<CreateContext> options) : base(options)
        {
        }

        // DbSet for Movies instead of Application
        public DbSet<Movie> Application { get; set; }
    }
}
