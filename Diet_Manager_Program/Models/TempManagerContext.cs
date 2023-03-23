using TempManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TempManager.Models
{
    public class UserManagerContext : DbContext
    {
        public UserManagerContext(DbContextOptions<UserManagerContext> options)
            : base(options)
        { }

        public DbSet<Temp> Temps { get; set; }
        public DbSet<Users> User { get; set; }
        public DbSet<Histories> History { get; set; }
    }
}
