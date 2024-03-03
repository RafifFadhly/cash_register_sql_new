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
    public partial class Login : Form
    {
        public Operator data;
        public Kasir parent;
        public Login()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (user_txt.Text == null || Password_txt.Text == null) MessageBox.Show("isi dengan lengkap");
            else data.Login(user_txt, Password_txt, parent, this);
        }
    }
}
