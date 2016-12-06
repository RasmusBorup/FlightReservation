using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Flight_Reservation.ControlLayer;
using Flight_Reservation.DataLayer;

namespace Flight_Reservation.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class FlightCaseService : IFlightCaseService
    {

        private CustomerCTR customerCTR = new CustomerCTR();
        private ReservationCTR reservationCTR = new ReservationCTR();
        private FlightCTR flightCTR = new FlightCTR();

        public int CreateReservation(int amount, int customerNo, string from, string destination, int maxLayovers, string date, string time)
        {
            int reservationNo = 0;
            try
            {
                reservationNo = reservationCTR.CreateReservation(amount, customerNo, from, destination, maxLayovers, date, time);
            }
           catch(Exception e)
            {
               Console.WriteLine("Christian ødelagde det" + e);
            }
            return reservationNo;
        }

        public Reservation FindReservaton(int reservationNo)
        {
            Reservation reservation = reservationCTR.FindReservation(reservationNo);
            return reservation;
        }

        public List<Flight> FindReservationFlights(int reservationNo)
        {
            return FindReservaton(reservationNo).GetFlights();
        }

        public int CreateCustomer(string fName, string lName, string address, int postalCode, string phoneNo, string email)
        {
            return customerCTR.CreateCustomer(fName, lName, address, postalCode, phoneNo, email);
        }

        public Customer FindCustomer(int customerNo)
        {
            return customerCTR.FindCustomer(customerNo);
        }

        public List<Flight> FindFlights(string from, string destination, int maxLayovers, string date, string time, int seatAmount)
        {
            List<Flight> flights = new List<Flight>();
            try
            {
                flights = flightCTR.CalculateFlights(from, destination, maxLayovers, date, time, seatAmount);
            }
            catch (Exception)
            {
            }
            return flights;
        }


        public Customer FindCustomerByPhone(string phoneNo)
        {
            return customerCTR.FindCustomerByPhone(phoneNo);
        }
    }
}
