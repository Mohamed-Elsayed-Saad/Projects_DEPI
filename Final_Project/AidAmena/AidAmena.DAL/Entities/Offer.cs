using System;
using System.Collections.Generic;
using System.Text;

namespace AidAmena.DAL.Entities
{
    public class Offer
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public string Status { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}

