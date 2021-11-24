using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoolClub.Models
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            this.Reservations = new HashSet<Reservation>();
        }

        //[Required]
        //[MinLength(6), MaxLength(30)]
        //public string Password { get; set; }

        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }

        //[Required]
        //public int RoleId { get; set; }

        //public virtual Role Role { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
