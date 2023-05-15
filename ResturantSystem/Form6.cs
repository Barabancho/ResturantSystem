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
            string firstName = Form3.FirstName;
            string lastName = Form3.LastName;
            string email = Form3.Email;
            string phone = Form3.Phone;
            string reservationDate = Form3.ReservationDate;
            string reservationTime = Form3.ReservationTime;

            // Use the reservation data as needed
            // ...
        }
    }
}
