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
    public class RentalCenterConfiguration : IEntityTypeConfiguration<RentalCenter>
    {
        public void Configure(EntityTypeBuilder<RentalCenter> builder)
        {
            builder
                .HasKey(rc => rc.Id);

            builder
                .Property(rc => rc.Name);

            builder
                .Property(rc => rc.Address);

            builder
                .Property(rc => rc.PhoneNumber);

            builder
                .Property(rc => rc.Email);

            builder
                .HasMany(rc => rc.Bicycles);

        }
    }
}
