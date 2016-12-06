using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Reservation.DataLayer
{
    public class DBReservation
    {
        private DBConnectionDataContext db;
        private DBCustomer dbc;
        private DBFlight dbf;
        
        public DBReservation()
        {
            db = new DBConnectionDataContext();
            dbc = new DBCustomer();
            dbf = new DBFlight();
        }

        public Reservation FindReservation(int reservationNo)
        {
            Reservation reservation = new Reservation();
            var res = db.TblReservations.SingleOrDefault(r => r.ReservationNo == reservationNo);

            try
            {
                reservation.Amount = res.Amount;
                reservation.Customer = dbc.FindCustomer(res.CustomerNo);
                reservation.ReservationNo = res.ReservationNo;
                reservation.TotalPrice = res.TotalPrice;

                foreach (int flightNo in FindPartReservations(reservationNo))
                {
                    reservation.AddFlight(dbf.FindFlight(flightNo));
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Couldn't find the reservation");
            }
            return reservation;
        }

        private List<int> FindPartReservations(int reservationNo)
        {
            List<int> flightNos = new List<int>();

            //FROM PartReservations SELECT * WHERE ReservationNo == reservationNo
            foreach (TblPartReservation tblPartRes in db.TblPartReservations.Where(p => p.ReservationNo == reservationNo))
            {
                flightNos.Add(tblPartRes.FlightNo);
            }
            return flightNos;
        }

        public int SaveReservation(Reservation reservation)
        {
            TblReservation tblRes = new TblReservation();
            tblRes.Amount = reservation.Amount;
            tblRes.CustomerNo = reservation.Customer.CustomerNo;
            tblRes.TotalPrice = reservation.TotalPrice;

            try
            {
                db.TblReservations.InsertOnSubmit(tblRes);
                db.SubmitChanges();
                SavePartReservations(reservation, tblRes.ReservationNo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return tblRes.ReservationNo;
        }

        private void SavePartReservations(Reservation reservation, int reservationNo)
        {

            foreach (int flightNo in reservation.FindFlights())
            {
                TblPartReservation tblPartRes = new TblPartReservation();
                tblPartRes.ReservationNo = reservationNo;
                tblPartRes.FlightNo = flightNo;

                db.TblPartReservations.InsertOnSubmit(tblPartRes);
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
}
