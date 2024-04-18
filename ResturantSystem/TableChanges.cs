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
    public partial class TableChanges : Form
    {
        private bool hasBeenClicked = false;
        public TableChanges()
        {
            InitializeComponent();
        }

        private void TableChanges_Load(object sender, EventArgs e)
        {
            DbManager db = new DbManager();
            dataGridView1.DataSource = db.GetMasiData();
        }

        private void TableChanges_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Tables tables = new Tables();
                    tables.Show();
                    this.Hide();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DbManager dbManager = new DbManager();
            Masi masi = new Masi();
            masi = new Masi(textBox1.Text, textBox2.Text, "false");
            dbManager.InsertMasi(masi);
            dbManager.Dispose();
            DbManager db = new DbManager();
            dataGridView1.DataSource = db.GetMasiData();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (!hasBeenClicked || textBox1.Text == "Table Number")
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
                box.Text = "Table Number";
                hasBeenClicked = false;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (!hasBeenClicked || textBox2.Text == "Table Capacity")
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
                box.Text = "Table Capacity";
                hasBeenClicked = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DbManager dbManager = new DbManager();
            Masi masi = new Masi();
            masi.Masi_id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            dbManager.DeleteMasi(masi);
            DbManager db = new DbManager();
            dataGridView1.DataSource = db.GetMasiData();
            dbManager.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DbManager dbManager = new DbManager();
            Masi masi = new Masi(textBox1.Text, textBox2.Text, null);
            masi.Masi_id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            dbManager.UpdateMasi(masi);
            DbManager db = new DbManager();
            dataGridView1.DataSource = db.GetMasiData();
            dbManager.Dispose();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Tables tables = new Tables();
            tables.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}