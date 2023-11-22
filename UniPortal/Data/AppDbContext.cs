using Microsoft.EntityFrameworkCore;
using UniPortal.Models;

namespace UniPortal.DbContexts
{
    public class AppDbContext : DbContext
    {

        DbSet<Student> Student { get; set; }
        DbSet<Teacher> Teacher { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    }
}
