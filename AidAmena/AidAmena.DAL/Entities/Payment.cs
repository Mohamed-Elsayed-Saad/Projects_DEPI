
using System.ComponentModel.DataAnnotations;
namespace AidAmena.DAL.Entities
{
    public class Payment
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string? Status { get; set; }
        public decimal Amount { get; set; }
        public decimal CommissionRate { get; set; }
        public decimal ArtisanEarnings { get; set; }
        [Required]
        public string? PaymentMethod { get; set; }

        public DateTime CreatedAt { get; set; }
        public decimal PlatformRevenue { get; set; }



        public int ServiceRequestId { get; set; }
        public ServiceRequest ServiceRequest { get; set; } = null!;
    }
}
