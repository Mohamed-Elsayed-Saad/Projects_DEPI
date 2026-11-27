
namespace AidAmena.DAL.Entities
{
    public class UsedMaterial
    {
        public int MaterialNo { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;
        public decimal Cost { get; set; }

        public int Quantity { get; set; }

        [ForeignKey("ServiceRequest")]
        public int ServiceRequestId { get; set; }
        public ServiceRequest ServiceRequest { get; set; } = null!;
    }
}
