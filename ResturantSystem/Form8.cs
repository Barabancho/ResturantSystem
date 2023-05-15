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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbManager dbManager = new DbManager();
            MenuItem menuItem = new MenuItem(textBox1.Text, decimal.Parse(textBox2.Text), textBox3.Text);
            dbManager.UpdateMenuItem(menuItem);
            dbManager.Dispose();
        }
    }
}
