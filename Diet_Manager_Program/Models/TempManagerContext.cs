using Microsoft.EntityFrameworkCore;

namespace TempManager.Models
{
    public class UserManagerContext : DbContext
    {
        public UserManagerContext(DbContextOptions<UserManagerContext> options)
            : base(options)
        { }

        public DbSet<Temp> Temps { get; set; }
        public DbSet<Users> User { get; set; }
    }
}
