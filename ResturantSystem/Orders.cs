using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantSystem
{
    public class Orders
    {
        private int order_id;
        private int customer_id;
        private int masi_id;
        private string order_date;
        private decimal total_amount;
        private string pickup_date;

        public Orders()
        {

        }
        public Orders(string order_date, decimal total_amount, string pickup_date)
        {
            this.order_date = order_date;
            this.total_amount = total_amount;
            this.pickup_date = pickup_date;
        }

        public int Order_id { get => order_id; set => order_id = value; }
        public int Customer_id { get => customer_id; set => customer_id = value; }
        public int Masi_id { get => masi_id; set => masi_id = value; }
        public string Order_date { get => order_date; set => order_date = value; }
        public decimal Total_amount { get => total_amount; set => total_amount = value; }
        public string Pickup_date { get => pickup_date; set => pickup_date = value; }
    }
}
