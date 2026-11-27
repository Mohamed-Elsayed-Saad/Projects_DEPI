
namespace AidAmena.DAL.Entities
{
    public class Certificate
    {
        [Key]
       public int  CertID { get; set; }//ID

        public string CertificateName { get; set; } //Title

        public string FileUrl {  get; set; }

        // relation




        public string? ArtisanId { get; set; }

        [ForeignKey("Artisans")]
        public Artisan? Artisan { get; set; }
    }
}
