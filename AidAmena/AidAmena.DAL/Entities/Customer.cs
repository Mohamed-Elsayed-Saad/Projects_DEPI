using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AidAmena.DAL.Entities
{
    public class Customer
    {
        [Key] 
        public string Id { get; set; }
    }
}
//id