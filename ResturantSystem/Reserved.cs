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
    public partial class Reserved : Form
    {
        public Reserved()
        {
            InitializeComponent();

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reserved_FormClosing);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DbManager dbManager = new DbManager();
            Reservations reservations = new Reservations();
            reservations.Reservation_id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            dbManager.DeleteReservation(reservations);
            DataTable dt = dbManager.SelectReservation();
            dataGridView1.DataSource = dt;
            dbManager.Dispose();
        }

        private void Reserved_Load(object sender, EventArgs e)
        {
            DbManager db = new DbManager();
            dataGridView1.DataSource = db.SelectReservation();
        }

        private void Reserved_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are you sure you want to exit? ", "Confirm Exit", MessageBoxButtons.YesNo) == DialogResult.No)
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
