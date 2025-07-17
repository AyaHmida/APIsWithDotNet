using DevAPI.Entities;
using Microsoft.EntityFrameworkCore;


namespace DevAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                    : base(options) { }
        public DbSet<User> Users { get; set; }

    }
}
