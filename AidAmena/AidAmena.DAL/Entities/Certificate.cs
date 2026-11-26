using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

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
