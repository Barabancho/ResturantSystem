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
    public partial class To_be_deleted : Form
    {
        bool hasBeenClicked = false;
        public To_be_deleted()
        {
            InitializeComponent();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form7_FormClosing);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (!hasBeenClicked || textBox1.Text == "name")
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                hasBeenClicked = true;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (hasBeenClicked && textBox1.Text == "")
            {
                TextBox box = sender as TextBox;
                box.Text = "name";
                hasBeenClicked = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (!hasBeenClicked || textBox2.Text == "price")
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
                box.Text = "price";
                hasBeenClicked = false;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (!hasBeenClicked || textBox3.Text == "desrciption")
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
                box.Text = "description";
                hasBeenClicked = false;
            }
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            DbManager dbManager = new DbManager();
            MenuItem menuItem = new MenuItem(textBox1.Text,decimal.Parse(textBox2.Text),textBox3.Text); 
            dbManager.InsertMenuItem(menuItem);
            dbManager.Dispose();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menuchanges menuchange =  new Menuchanges();
            menuchange.Show();
            this.Hide();
        }
    }
}
