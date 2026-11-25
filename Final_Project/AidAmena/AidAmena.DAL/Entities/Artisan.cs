using System;
using System.Collections.Generic;
using System.Text;

namespace AidAmena.DAL.Entities
{
    public class Artisan:AdminConfigration
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
 
    public List<PortfolioItem>? PortfolioItems{ get; set; } 
    public List<ArtisanWorkingHour>? ArtisanWorkingHours{ get; set; } 
    public List<Certificate>? Certificates{ get; set; } 
        

    }
}
