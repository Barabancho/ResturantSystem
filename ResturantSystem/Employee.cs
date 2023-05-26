using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace ResturantSystem
{
    public partial class Employee : Form
    {
        private bool hasBeenClicked = false;
        //private Dictionary<DateTime, List<EmployeeInfo>> schedule;

        public Employee()
        {
            InitializeComponent();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Employee_FormClosing);
            //schedule = new Dictionary<DateTime, List<EmployeeInfo>>();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //DateTime selectedDate = dateTimePicker1.Value;
            //UpdateEmployeeList(selectedDate);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbManager dbManager = new DbManager();
            EmployeeSchedules employee = new EmployeeSchedules(textBox4.Text, textBox1.Text, textBox5.Text, textBox6.Text, textBox8.Text, textBox2.Text, textBox7.Text, textBox3.Text);
            dbManager.InsertEmployee(employee);
            dbManager.Dispose();
            DbManager db = new DbManager();
            dataGridView1.DataSource = db.SelectEmployee();
            /*
            DateTime selectedDate = dateTimePicker2.Value;
            string startTime = textBox1.Text;
            string endTime = textBox2.Text;
            string dayOfWeek = textBox3.Text;
            string firstName = textBox4.Text;
            string lastName = textBox5.Text;
            string email = textBox6.Text;
            string phoneNumber = textBox7.Text;
            string position = textBox8.Text;

            EmployeeInfo employee = new EmployeeInfo()
            {
                StartTime = startTime,
                EndTime = endTime,
                DayOfWeek = dayOfWeek,
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                PhoneNumber = phoneNumber,
                Position = position
            };

            AddEmployeeToSchedule(selectedDate, employee);
            UpdateEmployeeList(selectedDate);*/
        }/*

        private void AddEmployeeToSchedule(DateTime date, EmployeeInfo employee)
        {
            if (!schedule.ContainsKey(date))
            {
                schedule[date] = new List<EmployeeInfo>();
            }

            schedule[date].Add(employee);
        }

        private void UpdateEmployeeList(DateTime date)
        {
            if (schedule.ContainsKey(date))
            {
                listBox1.Items.Clear();
                foreach (var employee in schedule[date])
                {
                    listBox1.Items.Add(employee);
                }
            }
            else
            {
                listBox1.Items.Clear();
            }
        }*/

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            DbManager db = new DbManager();
            dataGridView1.DataSource = db.SelectEmployee();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DbManager dbManager = new DbManager();
            EmployeeSchedules employee = new EmployeeSchedules();
            employee.Schedule_id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            dbManager.DeleteEmployee(employee);
            DataTable dt = dbManager.SelectMenu();
            dataGridView1.DataSource = dt;
            dbManager.Dispose();
            /*
            DateTime selectedDate = dateTimePicker2.Value;
            int selectedIndex = listBox1.SelectedIndex;

            if (selectedIndex >= 0 && schedule.ContainsKey(selectedDate))
            {
                schedule[selectedDate].RemoveAt(selectedIndex);
                UpdateEmployeeList(selectedDate);
            }*/
        }

        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            options.Show();
            this.Hide();
        }
        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (!hasBeenClicked || textBox3.Text == "Position")
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
                box.Text = "Position";
                hasBeenClicked = false;
            }
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (!hasBeenClicked || textBox1.Text == "End time")
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
                box.Text = "End time";
                hasBeenClicked = false;
            }
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (!hasBeenClicked || textBox2.Text == "Email")
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
                box.Text = "Email";
                hasBeenClicked = false;
            }
        }
        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (!hasBeenClicked || textBox4.Text == "Start time")
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                hasBeenClicked = true;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (hasBeenClicked && textBox4.Text == "")
            {
                TextBox box = sender as TextBox;
                box.Text = "Start time";
                hasBeenClicked = false;
            }
        }
        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (!hasBeenClicked || textBox5.Text == "Day of week")
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                hasBeenClicked = true;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (hasBeenClicked && textBox5.Text == "")
            {
                TextBox box = sender as TextBox;
                box.Text = "Day of week";
                hasBeenClicked = false;
            }
        }
        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (!hasBeenClicked || textBox6.Text == "Fname")
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                hasBeenClicked = true;
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (hasBeenClicked && textBox6.Text == "")
            {
                TextBox box = sender as TextBox;
                box.Text = "Fname";
                hasBeenClicked = false;
            }
        }
        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (!hasBeenClicked || textBox7.Text == "Phone number")
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
                box.Text = "Phone number";
                hasBeenClicked = false;
            }
        }
        private void textBox8_Enter(object sender, EventArgs e)
        {
            if (!hasBeenClicked || textBox8.Text == "Lname")
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                hasBeenClicked = true;
            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (hasBeenClicked && textBox8.Text == "")
            {
                TextBox box = sender as TextBox;
                box.Text = "Lname";
                hasBeenClicked = false;
            }
        }
    }
    /*
    public class EmployeeInfo
    {
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string DayOfWeek { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Position { get; set; }

        public override string ToString()
        {
            return string.Format("Start Time: {0}, End Time: {1}, Day of Week: {2}, First Name: {3}, Last Name: {4}, Email: {5}, Phone Number: {6}, Position: {7}",
                StartTime, EndTime, DayOfWeek, FirstName, LastName, Email, PhoneNumber, Position);
        }
    }*/

}
