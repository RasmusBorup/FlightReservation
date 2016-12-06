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
    [ServiceContract]
    public interface IFlightCaseService
    {
        [OperationContract]
        int CreateReservation(int amount, int customerNo, string from, string destination, int maxLayovers, string date, string time);

        [OperationContract]
        Reservation FindReservaton(int reservationNo);

        [OperationContract]
        List<Flight> FindReservationFlights(int reservationNo);

        [OperationContract]
        int CreateCustomer(string fName, string lName, string address, int postalCode, string phoneNo, string email);

        [OperationContract]
        Customer FindCustomer(int customerNo);

        [OperationContract]
        List<Flight> FindFlights(string from, string destination, int maxLayovers, string date, string time, int seatAmount);

        [OperationContract]
        Customer FindCustomerByPhone(string phoneNo);
    }
}
