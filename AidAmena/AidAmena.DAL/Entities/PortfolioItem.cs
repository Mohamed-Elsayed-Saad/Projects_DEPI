using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AidAmena.DAL.Entities
{
    public class PortfolioItem
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        [Required,MaxLength(200)]
        public string Description { get; set; }
        [Required]
        public string ImageUrl { get; set; }

        public DateTime CreatedAt { get; set; }


        // Foreign Key

        
        public string? ArtisanId { get; set; }

        [ForeignKey("Artisans")]
        public Artisan? Artisan { get; set; }
    }
}
