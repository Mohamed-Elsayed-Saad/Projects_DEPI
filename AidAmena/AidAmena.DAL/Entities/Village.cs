using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AidAmena.DAL.Entities
{
    public class Village
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [ForeignKey("City")]
        public int CityId { get; set; }
        public City? City { get; set; }

        public ICollection<Address>? Addresses { get; set; }
    }
}
