using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Reservation.DataLayer
{
    public class Seat
    {
        public int FlightNo { get; set; }
        public bool Reserved { get; set; }
        public int SeatNo { get; set; }
        public int SeatRow { get; set; }

        public Seat(bool reserved, int seatNo, int seatRow)
        {
            this.Reserved = reserved;
            this.SeatNo = seatNo;
            this.SeatRow = seatRow;
        }

        public Seat()
        {
            Reserved = false;
            SeatNo = 0;
            SeatRow = 0;
        }
    }
}
