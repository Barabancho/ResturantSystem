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
    public partial class Quantity : Form
    {
        public int Masa { get; set; }
        public string Hrana { get; set; }
        public Quantity()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            DbManager dbManager = new DbManager();
            MenuItem menuItem = new MenuItem();
            a = dbManager.SelectHrina($"{Hrana}");
            dbManager.InsertRecievedOrdersAndItems(Masa, a, int.Parse(textBox1.Text));
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Quantity_Load(object sender, EventArgs e)
        {

        }
        private void Quantity_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    this.Hide();
                }
            }
        }
    }
}
