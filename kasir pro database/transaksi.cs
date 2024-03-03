using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace kasir_pro_database
{
    public partial class transaksi : Form
    {
        public Operator data;
        public Kasir Parent;
        List<Barang> listBarang = new List<Barang>();
        double jml_barang;
        double laba;
        double total;
        public transaksi()
        {
            InitializeComponent();
        }

        private void transaksi_Load(object sender, EventArgs e)
        {
            data.lihat("barang", dataGridView1,"",0);
            karyawan.Text = Parent.nama;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Jumlah.Value != 0)
            {
                bool ada = false;
                int u = 0;
                total = (int)Jumlah.Value * ((int)Harga.Value - ((int)Harga.Value * ((int)Diskon.Value * 0.01)));
                laba = (int)Laba_N.Value * (int)Jumlah.Value;
                foreach (Barang getBarang in listBarang)
                {
                    if (Id.Value == getBarang.ID)
                    {
                        getBarang.Tambah_Barang((int)Id.Value, Nama.Text, (int)Stok.Value, (int)Harga.Value, (int)Laba_N.Value, (int)Diskon.Value, (int)Jumlah.Value, total,laba);
                        ada = true;
                        break;
                    }
                }
                if (!ada)
                {
                    Barang barang = new Barang();
                    barang.Tambah_Barang((int)Id.Value, Nama.Text, (int)Stok.Value, (int)Harga.Value, (int)Laba_N.Value, (int)Diskon.Value, (int)Jumlah.Value, total,laba);
                    listBarang.Add(barang);
                }
                hitung();
            }
            else MessageBox.Show("Masukan Jumlah Barang yang dibeli");
            refresh_datagrid2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Barang Beli = Selected_datagridview2();
            if (listBarang.Contains(Beli))
                listBarang.Remove(Beli);
            refresh_datagrid2();
            hitung();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Pelanggan.Text) && !string.IsNullOrEmpty(bayar.Value.ToString())&& !string.IsNullOrEmpty(Total.Text) && total <= (int)bayar.Value)
            {
                DialogResult result = MessageBox.Show("Apakah Transaksi sudah selesai ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    hitung();
                    Print print = new Print();
                    print.list.Text = "Kasir : " + karyawan.Text + Environment.NewLine + "pelanggan : " + Pelanggan.Text + Environment.NewLine + DateTime.Now + Environment.NewLine + Environment.NewLine;
                    foreach (Barang barang in listBarang)
                    {
                        data.update_barang(barang.ID, barang.Nama, barang.Stok - barang.Jumlah, barang.Harga, barang.Laba, barang.Diskon);
                        kembalian.Value =  (int)bayar.Value - Convert.ToInt32(total);
                        print.list.Text += barang.Nama + "  " + barang.Jumlah.ToString() + " x Rp." + barang.Harga.ToString() + Environment.NewLine;
                    }
                    print.list.Text += Environment.NewLine + Environment.NewLine + "Total Pembayaran : " + Total.Text;
                    print.list.Text += Environment.NewLine + "Bayar : " + bayar.Value.ToString();
                    print.list.Text += Environment.NewLine + "Kembalian : " + kembalian.Value.ToString();
                    print.Show();

                    data.tambah_pembayaran(karyawan.Text,Pelanggan.Text, Convert.ToInt32(jml_barang), Convert.ToInt32(total), Convert.ToInt32(laba), DateTime.Now);
                    button4_Click(sender, e);
                    transaksi_Load(sender, e);
                }
            }
            else MessageBox.Show("isi data dengan benar");
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].Cells[0].Value != null)
                {
                    Id.Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    Nama.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    Stok.Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value);
                    Harga.Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value);
                    Laba_N.Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[4].Value);
                    Diskon.Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[5].Value);
                }
                else
                {
                    MessageBox.Show("Nilai sel tidak tersedia!");
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            Total.Clear();
            Id.Value = 0;
            Nama.Clear();
            Stok.Value = 0;
            Harga.Value = 0;
            Diskon.Value = 0;
            Jumlah.Value = 0;
            Pelanggan.Clear();
            kembalian.Value = 0;
            bayar.Value = 0;
            listBarang.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            transaksi_Load(sender, e);
        }
        private void cari_txt_TextChanged(object sender, EventArgs e)
        {
            if(cari_txt.Text != null)
            {
                string searchText = cari_txt.Text.ToLower();
                bool found = false;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText))
                        {
                            dataGridView1.Rows.Clear();
                            dataGridView1.Rows.Add(row);
                            found = true;
                            break;
                        }
                    }
                    if (found) break;
                }

                if (!found)
                {
                    transaksi_Load(sender, e);
                }
            }
        }




        void hitung()
        {
            jml_barang = 0;
            total = 0;
            laba = 0;
            foreach (Barang getBarang in listBarang)
            {
                jml_barang += getBarang.Jumlah;
                total += getBarang.Total;
                laba += getBarang.Total_Laba;
            }
            Total.Text = total.ToString();
        }

        Barang Selected_datagridview2()
        {
            for (int i = 0; i < dataGridView2.Rows.Count; i += 1)
            {
                if (dataGridView2.Rows[i].Selected)
                {
                    int id = Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value);
                    Barang getbeli = new Barang();
                    foreach (Barang checkbeli in listBarang)
                    {
                        if (checkbeli.ID == id)
                            getbeli = checkbeli;
                    }
                    return getbeli;
                }
            }
            return null;
        }

        void refresh_datagrid2()
        {
            dataGridView2.Rows.Clear();
            foreach (Barang getBarang in listBarang)
            {
                string[] newRow = { "", "", "" ,""};
                newRow[0] = getBarang.ID.ToString();
                newRow[1] = getBarang.Nama.ToString();
                newRow[2] = getBarang.Jumlah.ToString();
                newRow[3] = getBarang.Total.ToString();
                dataGridView2.Rows.Add(newRow);
            }
        }
    }
}
