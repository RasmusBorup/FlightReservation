using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Reservation.DataLayer
{
    public class ReservationDB
    {
        private DBConnectionDataContext db;

        public ReservationDB()
        {
            db = new DBConnectionDataContext();
        }

        public Reservation GetReservation(int reservationNo)
        {
            Reservation reservation = new Reservation();
            var res = db.TblReservations.SingleOrDefault(r => r.ReservationNo == reservationNo);

            reservation.ReservationNo = res.ReservationNo;
            reservation.TotalPrice = res.TotalPrice;
            reservation.Customer.CustomerNo = res.CustomerNo;
            reservation.Amount = res.Amount;

            return reservation;
        }

        public void SaveReservation(Reservation reservation)
        {
            TblReservation tblReservation = new TblReservation();

            tblReservation.ReservationNo = reservation.ReservationNo;
            tblReservation.TotalPrice = reservation.TotalPrice;
            tblReservation.CustomerNo = reservation.Customer.CustomerNo;
            tblReservation.Amount = reservation.Amount;

            db.TblReservations.InsertOnSubmit(tblReservation);

            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}
