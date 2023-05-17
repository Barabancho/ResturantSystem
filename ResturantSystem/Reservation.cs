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
    public partial class Reservation : Form
    {
        bool hasBeenClicked = false;
        public Reservation()
        {
            InitializeComponent();


            // Attach the FormClosing event handler to the FormClosing eventa
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
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
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (!hasBeenClicked || textBox1.Text == "First")
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                hasBeenClicked = true;
            }
        }

        private void textBox1_Leave_1(object sender, EventArgs e)
        {
            if (hasBeenClicked && textBox1.Text == "")
            {
                TextBox box = sender as TextBox;
                box.Text = "First";
                hasBeenClicked = false;
            }
        }

        private void textBox2_Enter_1(object sender, EventArgs e)
        {
            if (!hasBeenClicked || textBox2.Text == "Last")
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                hasBeenClicked = true;
            }
        }

        private void textBox2_Leave_1(object sender, EventArgs e)
        {
            if (hasBeenClicked && textBox2.Text == "")
            {
                TextBox box = sender as TextBox;
                box.Text = "Last";
                hasBeenClicked = false;
            }
        }
        private void textBox3_Enter_1(object sender, EventArgs e)
        {
            if (!hasBeenClicked || textBox3.Text == "example@email.com")
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                hasBeenClicked = true;
            }
        }

        private void textBox3_Leave_1(object sender, EventArgs e)
        {
            if (hasBeenClicked && textBox3.Text == "")
            {
                TextBox box = sender as TextBox;
                box.Text = "example@email.com";
                hasBeenClicked = false;
            }
        }

        private void textBox4_Enter_1(object sender, EventArgs e)
        {
            if (!hasBeenClicked || textBox4.Text == "### ### ####")
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                hasBeenClicked = true;
            }
        }

        private void textBox4_Leave_1(object sender, EventArgs e)
        {
            if (hasBeenClicked && textBox4.Text == "")
            {
                TextBox box = sender as TextBox;
                box.Text = "### ### ####";
                hasBeenClicked = false;
            }
        }
        private void textBox5_Enter_1(object sender, EventArgs e)
        {
            if (!hasBeenClicked || textBox5.Text == "MM/DD/YYYY")
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                hasBeenClicked = true;
            }
        }

        private void textBox5_Leave_1(object sender, EventArgs e)
        {
            if (hasBeenClicked && textBox5.Text == "")
            {
                TextBox box = sender as TextBox;
                box.Text = "MM/DD/YYYY";
                hasBeenClicked = false;
            }
        }

        private void textBox6_Enter_1(object sender, EventArgs e)
        {
            if (!hasBeenClicked || textBox6.Text == "HH:MM AM/PM")
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                hasBeenClicked = true;
            }
        }

        private void textBox6_Leave_1(object sender, EventArgs e)
        {
            if (hasBeenClicked && textBox6.Text == "")
            {
                TextBox box = sender as TextBox;
                box.Text = "HH:MM AM/PM";
                hasBeenClicked = false;
            }
        }
        private void Reserve_Click_Click(object sender, EventArgs e)
        {
            // Get the user input from the form controls
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            string email = textBox3.Text;
            string phone = textBox4.Text;
            string reservationDate = textBox5.Text;
            string reservationTime = textBox6.Text;

            // Validate the user input
            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(reservationDate) ||
                string.IsNullOrWhiteSpace(reservationTime))
            {
                MessageBox.Show("Please fill in all the required fields.");
                return;
            }

            // Save the reservation data to a database or file, or send it to an API
            // Replace the code below with your own logic to handle the reservation

            // Display a confirmation message to the user
            MessageBox.Show("Thank you for your reservation!");
            ClearFormFields(); // Optional: Clear the form fields after successful reservation
        }

        private void ClearFormFields()
        {
            textBox1.Text = "First";
            textBox2.Text = "Last";
            textBox3.Text = "example@email.com";
            textBox4.Text = "### ### ####";
            textBox5.Text = "MM/DD/YYYY";
            textBox6.Text = "HH:MM AM/PM";
            textBox7.Text = "For how many people";
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string Email { get; set; }
        public static string Phone { get; set; }
        public static string ReservationDate { get; set; }
        public static string ReservationTime { get; set; }

    }
}
