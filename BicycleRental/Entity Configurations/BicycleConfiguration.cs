using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BicycleRental.Models;


namespace BicycleRental.Entity_Configurations
{
    public class BicycleConfiguration : IEntityTypeConfiguration<Bicycle>
    {
        public void Configure(EntityTypeBuilder<Bicycle> builder)
        {
            builder
                .HasKey(b => b.Id);

            builder
                .Property(b => b.Model)
                .IsRequired();

            builder
                .Property(b => b.Price)
                .IsRequired();

            builder
              .Property(b => b.Condition)
              .IsRequired();

            builder
              .Property(b => b.Availability)
              .IsRequired();

            builder
              .Property(b => b.MakeYear);

            builder
                .HasOne(b => b.BicycleBrand)
                .WithMany(b => b.Bicycles);

            builder
               .HasMany(b => b.Bookings)
               .WithMany(b => b.Bicycles);
        }
    }
}

