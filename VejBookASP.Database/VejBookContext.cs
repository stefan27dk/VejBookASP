using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using VejBookASP.Domain.Model;

namespace VejBookASP.Database
{
    public class VejBookContext : DbContext  // Inherit from DbContext
    {

        // Options
        public VejBookContext(DbContextOptions<VejBookContext> options) : base(options)  // Constructor
        {       
        }


        // Db Sets // The Entities from the Model which to be included in the DB
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Hold> Holds { get; set; }
        public DbSet<Timeslot> Timeslots { get; set; }
        public DbSet<BCalendar> BCalendars { get; set; }
        public DbSet<Booking> Bookings { get; set; }


        // Configuration
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());  // For naming the tables in the db with the same name as the Db sets
        }
    }
}
