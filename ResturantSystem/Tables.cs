using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResturantSystem
{
    public partial class Tables : Form
    {
        private Options _optionsForm;
        private bool hasBeenClicked = false;
        public Tables(Options optionsForm)
        {
            InitializeComponent();
            _optionsForm = optionsForm;
            InitializeButtons();
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

            // Print column names for debugging
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                Console.WriteLine("DataGridView1 Column: " + column.Name);
            }

            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                Console.WriteLine("DataGridView2 Column: " + column.Name);
            }
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

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //murzime = 1;
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //murzime = 2;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Options options = new Options("admin");
            options.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
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
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_Enter(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {
            dataGridView2.ClearSelection();
            dataGridView2.CurrentCell = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_false_Click(object sender, EventArgs e)
        {
            DbManager dbManager = new DbManager();
            Masi masi = new Masi(null, null, "false");
            if (dataGridView1.CurrentCell != null)
            {
                masi.Masi_id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            }
            else if (dataGridView2.CurrentCell != null)
            {
                masi.Masi_id = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                double a = Convert.ToDouble(textBox4.Text);
                a = a;
                dbManager.DeleteDaIma(masi.Masi_id);
            }
            else
            {
                MessageBox.Show("Table not selected!");
            }
            dbManager.UpdateMasiTaken(masi);
            DbManager db = new DbManager();
            dataGridView1.DataSource = db.SelectMasiTakenFalse();
            dataGridView2.DataSource = db.SelectMasiTakenTrue();
            dbManager.Dispose();
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
            dataGridView2.ClearSelection();
            dataGridView2.CurrentCell = null;
        }

        private void btn_true_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_tablechanges_Click(object sender, EventArgs e)
        {
            TableChanges tablechanges = new TableChanges(_optionsForm);
            tablechanges.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DbManager dbManager = new DbManager();
            Masi masi = new Masi(null, null, "false");
            masi.Masi_id = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            AddMenu menu = new AddMenu();
            menu.Data = masi.Masi_id;
            menu.Show();
        }

        private void MoveToFreeButton_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                try
                {
                    DataGridViewRow selectedRow = dataGridView2.CurrentRow;

                    // Print all column names and values for the selected row
                    foreach (DataGridViewCell cell in selectedRow.Cells)
                    {
                        Console.WriteLine("Column: " + cell.OwningColumn.Name + " Value: " + cell.Value);
                    }

                    // Create a new row for the Free tables
                    DataTable freeTable = (DataTable)dataGridView1.DataSource;
                    DataRow newRow = freeTable.NewRow();
                    foreach (DataGridViewCell cell in selectedRow.Cells)
                    {
                        newRow[cell.OwningColumn.Name] = cell.Value;
                    }
                    freeTable.Rows.Add(newRow);

                    // Remove the selected row from Occupied tables
                    dataGridView2.Rows.Remove(selectedRow);

                    // Update the table status in the database
                    DbManager dbManager = new DbManager();
                    int tableId = Convert.ToInt32(selectedRow.Cells["masi_id"].Value);
                    dbManager.UpdateMasiTaken(new Masi(null, null, "false") { Masi_id = tableId });
                    dbManager.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Успешно преместване!");
                }
            }
        }

        private void MoveToOccupiedButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                try
                {
                    DataGridViewRow selectedRow = dataGridView1.CurrentRow;

                    // Create a new row for the Occupied tables
                    DataTable occupiedTable = (DataTable)dataGridView2.DataSource;
                    DataRow newRow = occupiedTable.NewRow();
                    foreach (DataGridViewCell cell in selectedRow.Cells)
                    {
                        newRow[cell.OwningColumn.Name] = cell.Value;
                    }
                    occupiedTable.Rows.Add(newRow);

                    // Remove the selected row from Free tables
                    dataGridView1.Rows.Remove(selectedRow);

                    // Update the table status in the database
                    DbManager dbManager = new DbManager();
                    int tableId = Convert.ToInt32(selectedRow.Cells[0].Value); // Assuming Masi_id is the first column
                    dbManager.UpdateMasiTaken(new Masi(null, null, "true") { Masi_id = tableId });
                    dbManager.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Успешно преместване!");
                }
            }
        }

        private decimal CalculateTotalSumForTable(int tableId)
        {
            decimal totalSum = 0;

            foreach (DataGridViewRow row in dataGridView2.Rows) // Assuming dataGridView2 contains the orders for the table
            {
                if (row.Cells["masi_id"].Value != null && Convert.ToInt32(row.Cells["masi_id"].Value) == tableId)
                {
                    if (decimal.TryParse(row.Cells["price"].Value.ToString(), out decimal price) &&
                        int.TryParse(row.Cells["quantity"].Value.ToString(), out int quantity))
                    {
                        totalSum += price * quantity;
                    }
                }
            }

            return totalSum;
        }

        private void ClearOrdersForTable(int tableId)
        {
            for (int i = dataGridView2.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView2.Rows[i];
                if (row.Cells["masi_id"].Value != null && Convert.ToInt32(row.Cells["masi_id"].Value) == tableId)
                {
                    dataGridView2.Rows.RemoveAt(i);
                }
            }

        }
        private void InitializeButtons()
        {
            Button moveToFreeButton = new Button();
            moveToFreeButton.Text = "Move to Free";
            moveToFreeButton.Location = new Point(20, 20); // Adjust the location as needed
            moveToFreeButton.Click += new EventHandler(MoveToFreeButton_Click);
            this.Controls.Add(moveToFreeButton);

            Button moveToOccupiedButton = new Button();
            moveToOccupiedButton.Text = "Move to Occupied";
            moveToOccupiedButton.Location = new Point(20, 60); // Adjust the location as needed
            moveToOccupiedButton.Click += new EventHandler(MoveToOccupiedButton_Click);
            this.Controls.Add(moveToOccupiedButton);
        }
    }

}
    
