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
    }

    public class EmployeeInfo
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}, Position: {1}", Name, Position);
        }
    }
}
