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
            // CLASSIFIED_AS: SubCategory 1 : N ServiceRequest
        builder.HasOne(sr => sr.SubCategory)
               .WithMany(s => s.ServiceRequests)
               .HasForeignKey(sr => sr.SubCategoryId)
               .OnDelete(DeleteBehavior.Restrict);

            // ASSIGNED_TO: Artisan 1 : N ServiceRequest
            builder.HasOne(sr => sr.Artisan)
                   .WithMany(a => a.ServiceRequests)
                   .HasForeignKey(sr => sr.ArtisanId)
                   .IsRequired(false)
                   .OnDelete(DeleteBehavior.Restrict);

            // HAS_OFFER: ServiceRequest 1 : N Offer
            builder.HasMany(sr => sr.Offers)
                   .WithOne(o => o.ServiceRequest)
                   .HasForeignKey(o => o.ServiceRequestId)
                   .OnDelete(DeleteBehavior.Cascade);


            // EXTRA_COST: ServiceRequest 1 : N AdditionalCost
            builder.HasMany(sr => sr.AdditionalCosts)
                   .WithOne(ac => ac.ServiceRequest)
                   .HasForeignKey(ac => ac.ServiceRequestId)
                   .OnDelete(DeleteBehavior.Cascade);

            // USES: ServiceRequest 1 : N UsedMaterial
            builder.HasMany(sr => sr.UsedMaterials)
                   .WithOne(um => um.ServiceRequest)
                   .HasForeignKey(um => um.ServiceRequestId)
                   .OnDelete(DeleteBehavior.Cascade);
            // HAS_REVIEW: ServiceRequest 1 : 1 Review
            builder.HasOne(sr => sr.Review)
                   .WithOne(r => r.ServiceRequest)
                   .HasForeignKey<Review>(r => r.ServiceRequestId)
                   .OnDelete(DeleteBehavior.Cascade);
            // PAID_BY: ServiceRequest 1 : 1 Payment
            builder.HasOne(sr => sr.Payment)
                   .WithOne(p => p.ServiceRequest)
                   .HasForeignKey<Payment>(p => p.ServiceRequestId)
                   .OnDelete(DeleteBehavior.Cascade);
            // ABOUT: ServiceRequest 1 : N Complaint
            builder.HasMany(sr => sr.Complaints)
                   .WithOne(c => c.ServiceRequest)
                   .HasForeignKey(c => c.ServiceRequestId)
                   .OnDelete(DeleteBehavior.Restrict);
            // PLACES: Customer 1 : N ServiceRequest
            builder.HasOne(sr => sr.Customer)
                   .WithMany(c => c.ServiceRequests)
                   .HasForeignKey(sr => sr.CustomerId)
                   .OnDelete(DeleteBehavior.Restrict);

            // LOCATED_AT: Address 1 : N ServiceRequest
            builder.HasOne(sr => sr.Address)
                   .WithMany(a => a.ServiceRequests)
                   .HasForeignKey(sr => sr.AddressId)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
