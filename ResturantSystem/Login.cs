using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /*
        private string AuthenticateUser(string username, string password)
        {
            

           
            Dictionary<string, string> users = new Dictionary<string, string>()
            {
                { "admin", "admin123" },
                { "customer", "customer123" }
            };

            string role = string.Empty;

          
            if (users.ContainsKey(username) && users[username] == password)
            {
                // Retrieve the role for the authenticated user
                role = GetRoleFromDatabase(username);
            }

            return role;
        }

        private string GetRoleFromDatabase(string username)
        {

           
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
        }*/
        //---------------------------------------------------------------------------------------------------------------------------------------------------
        /*
        private string AuthenticateUser(string username, string password)
        {
            string role = string.Empty;

           
            using (var connection = new SqlConnection("YourConnectionString"))
            {
                connection.Open();

                string query = "SELECT role FROM Boss WHERE username = @Username AND password = @Password";
                using (var command = new SqlCommand(query, connection))
                {
                   
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                  
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        role = result.ToString();
                    }
                }
            }

            return role;
        }*/

        //---------------------------------------------------------------------------------------------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        { 
            Boss boss = new Boss();
            boss.Username = textBox1.Text;
            boss.Password = textBox2.Text;

            DbManager db = new DbManager();

            
            if (db.SelectAcc(boss))
            {
                Boss retrievedBoss = db.RetrieveBossByUsername(boss.Username);

                if (retrievedBoss != null)
                {
                    Options options = new Options(boss);
                    options.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Boss not found.");
                }
            }
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //Options options = new Options();
            //options.Show();
            //this.Hide();
            
        }
    }
}
