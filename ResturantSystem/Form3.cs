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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();


            // Attach the FormClosing event handler to the FormClosing event
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Get the user input from the form controls
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            DateTime reservationDate = dtpReservationDate.Value;
            string reservationTime = cmbReservationTime.SelectedItem.ToString();
            int numGuests = (int)numNumGuests.Value;

            // Validate the user input
            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Please fill in all the required fields.");
                return;
            }

            // Save the reservation data to a database or file, or send it to an API
            // ...

            // Display a confirmation message to the user
            MessageBox.Show("Thank you for your reservation!");
            this.Close();
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void Form3_Leave(object sender, EventArgs e)
        {



        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }
            }
        }





    }
}
