using System;
using System.Collections.Generic;
using System.Text;

namespace AidAmena.DAL.Entities
{
    public class AdminConfigration
    {


        
            public DateTime CreatedOn { get; set; } = DateTime.Now;
                   
            public string? CreatorUser { get; set; }
            
            
            public DateTime? ModifiedOn { get; set; }
            
            public string? ModifierUser { get; set; }
            
            
            public bool? IsDeleted { get; set; }
            
            public string? DeletedUser { get; set; }
            
            public DateTime? DeletedOn { get; set; }



    }
}
