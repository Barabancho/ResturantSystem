using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantSystem
{
    public class MenuItem
    {
        private int menu_item_id;
        private string menu_name;
        private decimal menu_price;
        private string menu_description;

        public MenuItem()
        {

        }
        public MenuItem(string menu_name, decimal menu_price, string menu_description)
        {
            this.menu_name = menu_name;
            this.menu_price = menu_price;
            this.menu_description = menu_description;
        }

        public int Menu_item_id { get => menu_item_id; set => menu_item_id = value; }
        public string Menu_name { get => menu_name; set => menu_name = value; }
        public decimal Menu_price { get => menu_price; set => menu_price = value; }
        public string Menu_description { get => menu_description; set => menu_description = value; }
    }
}
