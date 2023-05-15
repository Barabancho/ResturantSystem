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
    public partial class Form4 : Form
    {
        private string connectionString = "Data Source=YourServerName;Initial Catalog=YourDatabaseName;Integrated Security=True";
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            DbManager db = new DbManager();
            dataGridView1.DataSource = db.SelectMenu();

        }

        private void button1_Click(object sender, EventArgs e)
        {/*
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Perform your INSERT operation here
                    // Replace the query and parameter placeholders with your own values
                    string query = "INSERT INTO YourTableName (column1, column2) VALUES (@value1, @value2)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@value1", "InsertValue1");
                    command.Parameters.AddWithValue("@value2", "InsertValue2");
                    command.ExecuteNonQuery();
                    MessageBox.Show("Insert operation successful!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {/*
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Perform your UPDATE operation here
                    // Replace the query and parameter placeholders with your own values
                    string query = "UPDATE YourTableName SET column1 = @value1 WHERE condition";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@value1", "UpdateValue1");
                    command.ExecuteNonQuery();
                    MessageBox.Show("Update operation successful!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {/*
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                // Perform your DELETE operation here
                // Replace the query and parameter placeholders with your own values
                string query = "DELETE FROM YourTableName WHERE condition";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Delete operation successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }*/

        }
    }
    
}
