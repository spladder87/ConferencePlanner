using Microsoft.EntityFrameworkCore;

namespace BackEnd.Models
{


    /// <summary>
    /// This is the connection object for our database
    /// </summmary>
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Speaker> Speakers { get; set; }
    }
}