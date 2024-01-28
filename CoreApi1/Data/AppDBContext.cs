using CoreApi1.Model;
using Microsoft.EntityFrameworkCore;

namespace CoreApi1.Data
{
    public class AppDBContext : DbContext
    {

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<User> user { get; set; }
    }
}
