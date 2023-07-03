﻿using System;
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
    public partial class Tables: Form
    {
        private bool hasBeenClicked = false;
        //private int murzime = 0;
        public Tables()
        {
            InitializeComponent();
        }

        private void Tables_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView2.AllowUserToAddRows = false;
            DbManager db = new DbManager();
            dataGridView1.DataSource = db.SelectMasiTakenFalse();
            dataGridView2.DataSource = db.SelectMasiTakenTrue();
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
            dataGridView2.ClearSelection();
            dataGridView2.CurrentCell = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //dataGridView1.ClearSelection();
            //dataGridView1.CurrentCell = null;
            //dataGridView2.ClearSelection();
            //dataGridView2.CurrentCell = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DbManager dbManager = new DbManager();
            Masi masi = new Masi();
            if(dataGridView1.CurrentCell!= null)
            {
                masi.Masi_id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                dbManager.DeleteMasi(masi);
            }
            if(dataGridView2.CurrentCell != null)
            {
                masi.Masi_id = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                dbManager.DeleteMasi(masi);
            }
            DataTable dt = dbManager.SelectMasiTakenTrue();
            DataTable dt1 = dbManager.SelectMasiTakenFalse();
            dataGridView1.DataSource = dt;
            dataGridView1.DataSource = dt1;
            dbManager.Dispose();
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
            dataGridView2.ClearSelection();
            dataGridView2.CurrentCell = null;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //murzime = 1;
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //murzime = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boss boss = new Boss();
            Options options = new Options(boss.Role = "admin");
            options.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DbManager dbManager = new DbManager();
            Masi masi = new Masi();
            if (textBox3.Text == "free")
            {
                masi = new Masi(textBox1.Text, textBox2.Text, "false");
            }
            else
            {
                masi = new Masi(textBox1.Text, textBox2.Text, "true");
            }
            dbManager.InsertMasi(masi);
            dbManager.Dispose();
            DbManager db = new DbManager();
            dataGridView1.DataSource = db.SelectMasiTakenFalse();
            dataGridView2.DataSource = db.SelectMasiTakenTrue();
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
            dataGridView2.ClearSelection();
            dataGridView2.CurrentCell = null;
        }

        private void Tables_FormClosing(object sender, FormClosingEventArgs e)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a = "";
            if (textBox3.Text == "free")
            {
                a = "false";
            }
            else
            {
                a = "true";
            }
            DbManager dbManager = new DbManager();
            Masi masi = new Masi(textBox1.Text, textBox2.Text, a);
            if (dataGridView1.CurrentCell != null)
            {
                masi.Masi_id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            }
            if (dataGridView2.CurrentCell != null)
            {
                masi.Masi_id = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            }
            else
            {
                MessageBox.Show("what");
            }/*
            Masi masi = new Masi(textBox1.Text, textBox2.Text, textBox3.Text);
            masi.Masi_id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());*/
            dbManager.UpdateMasi(masi);
            DbManager db = new DbManager();
            dataGridView1.DataSource = db.SelectMasiTakenFalse();
            dataGridView2.DataSource = db.SelectMasiTakenTrue();
            dbManager.Dispose();
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
            dataGridView2.ClearSelection();
            dataGridView2.CurrentCell = null;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (!hasBeenClicked || textBox3.Text == "taken")
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
                box.Text = "taken";
                hasBeenClicked = false;
            }
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (!hasBeenClicked || textBox1.Text == "table number")
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
                box.Text = "table number";
                hasBeenClicked = false;
            }
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (!hasBeenClicked || textBox2.Text == "capacity")
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
                box.Text = "capacity";
                hasBeenClicked = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.ClearSelection();
            //dataGridView1.CurrentCell = null;
            //dataGridView2.ClearSelection();
            //dataGridView2.CurrentCell = null;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_Enter(object sender, EventArgs e)
        {

            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
            //dataGridView2.ClearSelection();
            //dataGridView2.CurrentCell = null;
        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {
            //dataGridView1.ClearSelection();
            //dataGridView1.CurrentCell = null;
            dataGridView2.ClearSelection();
            dataGridView2.CurrentCell = null;
        }
    }
}
