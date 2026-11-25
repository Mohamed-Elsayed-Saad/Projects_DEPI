using AidAmena.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AidAmena.DAL.Database.Configurations
{
    public class ServiceRequestConfiguration : IEntityTypeConfiguration<ServiceRequest>
    {
        public void Configure(EntityTypeBuilder<ServiceRequest> builder)
        {
            builder.HasKey(S => S.Id);

            builder.OwnsOne(S => S.PreferredSchedule, schedule =>
            {
                schedule.Property(P => P.Date)
                        .HasColumnName("PreferredDate");

                schedule.Property(P => P.Time)
                        .HasColumnName("PreferredTime");
            });
        }
    }
}
