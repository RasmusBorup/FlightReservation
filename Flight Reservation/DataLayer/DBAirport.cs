using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Reservation.DataLayer
{
    public class DBAirport
    {
      private DBConnectionDataContext db;

        public DBAirport()
        {
            db = new DBConnectionDataContext();
        }

        public Airport GetAirport(string airportCode)
        {
            Airport airport = new Airport();
            var airp = db.TblAirports.SingleOrDefault(a => a.AirportCode.Equals(airportCode));

            airport.AirportCode = airp.AirportCode;
            airport.Name = airp.Name;
            airport.Country = airp.Country;
            airport.City = airp.City;

            return airport;
        }

        public List<Airport> GetAllAirports()
        {
            Airport airport = new Airport();
            List<Airport> airports = new List<Airport>();
            int index = 0;
            while (index <= db.TblAirports.Count())
            {
                var airp = db.TblAirports.SingleOrDefault(a => a.AirportCode.Equals(index));

                airport.AirportCode = airp.AirportCode;
                airport.Name = airp.Name;
                airport.Country = airp.Country;
                airport.City = airp.City;

                airports.Add(airport);

                index++;
            }
            return airports;
        }
    }
}
