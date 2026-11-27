using AidAmena.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AidAmena.DAL.Database
{
    public class AidAmenaDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Aid_Amena_Dev;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AidAmenaDbContext).Assembly);
        }
        public DbSet<AdditionalCost> AdditionalCosts { get; set; }
        public DbSet<Artisan> Artisans { get; set; }
        public DbSet<ArtisanWorkingHour> ArtisanWorkingHours { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<PortfolioItem> PortfolioItems { get; set; }

        // Zeyad's entities
        public DbSet<Governorate> Governorates { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Village> Villages { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<ServiceRequest> ServiceRequests { get; set; }
        public DbSet<Offer> Offers { get; set; }
    }
}
