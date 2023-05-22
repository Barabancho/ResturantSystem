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
        private int capacity;
        private string fname;
        private string lname;
        private string email;
        private string phonenumber;

        public Reservations(string reservation_date, int capacity, string fname, string lname, string email, string phonenumber)
        {
            this.reservation_date = reservation_date;
            this.capacity = capacity;
            this.fname = fname;
            this.lname = lname;
            this.email = email;
            this.phonenumber = phonenumber;
        }
        public Reservations()
        {
        }

        public int Reservation_id { get => reservation_id; set => reservation_id = value; }
        public string Reservation_date { get => reservation_date; set => reservation_date = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public string Fname { get => fname; set => fname = value; }
        public string Lname { get => lname; set => lname = value; }
        public string Email { get => email; set => email = value; }
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }
    }
}
