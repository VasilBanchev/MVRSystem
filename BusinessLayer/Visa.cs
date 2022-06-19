using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer
{
    public class Visa
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(30)]
        public string Country { get; set; }
        [Required]
        public int Entries { get; set; }
        [Required]
        public string CreationDate { get; set; }
        [Required]
        public string ExpireDate { get; set; }

        private Visa()
        {

        }

        public Visa(string country, int entries, string creation, string expire)
        {
            this.Country = country;
            this.Entries = entries;
            this.CreationDate = creation;
            this.ExpireDate = expire;
        }
    }
}
