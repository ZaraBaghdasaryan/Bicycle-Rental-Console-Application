using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BicycleRental.Models;
using Microsoft.EntityFrameworkCore;
using BicycleRental.Entity_Configurations;

namespace BicycleRental
{
    class BicycleRentalDBContext :DbContext
    {
        public DbSet<Bicycle> Bicycles { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<RentalCenter> RentalCenters { get; set; }
        public DbSet<BicycleBrand> BicycleBrands { get; set; } // add-migration CreateBicycleRentalDB



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=BicycleRental;Trusted_Connection=True;");
            
        }

       protected override void OnModelCreating(ModelBuilder modelBuidler)
        {
            modelBuidler
                .ApplyConfiguration(new BicycleBrandConfiguration());
            modelBuidler
              .ApplyConfiguration(new BicycleConfiguration());
            modelBuidler
              .ApplyConfiguration(new BookingConfiguration());
            modelBuidler
              .ApplyConfiguration(new CustomerConfiguration());
            modelBuidler
              .ApplyConfiguration(new RentalCenterConfiguration());

        }

    }
}
