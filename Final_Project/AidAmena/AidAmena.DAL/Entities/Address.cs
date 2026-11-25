using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AidAmena.DAL.Entities
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Label { get; set; } = string.Empty;

        [Required, MaxLength(200)]
        public string Street { get; set; } = string.Empty;

        [MaxLength(50)]
        public string? Building { get; set; }

        [MaxLength(50)]
        public string? Apartment { get; set; }

        public double? Latitude { get; set; }
        public double? Longitude { get; set; }

        [ForeignKey("Village")]
        public int VillageId { get; set; }
        public Village? Village { get; set; }

        public int UserId { get; set; }
    }
}