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

    }
}
