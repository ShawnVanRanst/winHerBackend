using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnBoardFlight.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnBoardFlight.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.Entity<Flight>()
            //    .HasOne(f => f.Origin)
            //    .WithMany()
            //    .IsRequired()
            //    .HasForeignKey("FlightId");

            //builder.Entity<Flight>()
            //    .HasOne(f => f.Destination)
            //    .WithMany()
            //    .IsRequired()
            //    .HasForeignKey("FlightId");

            builder.Entity<Flight>().Property(f => f.Origin).IsRequired();
            builder.Entity<Flight>().Property(f => f.Destination).IsRequired();
            builder.Entity<Flight>().HasKey(f => f.Id);

            builder.Entity<Flight>().HasData(
            new{ Id = 1, Origin = "Origin", Destination = "Destination" }
            );
        }

        public DbSet<Flight> Flights { get; set; }
    }
}
