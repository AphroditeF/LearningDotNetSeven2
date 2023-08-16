using LearningDotNetSeven2.Models;
using Microsoft.EntityFrameworkCore;

namespace LearningDotNetSeven2.Data
{
    public class DataContextEF : DbContext
    {
        public DbSet<Computer>? Computer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if(!options.IsConfigured)
            {
                options.UseSqlServer("Server=(local);Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true;",
                    options=>options.EnableRetryOnFailure());
            }   
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("TutorialAppSchema");

            modelBuilder.Entity<Computer>()
                //.HasNoKey();
                .HasKey(c=>c.ComputerID);
                //.ToTable("Computer","TutorialAppSchema");
        }

    }

}