using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webapi2.Models
{
   public interface IRepository
    {
        IEnumerable<Reservation> reservations { get; }
        Reservation this[int Id] { get;}
        Reservation AddReservation(Reservation reservation);
        Reservation UpdateReservation(Reservation reservation);
        void DeleteReservation(int Id);
    }
}
