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
    public partial class Registrations : Form
    {
        public Registrations()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Registrations_Load(object sender, EventArgs e)
        {
            DbManager db = new DbManager();
            dataGridView1.DataSource = db.SelectMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DbManager dbManager = new DbManager();
            Boss boss = new Boss();
            boss.Boss_id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            dbManager.DeleteBoss(boss);
            DataTable dt = dbManager.SelectMenu();
            dataGridView1.DataSource = dt;
            dbManager.Dispose();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            options.Show();
            this.Hide();
        }
    }
}
