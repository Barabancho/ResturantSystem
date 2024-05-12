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
        private string menu_ime;
        private decimal menu_price;
        private string menu_description;
        private int menu_quantity;

        public MenuItem()
        {

        }
        public MenuItem(string menu_ime, decimal menu_price, string menu_description, int menu_quantity)
        {
            this.menu_ime = menu_ime;
            this.menu_price = menu_price;
            this.menu_description = menu_description;
            this.menu_quantity = menu_quantity;
        }

        public int Menu_item_id { get => menu_item_id; set => menu_item_id = value; }
        public string Menu_ime { get => menu_ime; set => menu_ime = value; }
        public decimal Menu_price { get => menu_price; set => menu_price = value; }
        public string Menu_description { get => menu_description; set => menu_description = value; }
        public int Menu_quantity { get => menu_quantity; set => menu_quantity = value; }
    }
}
