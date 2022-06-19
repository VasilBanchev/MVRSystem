using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer
{
    public class DrivingLicense
    {
        [Key]
        [MaxLength(9)]
        public string Id { get; set; }
        [Required]
        [MaxLength(10)]
        public string EGN { get; set; }
        [Required]
        [ForeignKey("Card")]
        public Card OwnerCard { get; set; }
        [Required]
        [MaxLength(100)]
        public int DrivingPoints { get; set; }
        [Required]
        [MaxLength(5)]
        public string Category { get; set; }

        private DrivingLicense()
        {

        }
        public DrivingLicense(Card ownercard,int points, string category)
        {
            this.OwnerCard = ownercard;
            this.DrivingPoints = points;
            this.Category = category;
        }
    }
}
