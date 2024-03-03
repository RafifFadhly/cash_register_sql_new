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
    public partial class Ganti_Password : Form
    {
        public Operator data;
        public string nama;
        public string user;
        public Ganti_Password()
        {
            InitializeComponent();
        }

        private void ganti_pw_btn_Click(object sender, EventArgs e)
        {
            if (Nama.Text.ToLower() == nama.ToLower())
            {
                DialogResult result = MessageBox.Show("ganti password ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    data.update_user(0, Nama.Text, data.Enkripsi(Password_baru.Text), user);
                    Nama.Clear();
                    Password_baru.Clear();
                }
            }
            else MessageBox.Show("Masukan username anda");
        }
    }
}
