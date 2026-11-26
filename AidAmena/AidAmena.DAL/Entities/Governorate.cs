using System.ComponentModel.DataAnnotations;

namespace AidAmena.DAL.Entities
{
    public class Governorate
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        public ICollection<City>? Cities { get; set; }
    }
}
