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
        public IEnumerable<Reservation> GetAllReservationsByTable(int id);
        public Reservation AddReservation(Reservation res);
    }
}
