using System;
using System.Collections.Generic;
using System.Text;

namespace AidAmena.DAL.Entities
{
    public  class ServiceRequest
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public List<string> Images { get; set; } = new();

        public List<string> BeforePhotos { get; set; } = new();

        public List<string> AfterPhotos { get; set; } = new();

        public string Notes { get; set; }

        public PreferredSchedule PreferredSchedule { get; set; }
       
        public string Urgency { get; set; }

        public string Status { get; set; }

        public decimal TotalPrice { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
