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
    public partial class Register : Form
    {
        private bool hasBeenClicked = false;
        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2 == textBox3)
            {
                DbManager dbManager = new DbManager();
                Boss boss = new Boss(textBox1.Text, textBox4.Text, textBox5.Text, "customer", textBox3.Text);
                dbManager.InsertBoss(boss);
                dbManager.Dispose();
            }
            else
            {

            }
        }
        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (!hasBeenClicked || textBox3.Text == "Confirm Password")
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                hasBeenClicked = true;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (hasBeenClicked && textBox3.Text == "")
            {
                TextBox box = sender as TextBox;
                box.Text = "Confirm Pasword";
                hasBeenClicked = false;
            }
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (!hasBeenClicked || textBox3.Text == "Username")
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                hasBeenClicked = true;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (hasBeenClicked && textBox3.Text == "")
            {
                TextBox box = sender as TextBox;
                box.Text = "Username";
                hasBeenClicked = false;
            }
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (!hasBeenClicked || textBox3.Text == "Enter Password")
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                hasBeenClicked = true;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (hasBeenClicked && textBox3.Text == "")
            {
                TextBox box = sender as TextBox;
                box.Text = "Enter Password";
                hasBeenClicked = false;
            }
        }
        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (!hasBeenClicked || textBox3.Text == "Email")
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                hasBeenClicked = true;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (hasBeenClicked && textBox3.Text == "")
            {
                TextBox box = sender as TextBox;
                box.Text = "Email";
                hasBeenClicked = false;
            }
        }
        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (!hasBeenClicked || textBox3.Text == "Phone number")
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                hasBeenClicked = true;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }
        


            private void textBox5_Leave(object sender, EventArgs e)
        {
            if (hasBeenClicked && textBox3.Text == "")
            {
                TextBox box = sender as TextBox;
                box.Text = "Phone number";
                hasBeenClicked = false;
            }
        }



            
        

    }
}
