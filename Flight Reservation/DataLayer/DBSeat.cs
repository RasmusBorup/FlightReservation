using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Reservation.DataLayer
{
    public class DBSeat
    {
        private DBConnectionDataContext db;

        public DBSeat()
        {
            db=new DBConnectionDataContext();
        }

        public Seat FindSeat(int flightNo, int seatNo, int rowNo)
        {
            Seat seat = new Seat();
            TblSeat tblSeat = db.TblSeats.SingleOrDefault(s => s.FlightNo == flightNo && seat.SeatNo == seatNo && seat.SeatRow == rowNo);

            seat.FlightNo = tblSeat.FlightNo;
            seat.Reserved = tblSeat.Reserved;
            seat.SeatNo = tblSeat.SeatNo;
            seat.SeatRow = tblSeat.RowNo;

            return seat;
        }

        public List<Seat> FlightSeats(int flightNo)
        {
            List<Seat> seats = new List<Seat>();

            foreach(TblSeat tblSeat in db.TblSeats.Where(s => s.FlightNo == flightNo))
            {
                Seat seat = new Seat();
                seat.FlightNo = tblSeat.FlightNo;
                seat.Reserved = tblSeat.Reserved;
                seat.SeatRow = tblSeat.RowNo;
                seat.SeatNo = tblSeat.SeatNo;

                seats.Add(seat);
            }

            return seats;
        }
    }
}
