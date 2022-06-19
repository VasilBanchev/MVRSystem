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
             optionsBuilder.UseSqlServer("Server=localhost;Database=MVR;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


        }

        public DbSet<User> Users { get; set; }

        public DbSet<Card> Cards { get; set; }

        public DbSet<Passport> Passports { get; set; }
        public DbSet<Visa> Visas { get; set; }
        public DbSet<DrivingLicense> DrivingLicenses { get; set; }
    }
}
