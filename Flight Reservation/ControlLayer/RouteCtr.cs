using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flight_Reservation.DataLayer;
using Flight_Reservation.Algrithm;

namespace Flight_Reservation.ControlLayer
{
    class RouteCTR
    {
        private DBRoute dbr;
        private DBAirport dba;

        public RouteCTR()
        {
            dbr = new DBRoute();
            dba = new DBAirport();
        }

        public Route FindRoute(int routeNo)
        {
            return dbr.GetRoute(routeNo);
        }

        public Airport FindAirport(string airportCode)
        {
            return dba.GetAirport(airportCode);
        }
    }
}
