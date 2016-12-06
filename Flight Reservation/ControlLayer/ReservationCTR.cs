using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flight_Reservation.DataLayer;

namespace Flight_Reservation.ControlLayer
{
    public class ReservationCTR
    {
        private DBReservation dbr;
        private CustomerCTR cCTR;
        private FlightCTR fCTR;
        public ReservationCTR()
        {
            dbr = new DBReservation();
            cCTR = new CustomerCTR();
            fCTR = new FlightCTR();
        }

        public int CreateReservation(int amount, int customerNo, string from, string destination, int maxLayovers, string date, string time)
        {
            Reservation reservation = new Reservation(amount, cCTR.FindCustomer(customerNo));
            AddFlights(reservation, from, destination, maxLayovers, date, time, amount);
            return dbr.SaveReservation(reservation);
        }

        private void AddFlights(Reservation reservation, string from, string destination, int maxLayovers, string date, string time, int amount)
        {
            List<Flight> flights = fCTR.CalculateFlights(from, destination, maxLayovers, date, time, amount);
            foreach(Flight flight in flights)
            {
                reservation.AddFlight(flight);
                if (flight.FlightNo > 0)
                {
                    fCTR.UpdateFlight(flight.FlightNo, amount);
                }
            }
        }

        public Reservation FindReservation(int reservationNo)
        {
            return dbr.FindReservation(reservationNo);
            
        }
    }
}
