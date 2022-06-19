using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer
{
    public class Passport
    {
        [Key]
        [MaxLength (9)]
        public string Id { get; set; }
        [Required]
        [MaxLength(10)]
        public string EGN{ get; set; }
        [Required]
        [ForeignKey("Card")]
        public Card Card_Owner { get; set; }
        
        [ForeignKey("Visa")]
        public List<Visa> Visas { get; set; }

        private Passport()
        {

        }

        public Passport(Card ownercard)
        {
            this.Card_Owner = ownercard;
            this.Visas = new List<Visa>();
        }
    }
}
