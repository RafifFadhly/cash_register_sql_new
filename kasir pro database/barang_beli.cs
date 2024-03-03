using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kasir_pro_database
{
    public class Barang
    {
        private int ID1;
        private string Nama1;
        private int Stok1;
        private int Harga1;
        private int Laba1;
        private int Diskon1;
        private int Jumlah1;
        private double Total1;
        private double Total_Laba1;


        public int ID { get => ID1;}
        public string Nama { get => Nama1;}
        public int Stok { get => Stok1; }
        public int Harga { get => Harga1;}
        public int Laba { get => Laba1; }
        public int Diskon { get => Diskon1;}
        public int Jumlah { get => Jumlah1;}
        public double Total { get => Total1;}
        public double Total_Laba { get => Total_Laba1; }


        public void Tambah_Barang(int id, string nama, int stok, int harga,int laba, int diskon, int jml, double total, double Total_data)
        {
            ID1 = id;
            Nama1 = nama;
            Stok1 = stok;
            Harga1 = harga;
            Laba1 = laba;
            Diskon1 = diskon;
            Jumlah1 = jml;
            Total1 = total;
            Total_Laba1 = Total_data;
        }
    }
}