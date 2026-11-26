using AidAmena.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AidAmena.DAL.Database
{
    public class AidAmenaDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Aid_Amena_Dev;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
        }
        public DbSet<AdditionalCost> AdditionalCosts { get; set; }
        public DbSet<Artisan> Artisans { get; set; }
        public DbSet<ArtisanWorkingHour> ArtisanWorkingHours { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<PortfolioItem> PortfolioItems { get; set; }
    }
}
