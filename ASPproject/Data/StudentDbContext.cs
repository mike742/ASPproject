using ASPproject.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPproject.Data
{
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"server=localhost;user=root;password=;database=aspdb;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
