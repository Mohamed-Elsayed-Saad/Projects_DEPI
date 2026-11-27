
namespace AidAmena.DAL.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        public string? Icon { get; set; }

        public ICollection<SubCategory>? SubCategories { get; set; }
    }
}
