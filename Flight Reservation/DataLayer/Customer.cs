using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Reservation.DataLayer
{
    public class Customer
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int PostalCode { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public int CustomerNo { get; set; }//Is set by the database

        public Customer(string fName, string lName, string address, int postalCode, string phoneNo, string email)
        {
            FName = fName;
            LName = lName;
            Address = address;
            PostalCode = postalCode;
            PhoneNo = phoneNo;
            Email = email;
        }

        public Customer()
        {

        }
    }
}
