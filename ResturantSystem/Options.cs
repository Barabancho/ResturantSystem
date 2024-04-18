using ResturantSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ResturantSystem
{
    public partial class Options : Form
    {
        //public static Boss entboss;
        public Options(Boss boss)
        {
            InitializeComponent();
            //Login.entBoss = boss;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            label3.Visible = false;
            pictureBox2.Visible = true;
            panel4.Visible = false;
            pnl_dashboard.Visible = false;
            WelcomePanel.Visible = true;
            Tables tables = new Tables();
            tables.Close();





        }
        private bool isDashboardVisible = false;
        
        private void HideAllPanels()
        {
            pnl_dashboard.Hide();

            // Hide all other panels
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reservation form3 = new Reservation();


            form3.Show();


            this.Hide();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
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
            Menuchanges form4 = new Menuchanges();
            form4.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Reserved reserved = new Reserved();
            reserved.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private string userRole;

        public Options(string role)
        {
            InitializeComponent();
            userRole = role;
        }
       
        private void Options_Load(object sender, EventArgs e)
        {
            DbManager db = new DbManager();
            DbManager db1 = new DbManager();

            if (Login.entBoss != null)
            {
                if (Login.entBoss.Role == "admin")
                {
                    pnl_dashboard.Visible = false;
                    button1.Visible = false;
                    button2.Visible = true;
                    button6.Visible = false;
                    button7.Visible = true;
                    button5.Visible = true;
                    button4.Visible = true;
                    button9.Visible = true;
                    button10.Visible = false;
                    btn_dash.Visible = true;
                    btn_events.Visible = false;
                    button13.Visible = false;
                    button14.Visible = false;

                }
                else if (Login.entBoss.Role == "cook")
                {
                    button1.Visible = false;
                    button2.Visible = false;
                    button6.Visible = false;
                    button7.Visible = false;
                    button5.Visible = false;
                    button4.Visible = false;
                    button9.Visible = true;
                    button10.Visible = false;
                    btn_dash.Visible = false;
                    btn_events.Visible = true;
                    pnl_dashboard.Visible = false;
                    button13.Visible = true;
                    button14.Visible = true;
                    panel4.Hide();

                }
                else if (Login.entBoss.Role == "waiter")
                {
                    button1.Visible = true;
                    button2.Visible = true;
                    button6.Visible = true;
                    button7.Visible = true;
                    button5.Visible = false;
                    button4.Visible = false;
                    button9.Visible = false;
                    button10.Visible = true;
                    btn_dash.Visible = false;
                    btn_events.Visible = true;
                    pnl_dashboard.Visible = false;
                    button13.Visible = false;
                    button14.Visible = true;
                }

                else
                {
                    MessageBox.Show("Unauthorized access.");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Boss not found.");
                this.Close();
            }
            int a = 0;
            for (int i = 0; i < db1.SelectStaffRows("Manager"); i++)
            {
                a++;
                lbl_man.Text = Convert.ToString(a);
            }
            a = 0;
            for (int i = 0; i < db1.SelectStaffRows("Chef"); i++)
            {
                a++;
                lbl_chef.Text = Convert.ToString(a);
            }
            a = 0;
            for (int i = 0; i < db1.SelectStaffRows("Cook"); i++)
            {
                a++;
                lbl_cook.Text = Convert.ToString(a);
            }
            a = 0;
            for (int i = 0; i < db1.SelectStaffRows("Waiter"); i++)
            {
                a++;
                lbl_wait.Text = Convert.ToString(a);
            }
            a = 0;
            for (int i = 0; i < db1.SelectStaffRows("Bartender"); i++)
            {
                a++;
                lbl_bar.Text = Convert.ToString(a);
            }
            a = 0;
            for (int i = 0; i < db1.SelectStaffRows("Cleaner"); i++)
            {
                a++;
                lbl_clean.Text = Convert.ToString(a);
            }
           

        }
        private Timer timer;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            WelcomePanel.Visible = true; // Show the panel


            if (timer == null)
            {
                timer = new Timer();
                timer.Interval = 1500;
                timer.Tick += Timer_Tick;
            }

            timer.Start(); // Start or restart the timer
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            WelcomePanel.Visible = false;

        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Tables tables = new Tables();
            tables.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Registrations registrations = new Registrations();
            registrations.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void WelcomePanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WelcomePanel.Visible = false;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label2_DoubleClick(object sender, EventArgs e)
        {
            WelcomePanel.Visible = false;
        }

        private void btninfo_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            pictureBox2.Visible = false;
            pnl_dashboard.Visible = false;


        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btninfo_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            panel4.Visible = true;
            label3.Visible = false;
            pictureBox2.Visible = true;
            pnl_dashboard.Visible = false;

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_dash_Click(object sender, EventArgs e)
        {
            pnl_dashboard.Visible = true;
            panel4.Visible = false;
            label3.Visible = false;
            pictureBox2.Visible = false;
        }



        private void pnl_dashboard_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {

            Employee employee = new Employee();
            employee.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_clean_Click(object sender, EventArgs e)
        {

        }

        private void lbl_bar_Click(object sender, EventArgs e)
        {

        }

        private void lbl_wait_Click(object sender, EventArgs e)
        {

        }

        private void lbl_cook_Click(object sender, EventArgs e)
        {

        }

        private void lbl_chef_Click(object sender, EventArgs e)
        {

        }

        private void lbl_man_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void datagrid_events_dash_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            CheffOrder cheffOrder = new CheffOrder();
            cheffOrder.Show();
            this.Hide();
        }

        

        private void button14_Click_1(object sender, EventArgs e)
        {
            Grafici grafici = new Grafici();
            grafici.Show();
            this.Hide();
        }
    }
}
