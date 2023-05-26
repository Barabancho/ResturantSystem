using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantSystem
{
    public class Masi
    {
        private int masi_id;
        private string masi_number;
        private string capacity;
        private string taken;

        public Masi(string masi_number, string capacity, string taken)
        {
            this.masi_number = masi_number;
            this.capacity = capacity;
            this.taken = taken;
        }
        public Masi()
        {
        }

        public int Masi_id { get => masi_id; set => masi_id = value; }
        public string Masi_number { get => masi_number; set => masi_number = value; }
        public string Capacity { get => capacity; set => capacity = value; }
        public string Taken { get => taken; set => taken = value; }
    }
}
