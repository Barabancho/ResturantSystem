using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResturantSystem
{
    public partial class Menuchanges : Form
    {
        private bool hasBeenClicked = false;
        private string connectionString = "Data Source=YourServerName;Initial Catalog=YourDatabaseName;Integrated Security=True";
        public Menuchanges()
        {
            InitializeComponent();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            DbManager db = new DbManager();
            dataGridView1.DataSource = db.SelectMenu();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbManager dbManager = new DbManager();
            MenuItem menuItem = new MenuItem(textBox1.Text,decimal.Parse(textBox2.Text),textBox3.Text, int.Parse(textBox4.Text)); 
            dbManager.InsertMenuItem(menuItem);
            dbManager.Dispose();
            DbManager db = new DbManager();
            dataGridView1.DataSource = db.SelectMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DbManager dbManager = new DbManager();
            MenuItem menuItem = new MenuItem(textBox1.Text, decimal.Parse(textBox2.Text), textBox3.Text, int.Parse(textBox4.Text));
            menuItem.Menu_item_id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            dbManager.UpdateMenuItem(menuItem);
            DbManager db = new DbManager();
            dataGridView1.DataSource = db.SelectMenu();
            dbManager.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DbManager dbManager =new DbManager();
            MenuItem menuItem = new MenuItem();
            menuItem.Menu_item_id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            dbManager.DeleteMenuItem(menuItem);
            DataTable dt = dbManager.SelectMenu();
            dataGridView1.DataSource = dt;
            dbManager.Dispose();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
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
            Boss boss = new Boss();
            Options options = new Options(boss.Role = "admin");
            options.Show();
            this.Hide();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (!hasBeenClicked || textBox1.Text == "Name")
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
                box.Text = "Name";
                hasBeenClicked = false;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (!hasBeenClicked || textBox2.Text == "Price")
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
                box.Text = "Price";
                hasBeenClicked = false;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (!hasBeenClicked || textBox3.Text == "Description")
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
                box.Text = "Description";
                hasBeenClicked = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnfoods_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            if (!hasBeenClicked || textBox3.Text == "Quantity")
            {
                TextBox box = sender as TextBox;
                box.Text = String.Empty;
                hasBeenClicked = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
