using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResturantSystem
{
    public class DbManager
    {
        private static DbManager instance = null;
        private string connectionString;
        private SqlConnection connection;
        public DbManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DbManager();
                }
                return instance;
            }
        }

        public DbManager()
        {
            try
            {
                connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"" + Path.GetFullPath(Directory.GetCurrentDirectory() + "\\..\\..\\Database1.mdf") + "\";Integrated Security=True";
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void Dispose()
        {
            connection.Close();
            instance = null;
        }
        public DataTable SelectMenu()
        {

            SqlCommand cmd = new SqlCommand("Select * FROM MenuItem", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();
            return table;
        }
        public bool InsertMenuItem(MenuItem menuItem)
        {
            SqlCommand cmd = new SqlCommand("Insert into MenuItem VALUES(" +
            "@ime,@price,@opis)", connection);
            cmd.Parameters.AddWithValue("@ime", menuItem.Menu_name);
            cmd.Parameters.AddWithValue("@price", menuItem.Menu_price);
            cmd.Parameters.AddWithValue("@opis", menuItem.Menu_description);

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool DeleteMenuItem(MenuItem menuItem)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM MenuItem WHERE menu_item_id=@id ", connection);
            cmd.Parameters.AddWithValue("@id", menuItem.Menu_item_id);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool UpdateMenuItem(MenuItem menuItem)
        {
            SqlCommand cmd = new SqlCommand("Update From MenuItem SET ime = @ime, price = @price, opisanie = @opisanie Where menu_item_id=@id", connection);
            cmd.Parameters.AddWithValue("@id", menuItem.Menu_item_id);
            cmd.Parameters.AddWithValue("@ime", menuItem.Menu_name);
            cmd.Parameters.AddWithValue("@price", menuItem.Menu_price);
            cmd.Parameters.AddWithValue("@opisanie", menuItem.Menu_description);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
