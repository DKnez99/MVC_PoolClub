using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoolClub.Models.Services
{
    public interface ITableService
    {
        public IEnumerable<Table> GetAllTables();
        public Table GetTable(int id);
        public IEnumerable<Reservation> GetAllReservationsByTableAfterDate(int id, System.DateTime date);
        public Reservation AddReservation(Reservation res);
        public IEnumerable<Reservation> GetAllReservations();
        public Reservation GetReservation(int id);
    }
}
