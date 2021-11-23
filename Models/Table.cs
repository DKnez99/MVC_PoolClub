using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoolClub.Models
{
    public class Table
    {
        public Table()
        {
            this.Reservations = new HashSet<Reservation>();
        }

        [Key]
        [Required]
        public int TableId { get; set; }

        [Required]
        public int Floor { get; set; }

        //public string PhotoPath { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
