
namespace AidAmena.DAL.Entities
{
    public class ServiceRequest
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }

        public List<string> Images { get; set; } = new();

        public List<string> BeforePhotos { get; set; } = new();

        public List<string> AfterPhotos { get; set; } = new();

        [MaxLength(500)]
        public string? Notes { get; set; }

        public PreferredSchedule PreferredSchedule { get; set; }

        [MaxLength(50)]
        public string Urgency { get; set; }

        [MaxLength(50)]
        public string Status { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }

        public DateTime CreatedAt { get; set; }
        #region Navigation Properties
        //Navigation Property
        public int SubCategoryId { get; set; }      // الـ FK
        public SubCategory SubCategory { get; set; } // الـ Navigation Property

        public int? ArtisanId { get; set; }   // nullable  FK
        public Artisan Artisan { get; set; } // الـ Navigation Property

        public ICollection<Offer> Offers { get; set; }

        public ICollection<AdditionalCost> AdditionalCosts { get; set; }

        public ICollection<UsedMaterial> UsedMaterials { get; set; }

        public Review Review { get; set; }

        public Payment Payment { get; set; }
        public ICollection<Complaint> Complaints { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int AddressId { get; set; }
        public Address Address { get; set; }




        #endregion
    }

}
