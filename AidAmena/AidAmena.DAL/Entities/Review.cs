
namespace AidAmena.DAL.Entities
{
    public class Review
    {
        public int Id { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }

        [MaxLength(1000)]
        public string? Comment { get; set; }

        public DateTime CreatedAt { get; set; }
        public int Communication { get; set; }
        public int Quality { get; set; }
        public int Price { get; set; }
        public int Punctuality { get; set; }

        [ForeignKey("ServiceRequest")]
        public int ServiceRequestId { get; set; }
        public ServiceRequest ServiceRequest { get; set; } = null!;

        [ForeignKey("Customer")]
        public string CustomerId { get; set; } = null!;
        public Customer Customer { get; set; } = null!;


        [ForeignKey("Artisan")]
        public string ArtisanId { get; set; } = null!;
        public Artisan Artisan { get; set; } = null!;



    }
}
