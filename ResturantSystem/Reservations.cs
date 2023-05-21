using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantSystem
{
    public class Reservations
    {
        private int reservation_id;
        private string reservation_date;

        public Reservations(string reservation_date)
        {
            this.Reservation_date = reservation_date;
        }
        public Reservations()
        {
        }
        public int Reservation_id { get => reservation_id; set => reservation_id = value; }
        public string Reservation_date { get => reservation_date; set => reservation_date = value; }
    }
}
