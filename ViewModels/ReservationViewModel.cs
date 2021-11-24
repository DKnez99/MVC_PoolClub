using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoolClub.ViewModels
{
    public class ReservationViewModel
    {
        public int ReservationId { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int TableId { get; set; }
        public string Date { get; set; }
        public string TimeFrom { get; set; }
        public string TimeTo { get; set; }
        public bool Expired { get; set; }
    }
}
