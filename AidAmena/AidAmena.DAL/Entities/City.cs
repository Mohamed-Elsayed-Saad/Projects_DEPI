using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AidAmena.DAL.Entities
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [ForeignKey("Governorate")]
        public int GovernorateId { get; set; }
        public Governorate? Governorate { get; set; }

        public ICollection<Village>? Villages { get; set; }
    }
}
