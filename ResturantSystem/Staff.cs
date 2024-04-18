using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantSystem
{
    public class Staff
    {
        private int staff_id;
        private string fname;
        private string lname;
        private string email;
        private string phone_number;
        private string position;

        public Staff(string fname, string lname, string email, string phone_number, string position)
        {
            this.fname = fname;
            this.lname = lname;
            this.email = email;
            this.phone_number = phone_number;
            this.position = position;
        }
        public Staff()
        {
            this.fname = "";
            this.lname = "";
            this.email = "";
            this.phone_number = "";
            this.position = "";
        }

        public int Staff_id { get => staff_id; set => staff_id = value; }
        public string Fname { get => fname; set => fname = value; }
        public string Lname { get => lname; set => lname = value; }
        public string Email { get => email; set => email = value; }
        public string Phone_number { get => phone_number; set => phone_number = value; }
        public string Position { get => position; set => position = value; }
    }
}
