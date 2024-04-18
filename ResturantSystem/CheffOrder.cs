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
    public partial class CheffOrder : Form
    {
        public CheffOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Options options = new Options("admin");
            options.Show();
            this.Hide();
        }

        private void CheffOrder_Load(object sender, EventArgs e)
        {

            DbManager dbManager = new DbManager();
            dataGridView1.DataSource = dbManager.SelectCheffOrder();
        }
    }
}
