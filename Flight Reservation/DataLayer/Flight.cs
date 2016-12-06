using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Reservation.DataLayer
{
    public class Flight
    {
        public int FlightNo { get; set; }//Is set by the database
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        public string DepartureDate { get; set; }
        public string ArrivalDate { get; set; }
        public int TotalSeats { get; set; }
        public int ReservedSeats { get; set; }
        public Route Route { get; set; }
        private List<Seat> seats; 

        public Flight(string departureTime, string arrivalTime, string departuretDate, string arrivalDate, int totalSeats, int reservedSeats, Route route)
        {
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            DepartureDate = departuretDate;
            ArrivalDate = arrivalDate;
            TotalSeats = totalSeats;
            ReservedSeats = reservedSeats;
            Route = route;
            seats = new List<Seat>();
        }

        public Flight()
        {
            seats = new List<Seat>();
        }

        public void AddSeat(Seat s)
        {
            seats.Add(s);
        }

        public int SeatCounter()
        {
            return TotalSeats - ReservedSeats;
        }

        //public void GetTotalSeats()
        //{
        //    TotalSeats = seats.Count();
        //}

        //public void GetReservedSeats()
        //{
        //    for (int i = 0; i < seats.Count; i++)
        //    {
        //        if (seats[i].Reserved == true)
        //        {
        //            ReservedSeats++;
        //        }
        //    }
        //}
    }
}
