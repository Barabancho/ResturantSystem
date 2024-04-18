using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResturantSystem
{
    public partial class Login : Form
    {
        private bool hasBeenClicked = false;
        private bool hasBeenClicked2 = false;
        private bool passwordTyped = false;
        public static Boss entBoss;
        public Login()
        {
            InitializeComponent();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
{
    // Store the current text in the password field
    string passwordText = textBox2.Text;

    switch (comboBox1.SelectedIndex)
    {
        case 0:
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            break;
        case 1:
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("bg-BG");
            break;
    }

    // Update application level culture
    System.Threading.Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture;

    // Refresh the UI
    ComponentResourceManager resources = new ComponentResourceManager(typeof(Login));
    resources.ApplyResources(this, "$this");
    ApplyResourceToControl(this, resources);

    // Restore the text in the password field
    textBox2.Text = passwordText;
}

private void ApplyResourceToControl(Control control, ComponentResourceManager resources)
{
    foreach (Control c in control.Controls)
    {
        resources.ApplyResources(c, c.Name);
        ApplyResourceToControl(c, resources);
    }
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
            entBoss = new Boss();
            entBoss.Username = textBox1.Text;
            entBoss.Password = textBox2.Text;

            DbManager db = new DbManager();

            
            if (db.SelectAcc(entBoss))
            {
                entBoss = db.RetrieveBossByUsername(entBoss.Username);
                
                if (entBoss != null)
                {
                    Options options = new Options(entBoss);
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
            TextBox box = sender as TextBox;
            if (!string.IsNullOrEmpty(box.Text) && box.Text != "Password")
            {
                passwordTyped = true;
                box.UseSystemPasswordChar = true;
            }
            else
            {
                passwordTyped = false;
                box.UseSystemPasswordChar = false;
            }

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
            if (!hasBeenClicked2 || textBox2.Text == "Password")
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                hasBeenClicked2 = true;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (!passwordTyped)
            {
                TextBox box = sender as TextBox;
                box.Text = "Password";
                hasBeenClicked2 = false;
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
