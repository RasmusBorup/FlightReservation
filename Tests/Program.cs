using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flight_Reservation.DataLayer;
using Flight_Reservation.ControlLayer;
using Flight_Reservation.WCF;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            //DBCustomer dbc = new DBCustomer();
            //DBReservation dbr = new DBReservation();
            DBRoute dbRoute = new DBRoute();
            //DBAirport dba = new DBAirport();
            //DBFlight dbf = new DBFlight();
            //ReservationCTR rCTR = new ReservationCTR();
            //FlightCTR fCTR = new FlightCTR();
            //IFlightCaseService flightService = new FlightCaseService();

            //DBCustomer Test
            //Console.WriteLine(dbc.FindCustomer(1).ToString());
            //Console.WriteLine("Efternavn: " + dbc.FindCustomer(1).LName);
            //Console.WriteLine("Addresse: " + dbc.FindCustomer(1).Address);
            //Console.WriteLine("Postnr: " + dbc.FindCustomer(1).PostalCode);
            //Console.WriteLine("Email: " + dbc.FindCustomer(1).Email);
            //Console.WriteLine("Telefonnr: " + dbc.FindCustomer(1).PhoneNo);
            //Console.WriteLine("Kundenr: " + dbc.FindCustomer(1).CustomerNo);

            //Customer customer = dbc.FindByPhone("5");
            //Console.WriteLine(customer.FName);
            
            //Console.ReadLine();

            //Customer customer = new Customer("Eksempel", "Eksempel", "Eksempelvej 2", 9000, "11223344", "Eksempel@eksempel.dk");
            //Console.WriteLine("Inserting {0} into the database", customer.FName);
            //dbc.SaveCustomer(customer);
            //Console.ReadLine();


            //DBReservation Test
            //Console.WriteLine("Reservation no: " + dbr.FindReservation(1).ReservationNo);
            //Console.WriteLine("Amount of tickets: " + dbr.FindReservation(1).Amount);
            //Console.WriteLine("Reserved by {0} {1}", dbr.FindReservation(1).Customer.FName, dbr.FindReservation(1).Customer.LName);
            //Console.WriteLine("Total Price: " + dbr.FindReservation(1).TotalPrice);
            //Console.ReadLine();

            //Reservation reservation = new Reservation(2, dbc.FindCustomer(1));
            //Route route = new Route();
            //route.RouteNo = 5;
            //Flight flight = new Flight("12:00:00", "12:30:00", "2014-11-3", 60, 5, route);
            //reservation.AddFlight(flight);
            //Console.WriteLine("Inserting reservation by {0} {1} into the database", reservation.Customer.FName, reservation.Customer.LName);
            //dbr.SaveReservation(reservation);//Giver problemer i DBReservation linie 75 "Last()"!!!
            //Console.ReadLine();


            //DBRoute Test
            //Console.WriteLine("Start Airport: " + dbRoute.GetRoute(1).StartAirport.Name);
            //Console.WriteLine("End Airport: " + dbRoute.GetRoute(1).EndAirport.Name);
            //Console.WriteLine("Route No: " + dbRoute.GetRoute(1).RouteNo);
            //Console.WriteLine("Price: " + dbRoute.GetRoute(1).Price);
            //Console.ReadLine();


            //DBAirport Test
            //Console.WriteLine("Airport name: " + dba.GetAirport("EKYT").Name);
            //Console.WriteLine("City: " + dba.GetAirport("EKYT").City);
            //Console.WriteLine("Country: " + dba.GetAirport("EKYT").Country);
            //Console.WriteLine("Airport code: " + dba.GetAirport("EKYT").AirportCode);
            //Console.ReadLine();


            //DBFlight Test
            //Console.WriteLine("Flight date: " + dbf.FindFlight(1).DepartureDate);
            //Console.WriteLine("Flight time: " + dbf.FindFlight(1).DepartureTime);
            //Console.WriteLine("Arrival ime: " + dbf.FindFlight(4).ArrivalTime);
            //Console.WriteLine("Flight no: " + dbf.FindFlight(4).FlightNo);
            //Console.WriteLine("Seats on flight: " + dbf.FindFlight(4).TotalSeats);
            //Console.WriteLine("Number of reserved seats: " + dbf.FindFlight(4).ReservedSeats);
            //Console.WriteLine("Flying from: {0}, To: {1} " + dbf.FindFlight(4).Route.StartAirport.Name, dbf.FindFlight(4).Route.EndAirport.Name);

            //Hele lortet skal sikres for null referencer!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

            //Rasmus Dijkstras test
            //Airport startAirport = dba.GetAirport("LEMD");
            //Airport endAirport = dba.GetAirport("EGPF");
            //Dijkstras test = new Dijkstras();
            //test.FindCheapestPath(startAirport, endAirport, 1);

            //SolutionPath test
            //Route route1 = dbRoute.GetRoute(2);
            //Route route2 = dbRoute.GetRoute(4);
            //Airport airport = dba.GetAirport("EKYT");
            //SolutionPath solution = new SolutionPath(airport);
            //solution.AddRoute(route1);
            //solution.AddRoute(route2);
            //Console.WriteLine(solution.Destination().Name);
            //Console.ReadLine();

            //Save reservation returning reservationNo
            //Console.WriteLine(rCTR.CreateReservation(1, 1, "EKTB", "ENGM", 3, "24-12-2014", "10:00:00"));
            //Console.ReadLine();
            
            //WCF Create reservation
            //Console.WriteLine(flightService.CreateReservation(2, 1, "EKTB", "ENGM", 3, "23-12-2014", "12:00:00"));
            //DBFlight dbf = new DBFlight();
            //dbf.FlightsAfter(1, 14:00:00)
            
            
            
            //DateTime flightDeparture = new DateTime(2014-12-24, 14-30-00);
            //string fl = flightDeparture.ToString("yyyy-MM-dd hh:mm:ss");
            //Console.WriteLine(fl);



            ////Testing reserved seats check.
            //CultureInfo ci = new CultureInfo("da-DK");
            //DateTime test = DateTime.ParseExact("23-12-2014 10:00", "dd-MM-yyyy HH:mm", ci);
            //List<Flight> fs = fCTR.CalculateFlights("EKYT", "LEMD", 1000, "23-12-2014", "10:00", 1);
            //foreach (Flight flight in fs)
            //{
            //    Console.WriteLine(flight.FlightNo);
            //}
            //Console.ReadLine();

            //List<Flight> flights = flightService.FindFlights("EKYT", "LEMD", 4, "23-12-2014", "10:00", 200);
            //foreach (Flight flight in flights)
            //{
            //   Console.WriteLine(flight.FlightNo);
            //}

            
        }
    }
}
