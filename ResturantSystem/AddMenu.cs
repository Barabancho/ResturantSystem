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
            //DbManager dbManager = new DbManager();
            //dbManager.Data = this.Data;
            //dataGridView1.DataSource = dbManager.SelectRecievedOrdersAndItems();
            //MessageBox.Show("predpolagam zapisano?", "niznam?", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Tables tables = new Tables();
            //tables.Show();
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

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DbManager dbManager = new DbManager();
            DataTable dt = dbManager.RecievedOrdersAndItems();

        }

        private void btnpudding_Click(object sender, EventArgs e)
        {

        }

        private void btncakes_Click(object sender, EventArgs e)
        {/*
            int a;
            DbManager dbManager = new DbManager();
            MenuItem menuItem = new MenuItem();
            a = dbManager.SelectHrina("cakes");
            dbManager.InsertRecievedOrdersAndItems(Data, a, 1); */
            Quantity quantity = new Quantity();
            quantity.Masa = Data;
            quantity.Hrana = "cakes";
            quantity.Show();
            //a = dbManager.SelectDajMasa(Data);
            //DataTable data = dbManager.SelectRecievedOrdersAndItems(a);
            //dataGridView1.DataSource = data;
            //MessageBox.Show("predpolagam zapisano?","niznam?", MessageBoxButtons.OK);
            

        }
        private void btnicecream_Click(object sender, EventArgs e)
        {/*
            int a;
            DbManager dbManager = new DbManager();
            MenuItem menuItem = new MenuItem();
            a = dbManager.SelectHrina("ice cream");
            dbManager.InsertRecievedOrdersAndItems(Data, a, 1);*/
            Quantity quantity = new Quantity();
            quantity.Masa = Data;
            quantity.Hrana = "ice cream";
            quantity.Show();
            //a = dbManager.SelectDajMasa(Data);
            //DataTable data = dbManager.SelectRecievedOrdersAndItems(a);
            //dataGridView1.DataSource = data;
            
        }

        private void btncoffe_Click(object sender, EventArgs e)
        {/*
            int a;
            DbManager dbManager = new DbManager();
            MenuItem menuItem = new MenuItem();
            a = dbManager.SelectHrina("coffe");
            dbManager.InsertRecievedOrdersAndItems(Data, a, 1);*/
            Quantity quantity = new Quantity();
            quantity.Masa = Data;
            quantity.Hrana = "coffe";
            quantity.Show();
            //a = dbManager.SelectDajMasa(Data);
            //DataTable data = dbManager.SelectRecievedOrdersAndItems(a);
            //dataGridView1.DataSource = data;
            
        }

        private void btntea_Click(object sender, EventArgs e)
        {/*
            int a;
            DbManager dbManager = new DbManager();
            MenuItem menuItem = new MenuItem();
            a = dbManager.SelectHrina("tea");
            dbManager.InsertRecievedOrdersAndItems(Data, a, 1);*/
            Quantity quantity = new Quantity();
            quantity.Masa = Data;
            quantity.Hrana = "tea";
            quantity.Show();
            //a = dbManager.SelectDajMasa(Data);
            //DataTable data = dbManager.SelectRecievedOrdersAndItems(a);
            //dataGridView1.DataSource = data;
            
        }

        private void btnjuice_Click(object sender, EventArgs e)
        {/*
            int a;
            DbManager dbManager = new DbManager();
            MenuItem menuItem = new MenuItem();
            a = dbManager.SelectHrina("juice");
            dbManager.InsertRecievedOrdersAndItems(Data, a, 1);*/
            Quantity quantity = new Quantity();
            quantity.Masa = Data;
            quantity.Hrana = "juice";
            quantity.Show();
            //a = dbManager.SelectDajMasa(Data);
            //DataTable data = dbManager.SelectRecievedOrdersAndItems(a);
            //dataGridView1.DataSource = data;
            
        }

        private void btncarbonated_Click(object sender, EventArgs e)
        {/*
            int a;
            DbManager dbManager = new DbManager();
            MenuItem menuItem = new MenuItem();
            a = dbManager.SelectHrina("carbonated water");
            dbManager.InsertRecievedOrdersAndItems(Data, a, 1);*/
            Quantity quantity = new Quantity();
            quantity.Masa = Data;
            quantity.Hrana = "carbonated water";
            quantity.Show();
            //a = dbManager.SelectDajMasa(Data);
            //DataTable data = dbManager.SelectRecievedOrdersAndItems(a);
            //dataGridView1.DataSource = data;
            
        }

        private void btnsoftdrinks_Click(object sender, EventArgs e)
        {/*
            int a;
            DbManager dbManager = new DbManager();
            MenuItem menuItem = new MenuItem();
            a = dbManager.SelectHrina("soft drinks");
            dbManager.InsertRecievedOrdersAndItems(Data, a, 1);*/
            Quantity quantity = new Quantity();
            quantity.Masa = Data;
            quantity.Hrana = "soft drinks";
            quantity.Show();
            //a = dbManager.SelectDajMasa(Data);
            //DataTable data = dbManager.SelectRecievedOrdersAndItems(a);
            //dataGridView1.DataSource = data;
            
        }

        private void btnotherdrinks_Click(object sender, EventArgs e)
        {/*
            int a;
            DbManager dbManager = new DbManager();
            MenuItem menuItem = new MenuItem();
            a = dbManager.SelectHrina("other drinks");
            dbManager.InsertRecievedOrdersAndItems(Data, a, 1);*/
            Quantity quantity = new Quantity();
            quantity.Masa = Data;
            quantity.Hrana = "other drinks";
            quantity.Show();
            //a = dbManager.SelectDajMasa(Data);
            //DataTable data = dbManager.SelectRecievedOrdersAndItems(a);
            //dataGridView1.DataSource = data;
            
        }

        private void btnpizza_Click(object sender, EventArgs e)
        {/*
            int a;
            DbManager dbManager = new DbManager();
            MenuItem menuItem = new MenuItem();
            a = dbManager.SelectHrina("pizza");
            dbManager.InsertRecievedOrdersAndItems(Data, a, 1);*/
            Quantity quantity = new Quantity();
            quantity.Masa = Data;
            quantity.Hrana = "pizza";
            quantity.Show();
            //a = dbManager.SelectDajMasa(Data);
            //DataTable data = dbManager.SelectRecievedOrdersAndItems(a);
            //dataGridView1.DataSource = data;
            
        }

        private void btnchicken_Click(object sender, EventArgs e)
        {/*
            int a;
            DbManager dbManager = new DbManager();
            MenuItem menuItem = new MenuItem();
            a = dbManager.SelectHrina("chicken");
            dbManager.InsertRecievedOrdersAndItems(Data, a, 1);*/
            Quantity quantity = new Quantity();
            quantity.Masa = Data;
            quantity.Hrana = "chicken";
            quantity.Show();
            //a = dbManager.SelectDajMasa(Data);
            //DataTable data = dbManager.SelectRecievedOrdersAndItems(a);
            //dataGridView1.DataSource = data;
            
        }

        private void btnseafood_Click(object sender, EventArgs e)
        {/*
            int a;
            DbManager dbManager = new DbManager();
            MenuItem menuItem = new MenuItem();
            a = dbManager.SelectHrina("seafood");
            dbManager.InsertRecievedOrdersAndItems(Data, a, 1);*/
            Quantity quantity = new Quantity();
            quantity.Masa = Data;
            quantity.Hrana = "seafood";
            quantity.Show();
            //a = dbManager.SelectDajMasa(Data);
            //DataTable data = dbManager.SelectRecievedOrdersAndItems(a);
            //dataGridView1.DataSource = data;
            
        }

        private void btnbbq_Click(object sender, EventArgs e)
        {/*
            int a;
            DbManager dbManager = new DbManager();
            MenuItem menuItem = new MenuItem();
            a = dbManager.SelectHrina("bbq");
            dbManager.InsertRecievedOrdersAndItems(Data, a, 1);*/
            Quantity quantity = new Quantity();
            quantity.Masa = Data;
            quantity.Hrana = "bbq";
            quantity.Show();
            //a = dbManager.SelectDajMasa(Data);
            //DataTable data = dbManager.SelectRecievedOrdersAndItems(a);
            //dataGridView1.DataSource = data;
            
        }

        private void btnsushi_Click(object sender, EventArgs e)
        {/*
            int a;
            DbManager dbManager = new DbManager();
            MenuItem menuItem = new MenuItem();
            a = dbManager.SelectHrina("sushi");
            dbManager.InsertRecievedOrdersAndItems(Data, a, 1);*/
            Quantity quantity = new Quantity();
            quantity.Masa = Data;
            quantity.Hrana = "sushi";
            quantity.Show();
            //a = dbManager.SelectDajMasa(Data);
            //DataTable data = dbManager.SelectRecievedOrdersAndItems(a);
            //dataGridView1.DataSource = data;
            
        }

        private void btnother_Click(object sender, EventArgs e)
        {/*
            int a;
            int b;
            DbManager dbManager = new DbManager();
            MenuItem menuItem = new MenuItem();
            b = 0;
            a = dbManager.SelectHrina("kebab");
            dbManager.InsertRecievedOrdersAndItems(Data, a, 1);*/
            Quantity quantity = new Quantity();
            quantity.Masa = Data;
            quantity.Hrana = "kebab";
            quantity.Show();
            //a = dbManager.SelectDajMasa(Data);
            //DataTable data = dbManager.SelectRecievedOrdersAndItems(a);
            //dataGridView1.DataSource = data;
            
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
    }
}

