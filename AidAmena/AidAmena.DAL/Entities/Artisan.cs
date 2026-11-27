
namespace AidAmena.DAL.Entities
{
    public class Artisan : AdminConfigration
    {
        public string Id { get; set; }

        public string NationalId { get; set; } // الرقم القومي 

        public string Profession {  get; set; } // المهنه الاساسيه 

        public int  ExperienceYears { get; set; }

        public VerificationStatus VerificationStatus { get; set; } = VerificationStatus.UnderReview;

        public AvailabilityStatus AvailabilityStatus { get; set; }// حاله العاميل متاح ولا لا 

        public decimal Balance { get; set; }// الرصيد 

        public decimal AvgRating {  get; set; }

        public int CompletedJobs { get; set; }// عدد الطلابات الي الحرفي انهاها 













        // relation
        
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

        
        [ForeignKey("VerifiedBy")]
        public int? VerifiedByAdminId { get; set; }
        public Admin VerifiedBy { get; set; }

     
        public List<City> ServedCities { get; set; } = new();

       
        public List<SubCategory> SubCategories { get; set; } = new();

       
        public List<ServiceRequest> AssignedRequests { get; set; } = new();

        
        public List<Offer> Offers { get; set; } = new();

        
        public List<Review> Reviews { get; set; } = new();

       
        public List<Certificate> Certificates { get; set; } = new();

        

        public List<PortfolioItem> PortfolioItems { get; set; } = new();
        public List<ArtisanWorkingHour> ArtisanWorkingHours { get; set; } = new();

    }

    

}

