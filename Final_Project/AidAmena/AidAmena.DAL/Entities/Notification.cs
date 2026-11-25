using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AidAmena.DAL.Entities
{
    public class Notification
    {
        [Key] public int Id { get; set; }
        public string? Message { get; set; }
        public bool IsRead { get; set; }
        public DateTime CreatedAt { get; set; }= DateTime.Now;
    }
}
//id message IsRead CreatedAt