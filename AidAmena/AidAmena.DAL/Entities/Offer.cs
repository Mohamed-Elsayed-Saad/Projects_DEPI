
namespace AidAmena.DAL.Entities
{
    public class Offer
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "decimal(18,2)")]


        public decimal Price { get; set; }
        [MaxLength(50)]


        public string Status { get; set; }

        public DateTime CreatedAt { get; set; }


        #region Navigation Properties

        //Navigation Property
        
        public int ServiceRequestId { get; set; }
        public ServiceRequest ServiceRequest { get; set; }

        public int ArtisanId { get; set; }
        public Artisan Artisan { get; set; }

        #endregion

    }
}
