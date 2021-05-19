using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BicycleRental.Models;


namespace BicycleRental.Entity_Configurations
{
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder
                .HasKey(b => b.Id);

            builder
                .Property(b => b.RentalDate)
                .IsRequired();

            builder
                .Property(b => b.Price)
                .IsRequired();

            builder
                .Property(b => b.ExtensionDate)
                .IsRequired();

            builder
                .HasOne(b => b.Customer);

            builder
                .HasMany(b => b.Bicycles)
                .WithMany(b => b.Bookings);

        }
    }
}

