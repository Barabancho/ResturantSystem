﻿using System;
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
    public partial class Login : Form
    {
        private bool hasBeenClicked = false;

        public Login()
        {
            InitializeComponent();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string AuthenticateUser(string username, string password)
        {
            // TODO: Replace this code with your actual authentication logic and database interaction

            // Assume you have a "Users" table in your database with columns "Username", "Password", and "Role"
            // You would need to query the database to find the matching user and retrieve their role

            string role = string.Empty;

            // Example hardcoded credentials for demonstration purposes
            if (username == "admin" && password == "admin123")
            {
                role = "admin";
            }
            else if (username == "customer" && password == "customer123")
            {
                role = "customer";
            }

            return role;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Authenticate the user and retrieve the user's role from the database
            string role = AuthenticateUser(username, password);

            if (role == "admin")
            {
                Options adminOptions = new Options(role);
                adminOptions.Show();
            }
            else if (role == "customer")
            {
                Options customerOptions = new Options(role);
                customerOptions.Show();
            }

            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //string userInput = textBox1.Text;
            //MessageBox.Show(userInput);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //string userInput = textBox1.Text;
            //MessageBox.Show(userInput);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (!hasBeenClicked || textBox1.Text == "Username")
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                hasBeenClicked = true;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (hasBeenClicked && textBox1.Text=="")
            {
                TextBox box = sender as TextBox;
                box.Text = "Username";
                hasBeenClicked = false;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (!hasBeenClicked || textBox2.Text == "Password")
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                hasBeenClicked = true;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (hasBeenClicked && textBox2.Text == "")
            {
                TextBox box = sender as TextBox;
                box.Text = "Password";
                hasBeenClicked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
