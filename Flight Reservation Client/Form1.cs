using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_Reservation_Client
{
    public partial class Form1 : Form
    {
        private FlightServiceReference.IFlightCaseService fcs;
        private int customerNo;
        public Form1()
        {
            InitializeComponent();
            MakePrettyDataGridView();//Adds 11 empty rows to the table so it isn't as empty and sad on creation
            ResetrtbCustomerInfo();
            ClearReservationTab();
            fcs = new FlightServiceReference.FlightCaseServiceClient();
            customerNo = 0;
            lblCustomerNo.ForeColor = System.Drawing.Color.Red;            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string fName = txtFirst.Text;
            string lName = txtLast.Text;
            string address = txtAdd.Text;
            int postalCode = 0;
            try
            {
                postalCode = Convert.ToInt32(txtPost.Text);
                string phone = txtPhone.Text;
                string email = txtMail.Text;
                if (fName != "" && lName != "" && address != "" && phone != "" && email != "")
                {
                    if (postalCode > 999)
                    {
                        customerNo = fcs.CreateCustomer(fName, lName, address, postalCode, phone, email);
                        lblCustomerNo.Text = "Customer: " + fName + " " + lName;
                        lblCustomerSuccess.Text = "Customer registered successfully!";
                    }
                    else
                    {
                        MessageBox.Show("Postal code must be at least 4 digits long");
                    }
                }
                else
                {
                    MessageBox.Show("No fields can be empty");
                }
            }
            catch (FormatException ConversionFormatException)
            {
                MessageBox.Show("Postal code must be a possitive number");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ResetrtbCustomerInfo();
            string phoneNo = txtSearchPhone.Text;
            Flight_Reservation.DataLayer.Customer customer = fcs.FindCustomerByPhone(phoneNo);
            if (customer.CustomerNo != 0)
            {
                rtbCustomerInfo.Text = "Customer Number: " + customer.CustomerNo + Environment.NewLine;
                rtbCustomerInfo.Text += "First name: " + customer.FName + Environment.NewLine;
                rtbCustomerInfo.Text += "Last name: " + customer.LName + Environment.NewLine;
                rtbCustomerInfo.Text += "Address: " + customer.Address + Environment.NewLine;
                rtbCustomerInfo.Text += "Postal Code: " + customer.PostalCode + Environment.NewLine;
                rtbCustomerInfo.Text += "Phone Number: " + customer.PhoneNo + Environment.NewLine;
                rtbCustomerInfo.Text += "Email: " + customer.Email + Environment.NewLine;

                customerNo = customer.CustomerNo;
                if(customerNo > 0)
                {
                    lblCustomerNo.ForeColor = System.Drawing.Color.Black;
                }
                lblCustomerNo.Text = "Customer: " + customer.FName + " " + customer.LName;
            }
            else
            {
                MessageBox.Show("No customer with the given phone number was found");
            }
        }

        private void ResetrtbCustomerInfo()
        {
            rtbCustomerInfo.Clear();
            rtbCustomerInfo.Text = "First name: " + Environment.NewLine;
            rtbCustomerInfo.Text += "Last name: " + Environment.NewLine;
            rtbCustomerInfo.Text += "Address: " + Environment.NewLine;
            rtbCustomerInfo.Text += "Postal Code: " + Environment.NewLine;
            rtbCustomerInfo.Text += "Phone Number: " + Environment.NewLine;
            rtbCustomerInfo.Text += "Email: " + Environment.NewLine;
        }

        private void btnFindFlights_Click(object sender, EventArgs e)
        {
            ClearDataGridView();
            int amount = 0;
            string from = tbStart.Text;
            string destination = tbDestination.Text;
            int maxLayovers = 1000;//So if maximum layovers is left empty the algorithm will find the cheapest route of all with a maximum of 1000 layovers
            if (from != "" && destination != "")
            {
                try
                {
                    amount = Convert.ToInt16(tbSeats.Text);
                }
                catch (FormatException seatAmountFormatException)
                {
                    MessageBox.Show("Seats must be a number");
                }
                if (tbMaxLayovers.Text != "")
                {
                    try
                    {
                        maxLayovers = Convert.ToInt16(tbMaxLayovers.Text);
                    }
                    catch (FormatException maxLayoversFormatException)
                    {
                        MessageBox.Show("Maximum layovers must be a positive number or left empty");
                    }
                }
                string date = tbDate.Text;
                string time = tbTime.Text + ":00";//We probably should make checks on date and time for their format
                if (amount > 0)
                {
                    Flight_Reservation.DataLayer.Flight[] flights = fcs.FindFlights(from, destination, maxLayovers, date, time, amount);
                    if (flights.Count() > 0 && flights[0].FlightNo != 0)
                    {
                        ShowFlightsInTable(flights);
                        double totalPrice = 0;
                        foreach(Flight_Reservation.DataLayer.Flight flight in flights)
                        {
                            totalPrice += flight.Route.Price;
                        }
                        tbTotalPrice.Text = totalPrice.ToString();
                        if (customerNo != 0)
                        {
                            btnCreateReservation.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Couldn't find flights with the given requirements");
                        tbTotalPrice.Text = "";//We should not clear the whole tab as the user should be able to see what they have typed in
                    }

                }
                else
                {
                    MessageBox.Show("Seats must be a possitive number");
                    tbTotalPrice.Text = "";//We should not clear the whole tab as the user should be able to see what they have typed in
                }
            }
            else
            {
                MessageBox.Show("No fields can be empty");
                tbTotalPrice.Text = "";//We should not clear the whole tab as the user should be able to see what they have typed in
            }
        }

        private void btnSearchReservation_Click(object sender, EventArgs e)
        {
            ClearDataGridView();

            try
            {
                int reservationNo = 0;
                reservationNo = Convert.ToInt32(tbReservationNo.Text);
                if (reservationNo > 0 && fcs.FindReservationFlights(reservationNo).Count() != 0)
                {
                    Flight_Reservation.DataLayer.Flight[] flights = fcs.FindReservationFlights(reservationNo);
                    ShowFlightsInTable(flights);
                }
                else if (fcs.FindReservationFlights(reservationNo).Count() == 0)
                {
                    MessageBox.Show("No reservation was found with the given reservation number.");
                }
                else
                {
                    MessageBox.Show("Reservation number must be a positive number");
                }
            }
            catch (FormatException reservationNoFormatException)
            {
                MessageBox.Show("Reservation number must be a positive number");
            }
        }

        private void btnCreateReservation_Click(object sender, EventArgs e)
        {
            int amount = 0;
            string from = tbStart.Text;
            string destination = tbDestination.Text;
            int maxLayovers = 1000;//So if maximum layovers is left empty the algorithm will find the cheapest route of all with a maximum of 1000 layovers
            if (customerNo != 0)
            {
                if (from != "" && destination != "") //Vi behøver ikke tjekke for andet da det bør tjekkes inden
                {
                    try
                    {
                        amount = Convert.ToInt16(tbSeats.Text);
                    }
                    catch (FormatException seatAmountFormatException)
                    {
                        MessageBox.Show("Seats must be a number");
                    }
                    if (tbMaxLayovers.Text != "")
                    {
                        try
                        {
                            maxLayovers = Convert.ToInt16(tbMaxLayovers.Text);
                        }
                        catch (FormatException maxLayoversFormatException)
                        {
                            MessageBox.Show("Maximum layovers must be a positive number or left empty");
                        }
                    }
                    string date = tbDate.Text;
                    string time = tbTime.Text + ":00";                  
                    if (amount > 0)
                    {
                        
                        int reservationNo = fcs.CreateReservation(amount, customerNo, from, destination, maxLayovers,
                            date,
                            time);
                        customerNo = 0;
                        lblCustomerNo.Text = "No customer selected";
                        lblCustomerNo.ForeColor = System.Drawing.Color.Red;
                        ClearReservationTab();
                        if (reservationNo > 0)
                        {
                            lblReservationSuccess.Text = "Reservation created successfully. Reservation number: " + reservationNo;
                            ShowFlightsInTable(fcs.FindReservationFlights(reservationNo));
                        }
                        else
                        {
                            lblReservationSuccess.Text = "Couldn't make the reservation.";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seats must be a possitive number");
                    }
                }
                else
                {
                    MessageBox.Show("No fields can be empty");
                }
            }
            else
            {
                MessageBox.Show("You must select a customer to create a reservation");
            }
        }

        private void ShowFlightsInTable(Flight_Reservation.DataLayer.Flight[] flights)
        {
            for (int i = 0; i < flights.Count(); i++)
            {
                dgvPartReservations.Rows[i].SetValues(flights[i].Route.StartAirport.Name,
                    flights[i].Route.EndAirport.Name, flights[i].DepartureDate, flights[i].DepartureTime,
                    flights[i].ArrivalDate, flights[i].ArrivalTime, flights[i].FlightNo, flights[i].Route.Price);
            }
        }

        private void MakePrettyDataGridView()
        {
            for (int i = 0; i < 11; i++)//Adds 11 empty rows to the table so it isn't as empty and sad on creation
            {
                dgvPartReservations.Rows.Add("", "", "", "", "", "", "", "");
            }
        }

        private void ClearDataGridView()
        {
            for (int i = 0; i < dgvPartReservations.RowCount; i++)
            {
                dgvPartReservations.Rows[i].SetValues("", "", "", "", "", "", "", "");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            ClearReservationTab();
        }

        private void btnReservationBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            customerNo = 0;
            ClearReservationTab();
            lblCustomerNo.Text = "No customer selected";
            lblCustomerNo.ForeColor = System.Drawing.Color.Red;
        }

        private void ClearReservationTab()
        {
            tbDate.Text = DateTime.Today.ToShortDateString();
            tbDestination.Text = "";
            tbMaxLayovers.Text = "";
            tbReservationNo.Text = "";
            tbSeats.Text = "";
            tbStart.Text = "";
            tbTime.Text = DateTime.Now.ToShortTimeString();
            ClearDataGridView();
            tbTotalPrice.Text = "";
            btnCreateReservation.Enabled = false;
        }
    }
}
