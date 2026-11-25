using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Project_Depi.DAL.DAL.Entities
{
    public class Complaint
    {
        public int Id { get; set; }

        [Required]
        public string? IssueType { get; set; } 

        [Required]
        [MaxLength(2000)]
        public string? Description { get; set; }
        public string? Status { get; set; }
        public List<String>? Attachments { get; set; }  //multivalued
        public DateTime CreatedAt { get; set; }

        [ForeignKey("ServiceRequest")]
        public int ServiceRequestId { get; set; }
        public ServiceRequest ServiceRequest { get; set; } = null!;

        [ForeignKey("Customer")]
        public string CustomerId { get; set; } = null!;
        public Customer Customer { get; set; } = null!;

        [ForeignKey("Admin")]
        public string? AdminId { get; set; }
        public Admin? Admin { get; set; }

    }
}
