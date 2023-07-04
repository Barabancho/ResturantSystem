﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ResturantSystem
{
    public partial class Options : Form
    {
        private Boss boss;
        //private string userRole;
        public Options(Boss boss)
        {
            //InitializeComponent();
            //this.boss = boss;
            //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
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
            Reservation reservation = new Reservation();
            reservation.Show();
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
            Employee employee = new Employee();
            employee.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DbManager db = new DbManager();
            //Boss retrievedBoss = db.RetrieveBossByUsername(boss.Role = userRole);
            //Menu menu = new Menu(userRole);
            //menu.Show();
            //this.Hide();
        }

        public Options(string role)
        {
            //InitializeComponent();
            //userRole = role;
        }
        /*
        private void Options_Load(object sender, EventArgs e)
        {

            DbManager db = new DbManager();
            Boss boss = new Boss();
            if (boss.Role == "admin")
            {
                button1.Visible = true;
                button2.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button5.Visible = true;
                button4.Visible = true;
            }
            else// if (boss.Role == "customer")
            {
                button1.Visible = true;
                button2.Visible = false;
                button6.Visible = true;
                button7.Visible = false;
                button5.Visible = false;
                button4.Visible = false;
            }
            //else MessageBox.Show("how????");
        }*/
        private void Options_Load(object sender, EventArgs e)
        {
            DbManager db = new DbManager();

            if (boss != null)
            {
                if (boss.Role == "admin")
                {
                    button1.Visible = false;
                    button2.Visible = true;
                    button6.Visible = false;
                    button7.Visible = true;
                    button5.Visible = true;
                    button4.Visible = true;
                    button10.Visible = true;
                }
                else if (boss.Role == "customer")
                {
                    button1.Visible = true;
                    button2.Visible = false;
                    button6.Visible = true;
                    button7.Visible = false;
                    button5.Visible = false;
                    button4.Visible = false;
                    button10.Visible = false;
                }
                else
                {
                    MessageBox.Show("Unauthorized access.");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Boss not found.");
                Application.Exit();
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

        private void button7_Click(object sender, EventArgs e)
        {
            Tables tables = new Tables();
            tables.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Registrations registrations = new Registrations();
            registrations.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Reserved reserved = new Reserved();
            reserved.Show();
            this.Hide();
        }
    }
}
