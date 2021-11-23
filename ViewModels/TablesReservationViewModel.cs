using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoolClub.ViewModels
{
    public class TablesReservationViewModel
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        public int TableId { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public System.DateTime Date { get; set; }

        [DataType(DataType.Time)]
        [Required]
        public System.DateTime TimeFrom { get; set; }

        [DataType(DataType.Time)]
        [Required]
        public System.DateTime TimeTo { get; set; }
    }
}
