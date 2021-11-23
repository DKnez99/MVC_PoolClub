using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoolClub.Models
{
    public class Reservation
    {
        [Required]
        [Key]
        public int ReservationId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int TableId { get; set; }

        [Required]
        public System.DateTime TimeFrom { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public System.DateTime TimeTo { get; set; }

        public virtual AppUser User { get; set; }

        public virtual Table Table { get; set; }
    }
}
