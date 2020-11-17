using ASPproject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPproject.Data
{
    public class SCIDbContext : DbContext
    {
        public DbSet<Student> Students { set; get; }
        public DbSet<Course> Courses { set; get; }
        public DbSet<Instructor> Instructors { set; get; }
        public DbSet<StudentCourse> StudentCourses { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"server=localhost;user=root;password=;database=aspdb;");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
