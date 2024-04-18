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
    public partial class Grafici : Form
    {
        public Grafici()
        {
            InitializeComponent();
        }

        private void Grafici_Load(object sender, EventArgs e)
        {
            
            this.employeeSchedulesTableAdapter.Fill(this.database1DataSet.EmployeeSchedules);

        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            Boss boss = new Boss();
            Options options = new Options(boss.Role = "customer");
            options.Show();
            this.Hide();
        }

        private void Grafici_FormClosing_1(object sender, FormClosingEventArgs e)
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
    }
}
