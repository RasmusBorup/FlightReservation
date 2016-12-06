using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Reservation.DataLayer
{
    public class Reservation
    {
        public int ReservationNo { get; set; }//Is set by the database
        public double TotalPrice { get; set; }
        public int Amount { get; set; }
        public Customer Customer { get; set; }
        private List<Flight> flights;

        public Reservation(int amount, Customer customer)
        {
            Amount = amount;
            Customer = customer;
            flights = new List<Flight>();
        }

        public Reservation()
        {
            flights = new List<Flight>();
        }

        //Adds a flight to the reservation and recalculates the total price using CalculateTotalPrice()
        public void AddFlight(Flight flight)
        {
            flights.Add(flight);
            CalculateTotalPrice();
        }

        //Calculates the total price of the reservation, all flights included
        private void CalculateTotalPrice()
        {
            TotalPrice = 0;
            
            foreach(Flight flight in flights)
            {
                TotalPrice += flight.Route.Price;
            }
            TotalPrice *= Amount;
        }

        public List<Flight> GetFlights()
        {
            return flights;
        }

        public List<int> FindFlights()
        {
            List<int> flightNos = new List<int>();
            for(int i = 0; i < flights.Count; i++)
            {
                flightNos.Add(flights[i].FlightNo);
            }
            return flightNos;
        }
    }
}
