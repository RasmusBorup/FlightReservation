using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Reservation.DataLayer
{
    public class DBCustomer
    {
        private DBConnectionDataContext db;

        public DBCustomer()
        {
            db = new DBConnectionDataContext();
        }

        //Finds a customer in the database using a LINQ representation of the customer table
        public Customer FindCustomer(int customerNo) 
        {
            Customer customer = new Customer();
            try
            {
                TblCustomer cust = db.TblCustomers.SingleOrDefault(c => c.CustomerNo == customerNo);

                customer.FName = cust.FName;
                customer.LName = cust.LName;
                customer.Address = cust.Address;
                customer.CustomerNo = cust.CustomerNo;
                customer.Email = cust.Email;
                customer.PhoneNo = cust.PhoneNo;
                customer.PostalCode = cust.PostalCode;

            }
            catch (NullReferenceException nullreferenceCustomer)
            {
                Console.WriteLine(nullreferenceCustomer);
                //throw new NullReferenceException("The customer wasn't found.", nullreferenceCustomer);
            }
            return customer;
        }

        public int SaveCustomer(Customer customer)
        {
            TblCustomer tblCustomer = new TblCustomer();

            tblCustomer.Address = customer.Address;
            tblCustomer.Email = customer.Email;
            tblCustomer.FName = customer.FName;
            tblCustomer.LName = customer.LName;
            tblCustomer.PhoneNo = customer.PhoneNo;
            tblCustomer.PostalCode = customer.PostalCode;

            db.TblCustomers.InsertOnSubmit(tblCustomer);

            try
            {
                db.SubmitChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            return tblCustomer.CustomerNo;
        }

        public Customer FindByPhone(string phoneNo)
        {
            Customer customer = new Customer();
            try
            {
                var cust = db.TblCustomers.SingleOrDefault(c => c.PhoneNo.Equals(phoneNo));

                customer.FName = cust.FName;
                customer.LName = cust.LName;
                customer.Address = cust.Address;
                customer.CustomerNo = cust.CustomerNo;
                customer.Email = cust.Email;
                customer.PhoneNo = phoneNo;
                customer.PostalCode = cust.PostalCode;
            }
            catch (NullReferenceException nullreferenceCustomer)
            {
                Console.WriteLine(nullreferenceCustomer);
                //throw new NullReferenceException("The customer wasn't found.", nullreferenceCustomer);
            }
            return customer;
        }
    }
}
