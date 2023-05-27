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
        private string username;
        private string email;
        private string phone_number;
        private string role;
        private string password;

        public int Boss_id { get => boss_id; set => boss_id = value; }
        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Phone_number { get => phone_number; set => phone_number = value; }
        public string Role { get => role; set => role = value; }
        public string Password { get => password; set => password = value; }

        public Boss(string uername, string email, string phone_number, string role, string pasword)
        {
            this.username = uername;
            this.email = email;
            this.phone_number = phone_number;
            this.role = role;
            this.password = pasword;
        }
        public Boss()
        {
        }
    }
}
