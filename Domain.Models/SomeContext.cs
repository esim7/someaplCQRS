using Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models
{
    public class SomeContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public SomeContext(DbContextOptions<SomeContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(
                "Server=localhost;Database=someApplication;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StudentCourse>()
                .HasKey(c => new
                {
                    c.CourseId,
                    c.StudentId
                });

            modelBuilder.Entity<StudentCourse>().HasOne<Student>().WithMany(c => c.Courses)
                .HasForeignKey(s => s.StudentId);

            modelBuilder.Entity<StudentCourse>().HasOne<Course>().WithMany(c => c.Students)
                .HasForeignKey(s => s.CourseId);
        }
    }
}