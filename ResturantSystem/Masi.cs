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
        private string masi_capacity;
        private string masi_taken;

        public Masi(string masi_number, string masi_capacity, string masi_taken)
        {
            this.masi_number = masi_number;
            this.masi_capacity = masi_capacity;
            this.masi_taken = masi_taken;
        }
        public Masi()
        {
        }

        public int Masi_id { get => masi_id; set => masi_id = value; }
        public string Masi_number { get => masi_number; set => masi_number = value; }
        public string Masi_capacity { get => masi_capacity; set => masi_capacity = value; }
        public string Masi_taken { get => masi_taken; set => masi_taken = value; }
    }
}
