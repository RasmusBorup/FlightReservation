using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flight_Reservation.DataLayer;

namespace Flight_Reservation.ControlLayer
{
    class CustomerCTR
    {
        private DBCustomer DBCust;

        public CustomerCTR()
        {
            DBCust = new DataLayer.DBCustomer();
        }

        //Utilizes the DBCustomer to find a customer based on the customer.
        public Customer FindCustomer(int customerNo)
        {
            return DBCust.FindCustomer(customerNo);
        }

        //Utilizes the DBCustomer to save a customer.
        public int CreateCustomer(string fName, string lName, string address, int postalCode, string phoneNo, string email)
        {
            DataLayer.Customer cust = new DataLayer.Customer();
            cust.Address = address;
            cust.Email = email;
            cust.FName = fName;
            cust.LName = lName;
            cust.PhoneNo = phoneNo;
            cust.PostalCode = postalCode;

            return DBCust.SaveCustomer(cust);
        }

        public Customer FindCustomerByPhone(string phoneNo)
        {
            return DBCust.FindByPhone(phoneNo);
        }
    }
}
