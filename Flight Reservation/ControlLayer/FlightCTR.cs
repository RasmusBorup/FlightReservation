using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flight_Reservation.Algorith_Rasmus;
using Flight_Reservation.DataLayer;

namespace Flight_Reservation.ControlLayer
{
    public class FlightCTR
    {
        private DBFlight dbf;
        private DBSeat dbs;
        private RouteCTR rCTR;
        private Dijkstras dijkstras;

        public FlightCTR()
        {
            dbf = new DBFlight();
            dbs = new DBSeat();
            rCTR = new RouteCTR();
            dijkstras = new Dijkstras();
        }

        public Flight FindFlight(int flightNo)
        {
            return dbf.FindFlight(flightNo);
        }

        public List<Seat> FindFlightSeats(int flightNo)
        {
            return dbs.FlightSeats(flightNo);
        }

        public List<Flight> CalculateFlights(string from, string destination, int maxLayovers, string date, string time, int seatAmount)
        {
            Console.WriteLine("Starting CalculateFlights in FlightController");
            List<Flight> flights = new List<Flight>();
            Airport start = rCTR.FindAirport(from);
            Airport end = rCTR.FindAirport(destination);
            try
            {
                CultureInfo ci = CultureInfo.CreateSpecificCulture("da-DK"); // Creates a CultureInfo needed to parse Strings to Datetime.
                List<Route> routes = dijkstras.FindCheapestPath(start, end, maxLayovers);
                flights.Add(dbf.FlightsAfter(routes.First().RouteNo, date, time, seatAmount));

                int index = 1;
                while(routes.Count > 1 && index < routes.Count)
                {
                    flights.Add(dbf.FlightsAfter(routes.ElementAt(index).RouteNo, flights.Last().ArrivalDate, flights.Last().ArrivalTime, seatAmount));
                    index++;
                }
            }
            catch (FormatException flightDepartureFormatException)
            {

            }
            return flights;
        }

        public void UpdateFlight(int flightNo, int seatAmount)
        {
            dbf.UpdateFlight(flightNo, seatAmount);
        }
    }
}
