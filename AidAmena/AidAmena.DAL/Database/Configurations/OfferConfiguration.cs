using AidAmena.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AidAmena.DAL.Database.Configurations
{
    public class OfferConfiguration : IEntityTypeConfiguration<Offer>
    {
        public void Configure(EntityTypeBuilder<Offer> builder)
        {
            // SUBMITS: Artisan 1 : N Offer
            builder.HasOne(o => o.Artisan)
                   .WithMany(a => a.Offers)
                   .HasForeignKey(o => o.ArtisanId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
