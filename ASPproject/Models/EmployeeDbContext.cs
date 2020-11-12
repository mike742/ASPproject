using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPproject.Models
{
    public class EmployeeDbContext : DbContext 
    {
        public DbSet<Department> Departments { set; get; }
        public DbSet<Employee> Employees { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"server=localhost;user=root;password=;database=aspdb;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
