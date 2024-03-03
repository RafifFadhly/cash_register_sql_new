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
    public partial class pembayaran : Form
    {
        public Operator data;
        public pembayaran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pembayaran_Load(sender, e);
        }

        private void pembayaran_Load(object sender, EventArgs e)
        {
            data.lihat("pembayaran", dataGridView1, "", 0);

        }
    }
}
