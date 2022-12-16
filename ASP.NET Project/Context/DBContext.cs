using ASP.NET_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Project.Context
{
    public class DBContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Horse> Horses { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<RidingCenter> RidingCenters { get; set; }

        public DbSet<Appointment> Appointments { get; set; }

        public DBContext(DbContextOptions<DBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // One to one (Locations - RidingCenters)

            modelBuilder.Entity<RidingCenter>().HasOne(o => o.Location).WithOne(o => o.RidingCenter).HasForeignKey<RidingCenter>(o => o.LocationID);

            // One to Many (RidingCenters - Horses, Category - Horses)

            modelBuilder.Entity<RidingCenter>().HasMany(o => o.Horses).WithOne(o => o.RidingCenter);

            modelBuilder.Entity<Category>().HasMany(o => o.Horses).WithOne(o => o.Category);

            // Many to Many (Users - Horses)

            modelBuilder.Entity<Appointment>().HasKey(o => new { o.HorseId, o.PersonId });

            modelBuilder.Entity<Appointment>().HasOne(o => o.Horse).WithMany(o => o.Appointments).HasForeignKey(o => o.HorseId);

            modelBuilder.Entity<Appointment>().HasOne(o => o.Person).WithMany(o => o.Appointments).HasForeignKey(o => o.PersonId);

            base.OnModelCreating(modelBuilder);
        }

    }
}
