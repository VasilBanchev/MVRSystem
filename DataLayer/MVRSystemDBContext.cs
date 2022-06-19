using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;

namespace DataLayer
{
    public class MVRSystemDBContext : DbContext
    {
        public MVRSystemDBContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // optionsBuilder.UseInMemoryDatabase("DB");
             optionsBuilder.UseSqlServer("Server=localhost;Database=MVR2;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Passport>().HasIndex(passport=> passport.EGN).IsUnique();
            modelBuilder.Entity<DrivingLicense>().HasIndex(drLicense => drLicense.EGN).IsUnique();
            modelBuilder.Entity<Card>().HasIndex(card=> card.EGN).IsUnique();
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Card> Cards { get; set; }

        public DbSet<Passport> Passports { get; set; }
        public DbSet<DrivingLicense> DrivingLicenses { get; set; }
    }
}
