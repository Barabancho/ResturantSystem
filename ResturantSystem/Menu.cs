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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            panelfoods.Visible = true;
            pnldrinks.Visible = false;
            paneldesserts.Visible = false;
            panel9.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            panelfoods.Visible = false;
            pnldrinks.Visible = false;
            paneldesserts.Visible = true;
            panel9.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            panelfoods.Visible = true;
            pnldrinks.Visible = false;
            paneldesserts.Visible = false;
            panel9.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            panelfoods.Visible = false;
            pnldrinks.Visible = true;
            paneldesserts.Visible = false;
            panel9.Visible = false;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            panelfoods.Visible = false;
            pnldrinks.Visible = false;
            paneldesserts.Visible = false;
            panel9.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnltop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void pnlfoods_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnicecream_Click(object sender, EventArgs e)
        {

        }
       




        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btncakes_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            //Boss boss = new Boss();
            Options options = new Options(Login.entBoss.Role = "waiter");
            options.Show();
            this.Hide();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
                                                                                                                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
          
        }

        private void pnlpudding_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paneldesserts_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
