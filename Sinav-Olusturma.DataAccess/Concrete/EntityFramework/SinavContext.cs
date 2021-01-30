using Microsoft.EntityFrameworkCore;
using Sinav_Olusturma.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sinav_Olusturma.DataAccess.Concrete.EntityFramework
{
    public class SinavContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=SinavDB.db");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Story> Stories { get; set; }
        public DbSet<Question> Questions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Story>()
                .Property(e => e.Id)
                .ValueGeneratedOnAdd();
            base.OnModelCreating(modelBuilder);
        }
    }
}
