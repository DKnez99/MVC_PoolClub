using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoolClub.ViewModels
{
    public class ReservationsDetailsViewModel
    {
        public int ReservationId { get; set; }
        public string UserFullName { get; set; }
        public string UserEmail { get; set;}
        public string PhoneNumber { get; set; }
        public int TableId { get; set; }
        public string Date { get; set; }
        public string TimeFrom { get; set; }

        public string TimeTo { get; set; }
    }
}
