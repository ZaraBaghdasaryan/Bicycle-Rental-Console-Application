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
    public class BicycleBrandConfiguration : IEntityTypeConfiguration<BicycleBrand>
    {
        public void Configure(EntityTypeBuilder<BicycleBrand> builder)
        {

            builder
                .HasKey(bb => bb.Id);

            builder
                .Property(bb => bb.Name)
                .IsRequired();

            builder
                .Property(bb => bb.Location);

            builder
              .Property(bb => bb.Address);

            builder
                 .HasMany(bb => bb.Bicycles) 
                 .WithOne(b => b.BicycleBrand);

        }
    }
}


