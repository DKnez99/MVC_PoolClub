using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoolClub.Models
{
    public class Role
    {
        public Role()
        {
            this.Users = new HashSet<AppUser>();
        }

        [Key]
        [Required]
        public int RoleId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<AppUser> Users { get; set; }
    }
}
