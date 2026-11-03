using Microsoft.EntityFrameworkCore;
using RealProject.Entities;
using System.Reflection.Emit;

namespace RealProject.Entities
{
    public class AppDbContext : DbContext
    {
        //User Management
        public DbSet<Admin> Admins { get; set; }
        public DbSet<User> Users { get; set; }

        //Course
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Tutorial> Tutorials { get; set; }
        public DbSet<Quiz> Quizes { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
            .HasAlternateKey(c => c.PhoneNumber);

            base.OnModelCreating(builder);
        }
    }

}
