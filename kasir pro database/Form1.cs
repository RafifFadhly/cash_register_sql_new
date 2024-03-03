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
    public partial class Kasir : Form
    {
        public Operator data = new Operator();
        public string nama;
        public string user;
        private Form Form;

        private Login login;
        private User User;
        private pembayaran bayar;
        private Ganti_Password ganti_pw;
        private barang barang;
        private menu menu;
        private transaksi transaksi;

        public Kasir()
        {
            InitializeComponent();
        }

        private void Kasir_Load(object sender, EventArgs e)
        {
            data.cek_tangggal();
            login = new Login();
            login.data = data;
            login.parent = this;
            buka(login);
            menuStrip1.Hide();
        }

        private void transaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (transaksi == null) transaksi = new transaksi();
            transaksi.data = data;
            transaksi.Parent = this;
            buka(transaksi);
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buka(menu);
        }


        private void barangToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (barang == null) barang = new barang();
            barang.data = data;
            buka(barang);
        }

        private void userToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (User == null) User = new User();
            User.data = data;
            buka(User);
        }

        private void pendapatanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bayar == null) bayar = new pembayaran();
            bayar.data = data;
            buka(bayar);
        }
        private void ganriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ganti_pw == null) ganti_pw = new Ganti_Password();
            ganti_pw.data = data;
            ganti_pw.user = user;
            ganti_pw.nama = nama;
            buka(ganti_pw);
        }
        void buka(Form form)
        {
            if(Form != null)Form.Hide();
            Form = form;
            Form.MdiParent = this;
            Form.Show();
        }

        public void buka_menu()
        {
            menuStrip1.Show();
            if (user != "admin") adminToolStripMenuItem.Visible = false;
            else adminToolStripMenuItem.Visible = true;
            if (menu == null) menu = new menu();
            menu.data = data;
            buka(menu);
        }

    }
}
