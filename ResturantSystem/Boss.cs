using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantSystem
{
    public class Boss
    {
        private int boss_id;
        private string uername;
        private string email;
        private string phone_number;
        private string role;
        private string pasword;

        public int Boss_id { get => boss_id; set => boss_id = value; }
        public string Uername { get => uername; set => uername = value; }
        public string Email { get => email; set => email = value; }
        public string Phone_number { get => phone_number; set => phone_number = value; }
        public string Role { get => role; set => role = value; }
        public string Pasword { get => pasword; set => pasword = value; }

        public Boss(string uername, string email, string phone_number, string role, string pasword)
        {
            this.uername = uername;
            this.email = email;
            this.phone_number = phone_number;
            this.role = role;
            this.pasword = pasword;
        }
        public Boss()
        {
        }
    }
}
