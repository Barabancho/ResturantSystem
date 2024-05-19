using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResturantSystem
{
    public partial class AddMenu : Form
    {
        public int Data { get; set; }

        public AddMenu()
        {
            InitializeComponent();
            panelfoods.Visible = false;
            pnldrinks.Visible = false;
            paneldesserts.Visible = false;
            PanelOrders.Visible = false;

            // Add Calculate button
            Button calculateButton = new Button();
            calculateButton.Text = "Calculate";
            calculateButton.Location = new Point(12, 12);
            calculateButton.Click += new EventHandler(CalculateButton_Click);
            this.Controls.Add(calculateButton);
        }

        private void AddMenu_FormClosing(object sender, FormClosingEventArgs e)
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

        private void AddMenu_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Data.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnfoods_Click(object sender, EventArgs e)
        {
            panelfoods.Visible = true;
            pnldrinks.Visible = false;
            paneldesserts.Visible = false;
            PanelOrders.Visible = false;
        }

        private void btndrinks_Click(object sender, EventArgs e)
        {
            panelfoods.Visible = false;
            pnldrinks.Visible = true;
            paneldesserts.Visible = false;
            PanelOrders.Visible = false;
        }

        private void btndesserts_Click(object sender, EventArgs e)
        {
            panelfoods.Visible = false;
            pnldrinks.Visible = false;
            paneldesserts.Visible = true;
            PanelOrders.Visible = false;
        }

        private void panelfoods_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pnldrinks_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
        }

        private void paneldesserts_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DbManager dbManager = new DbManager();
            DataTable dt = dbManager.RecievedOrdersAndItems();
        }

        private void btnpudding_Click(object sender, EventArgs e)
        {
        }

        private void btncakes_Click(object sender, EventArgs e)
        {
            Quantity quantity = new Quantity();
            quantity.Masa = Data;
            quantity.Hrana = "cakes";
            quantity.Show();
        }

        private void btnicecream_Click(object sender, EventArgs e)
        {
            Quantity quantity = new Quantity();
            quantity.Masa = Data;
            quantity.Hrana = "ice cream";
            quantity.Show();
        }

        private void btncoffe_Click(object sender, EventArgs e)
        {
            Quantity quantity = new Quantity();
            quantity.Masa = Data;
            quantity.Hrana = "coffe";
            quantity.Show();
        }

        private void btntea_Click(object sender, EventArgs e)
        {
            Quantity quantity = new Quantity();
            quantity.Masa = Data;
            quantity.Hrana = "tea";
            quantity.Show();
        }

        private void btnjuice_Click(object sender, EventArgs e)
        {
            Quantity quantity = new Quantity();
            quantity.Masa = Data;
            quantity.Hrana = "juice";
            quantity.Show();
        }

        private void btncarbonated_Click(object sender, EventArgs e)
        {
            Quantity quantity = new Quantity();
            quantity.Masa = Data;
            quantity.Hrana = "carbonated water";
            quantity.Show();
        }

        private void btnsoftdrinks_Click(object sender, EventArgs e)
        {
            Quantity quantity = new Quantity();
            quantity.Masa = Data;
            quantity.Hrana = "soft drinks";
            quantity.Show();
        }

        private void btnotherdrinks_Click(object sender, EventArgs e)
        {
            Quantity quantity = new Quantity();
            quantity.Masa = Data;
            quantity.Hrana = "other drinks";
            quantity.Show();
        }

        private void btnpizza_Click(object sender, EventArgs e)
        {
            Quantity quantity = new Quantity();
            quantity.Masa = Data;
            quantity.Hrana = "pizza";
            quantity.Show();
        }

        private void btnchicken_Click(object sender, EventArgs e)
        {
            Quantity quantity = new Quantity();
            quantity.Masa = Data;
            quantity.Hrana = "chicken";
            quantity.Show();
        }

        private void btnseafood_Click(object sender, EventArgs e)
        {
            Quantity quantity = new Quantity();
            quantity.Masa = Data;
            quantity.Hrana = "seafood";
            quantity.Show();
        }

        private void btnbbq_Click(object sender, EventArgs e)
        {
            Quantity quantity = new Quantity();
            quantity.Masa = Data;
            quantity.Hrana = "bbq";
            quantity.Show();
        }

        private void btnsushi_Click(object sender, EventArgs e)
        {
            Quantity quantity = new Quantity();
            quantity.Masa = Data;
            quantity.Hrana = "sushi";
            quantity.Show();
        }

        private void btnother_Click(object sender, EventArgs e)
        {
            Quantity quantity = new Quantity();
            quantity.Masa = Data;
            quantity.Hrana = "kebab";
            quantity.Show();
        }

        private void btnorders_Click(object sender, EventArgs e)
        {
            DbManager dbManager = new DbManager();
            DataTable data = dbManager.SelectDaKajemDAJ(Data);
            dataGridView1.DataSource = data;
            panelfoods.Visible = false;
            pnldrinks.Visible = false;
            paneldesserts.Visible = false;
            PanelOrders.Visible = true;
        }

        private void pnlleft_Paint(object sender, PaintEventArgs e)
        {
        }

        private void PanelOrders_Paint(object sender, PaintEventArgs e)
        {
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            decimal totalSum = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["price"].Value != null && row.Cells["price"].Value != DBNull.Value &&
                    row.Cells["quantity"].Value != null && row.Cells["quantity"].Value != DBNull.Value)
                {
                    if (decimal.TryParse(row.Cells["price"].Value.ToString(), out decimal price) &&
                        int.TryParse(row.Cells["quantity"].Value.ToString(), out int quantity))
                    {
                        totalSum += price * quantity;
                    }
                }
            }

            MessageBox.Show("Total Price: " + totalSum.ToString("C"));
        }
    }
}
