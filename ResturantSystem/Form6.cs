using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResturantSystem
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // Access the reservation data from Form3
            string firstName = Reservation.FirstName;
            string lastName = Reservation.LastName;
            string email = Reservation.Email;
            string phone = Reservation.Phone;
            string reservationDate = Reservation.ReservationDate;
            string reservationTime = Reservation.ReservationTime;

            // Use the reservation data as needed
            // ...




        }
    }
}

