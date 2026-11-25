using Microsoft.EntityFrameworkCore;
using AidAmena.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AidAmena.DAL.Database
{
    public class AidAmenaDbContext: DbContext
    {
        public DbSet<Governorate> Governorates { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Village> Villages { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Aid_Amena_Dev;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
        }

    }
}
