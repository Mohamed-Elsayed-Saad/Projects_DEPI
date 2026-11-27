
namespace AidAmena.DAL.Entities
{
    public class User
    {
        [Key] 
        public string Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
       public string Role { get; set; }
        public string Stauts { get; set; }
        
       
    }
}
// id name phone email password profileimage createdat stauts role 