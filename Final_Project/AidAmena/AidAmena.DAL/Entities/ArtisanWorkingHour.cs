using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AidAmena.DAL.Entities
{
    public class ArtisanWorkingHour
    {
        
        public int Id { get; set; }

        [Required]
        public DayOfWeek Day { get; set; }

        [Required]
        public TimeOnly FromTime { get; set; }

        [Required]
        public TimeOnly ToTime { get; set; }

        // Foreign Key
        public string? ArtisanID { get; set; }

        [ForeignKey("Artisans")]
        public List<Artisan>? Artisans { get; set; }
    }
}
