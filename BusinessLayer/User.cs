using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(8)]
        public string Password { get; set; }
        [Required]
        [MaxLength(20)]
        public string Email { get; set; }
        [Required]
        public bool IsAdmin { get; set; }


        public User()
        {

        }

        public User(string uname, string password, string email, bool admin)
        {
            this.Username = uname;
            this.Password = password;
            this.Email = email;
            this.IsAdmin = admin;
        }
    }
}
