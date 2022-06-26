using Microsoft.EntityFrameworkCore;
using WebApplication4.Models.Entities;

namespace WebApplication4.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Project>().HasData(new Project
            {
                ID = 1,
                Name = "Social Media",
                Author = "Christian Bale"
            });

            modelBuilder.Entity<Project>().HasData(new Project
            {
                ID = 2,
                Name = "CRM System",
                Author = "Rayan Gosling"
            });
        }
    }
}
