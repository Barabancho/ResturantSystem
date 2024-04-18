using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantSystem
{
    public class EmployeeSchedules
    {
        private int schedule_id;
        private string start_time;
        private string end_time;
        private string day_of_week;
        private string fname;
        private string lname;
        private string email;
        private string phone_number;
        private string position;

        public EmployeeSchedules(string start_time, string end_time, string day_of_week, string fname, string lname, string email, string phone_number, string position)
        {
            this.start_time = start_time;
            this.end_time = end_time;
            this.day_of_week = day_of_week;
            this.fname = fname;
            this.lname = lname;
            this.email = email;
            this.phone_number = phone_number;
            this.position = position;
        }
        public EmployeeSchedules()
        {
        }

        public int Schedule_id { get => schedule_id; set => schedule_id = value; }
        public string Start_time { get => start_time; set => start_time = value; }
        public string End_time { get => end_time; set => end_time = value; }
        public string Day_of_week { get => day_of_week; set => day_of_week = value; }
        public string Fname { get => fname; set => fname = value; }
        public string Lname { get => lname; set => lname = value; }
        public string Email { get => email; set => email = value; }
        public string Phone_number { get => phone_number; set => phone_number = value; }
        public string Position { get => position; set => position = value; }
    }
}
