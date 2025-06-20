using Microsoft.EntityFrameworkCore;
using MyApplication3.Models;

namespace MyApplication3.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
        

        //how to create database
        public DbSet<DairyEntry> DairyEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<DairyEntry>().HasData(
            new DairyEntry
            {
                id = 1,
                Title = "Outing",
                Content = "Went with my friend",
                Created = DateTime.Now
            },
            new DairyEntry
            {
                id = 2,
                Title = "Shopping",
                Content = "Went with my friend",
                Created = DateTime.Now
            },
            new DairyEntry
            {
                id = 3,
                Title = "Travelling",
                Content = "To  Home Town",
                Created = DateTime.Now
            }

               );

        }
    }
}
