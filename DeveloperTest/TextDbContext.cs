using DeveloperTest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeveloperTest
{
    public class TextDbContext : DbContext
    {
        public TextDbContext(DbContextOptions<TextDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=DeveloperTest.db;");
        }

        //we cannot use primitive types, such as string, for the DbSet type
        public DbSet<WatchWord> WatchWords { get; set; }
        public DbSet<DistinctText> DistinctTexts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //initialize watchword list with data
            modelBuilder.Entity<WatchWord>().HasData(
                new WatchWord { Id= 1, Word = "cat" }, 
                new WatchWord { Id = 2, Word = "dog" },
                new WatchWord { Id = 3, Word = "rabbit" },
                new WatchWord { Id = 4, Word = "mouse" },
                new WatchWord { Id = 5, Word = "horse" });
        }
    }
}
