using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Reservation.DataLayer
{
    public class Airport
    {
        public string AirportCode { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public Airport(string name, string city, string country)
        {
            this.Name = name;
            this.City = city;
            this.Country = country;
        }

        public Airport()
        {
        }
    }
}
