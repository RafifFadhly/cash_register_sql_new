using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kasir_pro_database
{
    public partial class barang : Form
    {
        int id = 0;
        public Operator data;
        public barang()
        {
            InitializeComponent();
        }

        private void barang_Load(object sender, EventArgs e)
        {
            if (Stok_dikit.Checked) data.lihat("barang", dataGridView1, " where stok <= ", (int)Stok_kurang.Value);
            else data.lihat("barang", dataGridView1, "", 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data.tambah_barang(Nama.Text, (int)Stok.Value, (int)Harga.Value, (int)Laba_N.Value, (int)Diskon.Value);
            barang_Load(sender, e);
            button4_Click(sender, e);
            MessageBox.Show("barang berhasil di Tambah");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                DialogResult result = MessageBox.Show("Apakah anda ingin menghapus barang ini ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    data.Hapus("barang", id);
                    barang_Load(sender, e);
                }
            }
            else MessageBox.Show("pilih dulu barang yang akan di hapus");
            button4_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                data.update_barang(id, Nama.Text, (int)Stok.Value, (int)Harga.Value,(int)Laba_N.Value, (int)Diskon.Value);
                barang_Load(sender, e);
                MessageBox.Show("barang berhasil di update");
            }
            else MessageBox.Show("pilih dulu barang yang akan di update");
            button4_Click(sender, e);
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            barang_Load(sender, e);
            button4_Click(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].Cells[0].Value != null)
                {
                    id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    Nama.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    Stok.Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value);
                    Harga.Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value);
                    Laba_N.Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[4].Value);
                    Diskon.Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[5].Value);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Nama.Clear();
            id = 0;
            Stok.Value = 0;
            Harga.Value = 0;
            Diskon.Value = 0;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (cari_txt.Text != null)
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
                    barang_Load(sender, e);
                }
            }
        }

        private void Stok_dikit_CheckedChanged(object sender, EventArgs e)
        {
            barang_Load(sender, e);
        }
    }
}
