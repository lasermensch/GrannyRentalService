using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrannyRentalService.Models
{
    public class GrannyRentalContext : DbContext
    {
        public GrannyRentalContext(DbContextOptions<GrannyRentalContext> options) : base(options)
        {

        }
        public GrannyRentalContext()
        {

        }
        public DbSet<Granny> Grannies { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Granny>().ToTable("Grannies");
            modelBuilder.Entity<Booking>().ToTable("Bookings");
            modelBuilder.Entity<User>().ToTable("User_Accounts");
        }
    }
}
