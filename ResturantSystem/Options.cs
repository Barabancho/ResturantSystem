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
    public partial class Options : Form
    { 

        public Options()
        {
            InitializeComponent();

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reservation form3 = new Reservation();

           
            form3.Show();

         
            this.Hide();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            Menuchanges form4 = new Menuchanges();
            form4.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Reserved reserved = new Reserved();
            reserved.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private string userRole;

        public Options(string role)
        {
            InitializeComponent();
            userRole = role;
        }

        private void Options_Load(object sender, EventArgs e)
        {
            if (userRole == "admin")
            {
                // Admin specific buttons
                button4.Visible = true; // Show the button for admin operations
            }
            else if (userRole == "customer")
            {
                // Customer specific buttons
                button1.Visible = true; // Show the button for making a reservation
                button2.Visible = true; // Show the button for viewing reservations
            }
        }
        private Timer timer;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            WelcomePanel.Visible = true; // Show the panel

            // Create a timer control if it doesn't exist
            if (timer == null)
            {
                timer = new Timer();
                timer.Interval = 3000; // 3 seconds
                timer.Tick += Timer_Tick; // Define the event handler for the timer's Tick event
            }

            timer.Start(); // Start or restart the timer
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop(); // Stop the timer
            WelcomePanel.Visible = false; // Hide the panel

        }
       



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
