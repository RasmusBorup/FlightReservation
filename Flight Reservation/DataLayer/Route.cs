using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Reservation.DataLayer
{
    public class Route
    {
        public int RouteNo { get; set; }//Is set by the database
        public double Price { get; set; }
        public Airport StartAirport { get; set; }
        public Airport EndAirport { get; set; }

        public Route(Airport startAirport, Airport endAirport, double price)
        {
            this.StartAirport = startAirport;
            this.EndAirport = endAirport;
            Price = price;
        }

        public Route()
        {
            StartAirport = null;
            EndAirport = null;
        }
    }
}
