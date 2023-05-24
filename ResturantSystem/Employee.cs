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
    public partial class Employee : Form
    {
        private Dictionary<DateTime, List<EmployeeInfo>> schedule;

        public Employee()
        {
            InitializeComponent();

            schedule = new Dictionary<DateTime, List<EmployeeInfo>>();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            UpdateEmployeeList(selectedDate);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            UpdateEmployeeList(selectedDate);
        }

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
        }

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

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }

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
    }
}
