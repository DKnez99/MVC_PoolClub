using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoolClub.Models
{
    public class AppUser
    {
        public AppUser()
        {
            this.Reservations = new HashSet<Reservation>();
        }
     
        [Key]
        [Required]
        public int UserId { get; set; }

        [Required]
        [EmailAddress]
        [MinLength(5), MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [MinLength(6), MaxLength(30)]
        public string Password { get; set; }

        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }

        [Required]
        [MinLength(7), MaxLength(30)]
        public string PhoneNumber { get; set; }

        [Required]
        public int RoleId { get; set; }

        public virtual Role Role { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
