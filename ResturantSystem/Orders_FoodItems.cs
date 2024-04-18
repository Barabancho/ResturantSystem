using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantSystem
{
    public class Orders_FoodItems
    {
        private int id;
        private int menuItem;
        private int masiId;

        public int Id { get => id; set => id = value; }
        public int MenuItem { get => menuItem; set => menuItem = value; }
        public int MasiId { get => masiId; set => masiId = value; }

        public Orders_FoodItems(int menuItem, int masiId)
        {
            this.menuItem = menuItem;
            this.masiId = masiId;
        }
        public Orders_FoodItems()
        {

            
        }
    }
}
