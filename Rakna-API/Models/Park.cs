using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rakna_API.Models
{
    public class Park
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
        public int ID { get; set; }
        [MaxLength(500)]    
        public string ParkName { get; set; }
        [MaxLength(500)]
        public string ParkLocation { get; set;}
        public byte[] ParkImage { get; set;}
        public int PublicIntID { get; set; } 
    }
}
