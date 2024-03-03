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
    public partial class User : Form
    {
        int id =0;
        public Operator data;
        public User()
        {
            InitializeComponent();
        }
        private void User_Load(object sender, EventArgs e)
        {
            data.lihat("user", dataGridView1, "", 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            data.tambah_user(Nama.Text, data.Enkripsi(Password.Text) ,User_txt.Text);
            User_Load(sender, e);
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
                    Password.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    User_txt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                data.update_user(id, Nama.Text, data.Enkripsi(Password.Text), User_txt.Text);
                User_Load(sender, e);
            }
            else MessageBox.Show("pilih user yang akan di update");
            button4_Click(sender, e);


        }
        private void refresh_Click(object sender, EventArgs e)
        {
            User_Load(sender, e);
            button4_Click(sender, e);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                DialogResult result = MessageBox.Show("Apakah anda ingin menghapus user ini ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    data.Hapus("user", id);
                    User_Load(sender, e);
                }
            }
            else MessageBox.Show("pilih user yang akan dihapus");
            button4_Click(sender, e);

        }
        private void button4_Click(object sender, EventArgs e)
        {
            Nama.Clear();
            Password.Clear();
            User_txt.Text = "";
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
                    User_Load(sender, e);
                }
            }
        }
    }
}
