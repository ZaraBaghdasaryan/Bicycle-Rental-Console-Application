using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BicycleRental.Models;

namespace BicycleRental.Entity_Configurations 
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder
                .HasKey(b => b.Id);

            builder
                .Property(b => b.FirstName)
                .IsRequired();

            builder
                .Property(b => b.LastName)
                .IsRequired();

            builder
              .Property(b => b.Email)
              .IsRequired();

            builder
              .Property(b => b.Address);

            builder
                .HasMany(c => c.Bookings);
            
        }
    }
}


