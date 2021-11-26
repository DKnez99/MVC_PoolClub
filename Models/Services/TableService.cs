using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoolClub.Models.Services
{
    public class TableService : ITableService
    {
        private readonly PoolClubDbContext context;

        public TableService(PoolClubDbContext context)
        {
            this.context = context;
        }

        public Reservation AddReservation(Reservation res)
        {
            try
            {
                context.Reservations.Add(res);
                context.SaveChanges();
                return res;
            }
            catch
            {
                return null;
            }
        }

        public IEnumerable<Reservation> GetAllReservationsByTableAfterDate(int id, System.DateTime date)
        {
            return context.Reservations.Where(r => r.TableId == id && r.TimeFrom>date);
        }

        public IEnumerable<Table> GetAllTables()
        {
            return context.Tables;
        }

        public Table GetTable(int id)
        {
            return context.Tables.Find(id);
        }

        public IEnumerable<Reservation> GetAllReservations()
        {
            return context.Reservations.OrderByDescending(e=>e.TimeFrom);
        }

        public Reservation GetReservation(int id)
        {
            return context.Reservations.Find(id);
        }

        public IEnumerable<Reservation> GetAllReservationsByUserId(string id)
        {
            return context.Reservations.Where(r => r.UserId == id).OrderByDescending(r=>r.TimeFrom);
        }

        public Reservation DeleteReservation(int id)
        {
            Reservation res = context.Reservations.Find(id);
            if (res != null)
            {
                context.Reservations.Remove(res);
                context.SaveChanges();
            }
            return res;
        }
    }
}
