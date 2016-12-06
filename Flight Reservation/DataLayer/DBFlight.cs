using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Reservation.DataLayer
{
    public class DBFlight
    {
        private DBConnectionDataContext db;
        private DBSeat dbs;
        private DBRoute dbr;

        public DBFlight()
        {
            db = new DBConnectionDataContext();
            dbs = new DBSeat();
            dbr = new DBRoute();
        }

        public Flight FindFlight(int flightNo)
        {
            Flight flight = new Flight();
            var tblFlight = db.TblFlights.SingleOrDefault(f => f.FlightNo == flightNo);

            flight.ArrivalDate = tblFlight.ArrivalDate.ToShortDateString();
            flight.ArrivalTime = tblFlight.ArrivalTime.ToString();
            flight.DepartureTime = tblFlight.DepartureTime.ToString();
            flight.DepartureDate = tblFlight.DepartureDate.ToShortDateString();
            flight.FlightNo = tblFlight.FlightNo;
            flight.ReservedSeats = tblFlight.ReservedSeats;
            flight.TotalSeats = tblFlight.TotalSeats;
            flight.SeatCounter();
            foreach (Seat seat in dbs.FlightSeats(flightNo))
            {
                flight.AddSeat(seat);
            }
            flight.Route = dbr.GetRoute(tblFlight.RouteNo);

            return flight;
        }

        public Flight FlightsAfter(int routeNo, string date, string time, int seatAmount)
        {
            Console.WriteLine("Running flightsafter in dbflight");
            Flight flight = new Flight();
            try
            {
                string checkString = date + " " + time;
                CultureInfo ci = CultureInfo.CreateSpecificCulture("da-DK"); // Creates a CultureInfo needed to parse Strings to Datetime.
                DateTime checkDeparture = DateTime.ParseExact(checkString, "dd-MM-yyyy HH:mm:ss", ci); // Converts string to Datetime so they can be compared.

                DateTime flightDeparture = checkDeparture.AddMonths(1);
                checkDeparture = checkDeparture.AddMinutes(30);
                foreach (TblFlight tblFlight in db.TblFlights.Where(f => f.RouteNo == routeNo)) // Finds flights with matching route numbers.
                {

                    string flightString = flight.DepartureDate + " " + flight.DepartureTime;
                    if (flightString != " ")
                    {
                        flightDeparture = DateTime.ParseExact(flightString, "dd-MM-yyyy HH:mm:ss", ci);
                    }
                    string sqlString = tblFlight.DepartureDate.ToShortDateString() + " " + tblFlight.DepartureTime;
                    DateTime sqlDeparture = DateTime.ParseExact(sqlString, "dd-MM-yyyy HH:mm:ss", ci); // Converts string to Datetime so they can be compared.
                    if (checkDeparture.CompareTo(sqlDeparture) < 0 && sqlDeparture.CompareTo(flightDeparture) < 0 && (tblFlight.TotalSeats - tblFlight.ReservedSeats) >= seatAmount) // Checks wether the matching flights have a departure later than the specified date.
                    {
                        flight = FindFlight(tblFlight.FlightNo);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return flight;
        }

        public void UpdateFlight(int flightNo, int seatAmount)
        {
            var tblFlight = db.TblFlights.SingleOrDefault(f => f.FlightNo == flightNo);

            tblFlight.ReservedSeats = tblFlight.ReservedSeats + seatAmount;

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
