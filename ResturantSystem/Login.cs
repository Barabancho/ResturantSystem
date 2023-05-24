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

            // Simulating a database query to retrieve the user's role based on the username and password
            Dictionary<string, string> users = new Dictionary<string, string>()
    {
        { "admin", "admin123" },
        { "customer", "customer123" }
    };

            string role = string.Empty;

            // Check if the username exists in the dictionary and the password matches
            if (users.ContainsKey(username) && users[username] == password)
            {
                // Retrieve the role for the authenticated user
                role = GetRoleFromDatabase(username);
            }

            return role;
        }

        private string GetRoleFromDatabase(string username)
        {
            // TODO: Replace this code with your actual database query to retrieve the user's role
            // Connect to your database and retrieve the user's role based on the username

            // In this example, we are assuming that the role is stored in the dictionary itself
            Dictionary<string, string> userRoles = new Dictionary<string, string>()
    {
        { "admin", "admin" },
        { "customer", "customer" }
    };

            if (userRoles.ContainsKey(username))
            {
                return userRoles[username];
            }

            return string.Empty;
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
