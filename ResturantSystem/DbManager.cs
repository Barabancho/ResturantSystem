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
        //public int Data { get; set; }
        //public int Base { get; set; }
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
                //connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Database1_OLD;Persist Security Info=True;User ID=nmb; Password=nos";
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




        private DataTable cachedMenu;
        private DateTime menuLastUpdated;
        private TimeSpan cacheExpirationTime = TimeSpan.FromMinutes(5);

        public DataTable SelectMenu()
        {
            if (cachedMenu == null || DateTime.Now - menuLastUpdated > cacheExpirationTime)
            {
                SqlCommand cmd = new SqlCommand("Select * FROM MenuItem", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                adapter.Dispose();
                cachedMenu = table;
                menuLastUpdated = DateTime.Now;
            }
            return cachedMenu;
        }
        public bool InsertMenuItem(MenuItem menuItem)
        {
            SqlCommand cmd = new SqlCommand("Insert into MenuItem VALUES(" +
            "@ime,@price,@opis)", connection);
            cmd.Parameters.AddWithValue("@ime", menuItem.Menu_name);
            cmd.Parameters.AddWithValue("@price", menuItem.Menu_price);
            cmd.Parameters.AddWithValue("@opis", menuItem.Menu_description);
            cmd.Parameters.AddWithValue("@quantity", menuItem.Menu_description);

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
            SqlCommand cmd = new SqlCommand("Update MenuItem SET ime = @ime, price = @price, opisanie = @opisanie Where menu_item_id=@id", connection);
            cmd.Parameters.AddWithValue("@ime", menuItem.Menu_name);
            cmd.Parameters.AddWithValue("@price", menuItem.Menu_price);
            cmd.Parameters.AddWithValue("@opisanie", menuItem.Menu_description);
            cmd.Parameters.AddWithValue("@id", menuItem.Menu_item_id);
            cmd.Parameters.AddWithValue("@quantity", menuItem.Menu_item_id);
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





        public DataTable SelectReservation()
        {

            SqlCommand cmd = new SqlCommand("Select * FROM Reservations", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();
            return table;
        }
        public bool DeleteReservation(Reservations reservations)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Reservations WHERE reservation_id=@id ", connection);
            cmd.Parameters.AddWithValue("@id", reservations.Reservation_id);
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
        public bool InsertReservation(Reservations reservations)
        {
            SqlCommand cmd = new SqlCommand("Insert into Reservations VALUES(" +
            "@reservation_date,@capacity,@fname,@lname,@email,@phone_number)", connection);
            cmd.Parameters.AddWithValue("@reservation_date", reservations.Reservation_date);
            cmd.Parameters.AddWithValue("@capacity", reservations.Capacity);
            cmd.Parameters.AddWithValue("@fname", reservations.Fname);
            cmd.Parameters.AddWithValue("@lname", reservations.Lname);
            cmd.Parameters.AddWithValue("@email", reservations.Email);
            cmd.Parameters.AddWithValue("@phone_number", reservations.Phone_number);

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





        public DataTable SelectBoss()
        {
            SqlCommand cmd = new SqlCommand("Select * FROM Boss ", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();
            return table;
        }
        public bool DeleteBoss(Boss boss)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Boss WHERE boss_id=@id ", connection);
            cmd.Parameters.AddWithValue("@id", boss.Boss_id);
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
        public bool InsertBoss(Boss boss)
        {
            SqlCommand cmd = new SqlCommand("Insert into Boss VALUES(" +
            "@username,@email,@phone_number,@role,@password)", connection);
            cmd.Parameters.AddWithValue("@Usernamae", boss.Username);
            cmd.Parameters.AddWithValue("@email", boss.Email);
            cmd.Parameters.AddWithValue("@phone_number", boss.Phone_number);
            cmd.Parameters.AddWithValue("@role", boss.Role);
            cmd.Parameters.AddWithValue("@password", boss.Password);

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
        public bool SelectAcc(Boss boss)
        {
            SqlCommand cmd = new SqlCommand("Select * FROM Boss WHERE username=@username AND password=@password", connection);
            cmd.Parameters.AddWithValue("@username", boss.Username);
            cmd.Parameters.AddWithValue("@password", boss.Password);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();
            if (table != null) return true;
            else return false;
        }/*


        public DataTable SelectRole(Boss boss)
        {
            SqlCommand cmd = new SqlCommand("Select * FROM Boss WHERE role=@role", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();
            return table;
        }*/
        public Boss RetrieveBossByUsername(string username)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Boss WHERE username = @username", connection);
            cmd.Parameters.AddWithValue("@username", username);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();

            if (table != null && table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];

                Boss boss = new Boss();
                boss.Username = row["username"].ToString();
                boss.Email = row["email"].ToString();
                boss.Phone_number = row["phone_number"].ToString();
                boss.Role = row["role"].ToString();
                boss.Password = row["password"].ToString();

                return boss;
            }
            else
            {
                return null;
            }
        }





        public DataTable SelectEmployee()
        {
            SqlCommand cmd = new SqlCommand("Select * FROM EmployeeSchedules", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();
            return table;
        }
        public bool DeleteEmployee(int x)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM EmployeeSchedules WHERE schedule_id=@id ", connection);
            cmd.Parameters.AddWithValue("@id", x);
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
        public bool InsertEmployee(EmployeeSchedules employee)
        {
            SqlCommand cmd = new SqlCommand("Insert into EmployeeSchedules VALUES(" +
            "@start_time,@end_date,@day_of_week,@fname,@lname,@email,@phone_number,@position)", connection);
            cmd.Parameters.AddWithValue("@start_time", employee.Start_time);
            cmd.Parameters.AddWithValue("@end_date", employee.End_time);
            cmd.Parameters.AddWithValue("@day_of_week", employee.Day_of_week);
            cmd.Parameters.AddWithValue("@fname", employee.Fname);
            cmd.Parameters.AddWithValue("lname", employee.Lname);
            cmd.Parameters.AddWithValue("email", employee.Email);
            cmd.Parameters.AddWithValue("phone_number", employee.Phone_number);
            cmd.Parameters.AddWithValue("position", employee.Position);

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



        /*
        public DataTable SelectMasi()
        {

            SqlCommand cmd = new SqlCommand("Select * FROM Masi", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();
            return table;
        }*/
        public DataTable GetMasiData()
        {
            SqlCommand cmd = new SqlCommand("Select * FROM Masi", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();
            return table;
        }

        public DataTable SelectMasiTakenTrue()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM MASI WHERE taken='true'", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();
            if (table != null) return table;
            else return null;
        }
        public DataTable SelectMasiTakenFalse()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM MASI WHERE taken='false'", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();
            if (table != null) return table;
            else return null;
        }
        public bool InsertMasi(Masi masi)
        {
            SqlCommand cmd = new SqlCommand("Insert into Masi VALUES(" +
            "@masi_number,@capacity,@taken)", connection);
            cmd.Parameters.AddWithValue("@masi_number", masi.Masi_number);
            cmd.Parameters.AddWithValue("@capacity", masi.Capacity);
            cmd.Parameters.AddWithValue("@taken", masi.Taken);

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
        public bool DeleteMasi(Masi masi)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Masi WHERE masi_id=@id ", connection);
            cmd.Parameters.AddWithValue("@id", masi.Masi_id);
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
        public bool UpdateMasi(Masi masi)
        {
            SqlCommand cmd = new SqlCommand("Update Masi SET masi_number=@masi_number, capacity=@capacity Where masi_id=@id", connection);
            cmd.Parameters.AddWithValue("@masi_number", masi.Masi_number);
            cmd.Parameters.AddWithValue("@capacity", masi.Capacity);
            //cmd.Parameters.AddWithValue("@taken", masi.Taken);
            cmd.Parameters.AddWithValue("@id", masi.Masi_id);
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
        public bool UpdateMasiTaken(Masi masi)
        {
            SqlCommand cmd = new SqlCommand("Update Masi SET taken=@taken Where masi_id=@id", connection);//masi_number=@masi_number, capacity=@capacity, 
            //cmd.Parameters.AddWithValue("@masi_number", masi.Masi_number);
            //cmd.Parameters.AddWithValue("@capacity", masi.Capacity);
            cmd.Parameters.AddWithValue("@taken", masi.Taken);
            cmd.Parameters.AddWithValue("@id", masi.Masi_id);
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
        public int SelectStaffRows(string a)
        {
            SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM EmployeeSchedules WHERE position = @ColumnValue", connection);
            cmd.Parameters.AddWithValue("@ColumnValue", a);
            int rowCount = Convert.ToInt32(cmd.ExecuteScalar());
            return rowCount;
        }

        public DataTable RecievedOrdersAndItems()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Orders_FoodItems JOIN MenuItem on Orders_FoodItems.menuItem = MenuItem.menu_item_id JOIN Masi on Orders_FoodItems.masiId = masi.masi_id",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            adapter.Dispose();
            return dt;
        }
        
        public DataTable SelectDaKajemDAJ(int a)
        {
            SqlCommand cmd = new SqlCommand($"SELECT MenuItem.ime,MenuItem.price,Orders_FoodItems.quantity\r\n" +
                $"FROM Orders_FoodItems INNER JOIN MenuItem ON Orders_FoodItems.MenuItem = MenuItem.menu_item_id\r\n" +
                $"WHERE Orders_FoodItems.masiId = {a};", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();
            if (table != null) return table;
            else return null;
        }
        public bool InsertRecievedOrdersAndItems(int Data, int Base, int Quantity)
        {
            //Orders_FoodItems orders_FoodItems,
            //int id;
            SqlCommand cmd = new SqlCommand("Insert into Orders_FoodItems VALUES(" +
            "@menuItem,@masiId,@quantity)", connection);
            cmd.Parameters.AddWithValue("@menuItem", Base);
            cmd.Parameters.AddWithValue("@masiId",Data);
            cmd.Parameters.AddWithValue("@quantity", Quantity);
            

            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }/*
        public DataTable SelectHirina(string hrina)
        {
            SqlCommand ko = new SqlCommand($"SELECT menu_item_id FROM MenuItem WHERE ime = '{hrina}'", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(ko);
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();/*
            if (table != null) return table;
            else *//*return null;
        }*/
        public int SelectHrina(string hrina)
        {
            int id = -1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand ko = new SqlCommand($"SELECT menu_item_id FROM MenuItem WHERE ime = '{hrina}'", connection))
                {
                    using (SqlDataReader reader = ko.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            id = reader.GetInt32(0);
                        }
                    }
                }
            }
            return id;
        }
        public bool DeleteDaIma(int a)
        {
            SqlCommand cmd = new SqlCommand("DELETE * FROM Orders_FoodItems WHERE masiId = @id", connection);
            cmd.Parameters.AddWithValue("@id", a);
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
        public DataTable SelectCheffOrder()
        {
            SqlCommand cmd = new SqlCommand($"SELECT MenuItem.ime,Orders_FoodItems.quantity\r\n" +
                $"FROM Orders_FoodItems INNER JOIN MenuItem ON Orders_FoodItems.MenuItem = MenuItem.menu_item_id\r\n" +
                $"WHERE Orders_FoodItems.masiId > 0;", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();
            if (table != null) return table;
            else return null;
        }
        public int SelectRevenue(string x, int a)
        {
            SqlCommand cmd = new SqlCommand($"SELECT COUNT({x})\r\n" +
                $"FROM Orders_FoodItems INNER JOIN MenuItem ON Orders_FoodItems.MenuItem = MenuItem.menu_item_id\r\n" +
                $"WHERE Orders_FoodItems.masiId = {a};", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();
            //if (table != null) return table;
            return Convert.ToInt32(cmd);
        }
        public bool DeleteTransfer(Orders_FoodItems orders_FoodItems)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Orders_FoodItems WHERE id=@id ", connection);
            cmd.Parameters.AddWithValue("@id", orders_FoodItems.Id);
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




        public int Select(string a)
        {
            SqlCommand cmd = new SqlCommand($"SELECT COUNT(*) FROM EmployeeSchedules WHERE position = @ColumnValue", connection);
            cmd.Parameters.AddWithValue("@ColumnValue", a);
            int rowCount = Convert.ToInt32(cmd.ExecuteScalar());
            return rowCount;
        }
    }
}
