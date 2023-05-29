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
            if (!hasBeenClicked || textBox5.Text == "MM.DD.YYYY")
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
                box.Text = "MM.DD.YYYY";
                hasBeenClicked = false;
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (!hasBeenClicked || textBox7.Text == "")
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                hasBeenClicked = true;
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (hasBeenClicked && textBox7.Text == "")
            {
                TextBox box = sender as TextBox;
                box.Text = "number";
                hasBeenClicked = false;
            }
        }
        private void Reserve_Click_Click(object sender, EventArgs e)
        {
            
            DbManager dbManager = new DbManager();
            Reservations reservations;

            int tableNumber;
            if (int.TryParse(textBox7.Text, out tableNumber))
            {
                reservations = new Reservations(textBox5.Text, tableNumber, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                dbManager.InsertReservation(reservations);
                dbManager.Dispose();
                MessageBox.Show("Thank you for your reservation!", "Reservation Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid table number. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boss boss = new Boss();
            Options options = new Options(boss.Role = "customer");
            options.Show();
            this.Hide();
        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            DateTime selectedDate = dateTimePicker1.Value;

            
            string formattedDate = selectedDate.ToString("dd.MM.yyyy");

            
            textBox5.Text = formattedDate;

            
            dateTimePicker1.Visible = false;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
