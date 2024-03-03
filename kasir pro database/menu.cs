using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace kasir_pro_database
{
    public partial class menu : Form
    {
        public Operator data;

        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }


        DateTime current_dt;

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = Database.Connection)
            {
                chart1.Series["transaksi"].Points.Clear();
                int penghasilan = 0, laba = 0, jml = 0 ;

                connection.Open();
                string sql = "SELECT * FROM pembayaran";
                MySqlCommand command = new MySqlCommand(sql, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    int u = 0;
                    while (reader.Read())
                    {
                        DateTime dt = reader.GetDateTime("waktu");
                        penghasilan += reader.GetInt32("total");
                        laba += reader.GetInt32("laba");
                        jml += reader.GetInt32("jml");
                        if (dt.Day == DateTime.Now.Day)
                        {


                            if (current_dt == null) current_dt = dt;
                            if (dt.Hour == current_dt.Hour)
                            {
                                u++;
                            }
                            else
                            {
                                chart1.Series["transaksi"].Points.AddXY(current_dt.Hour, u);
                                current_dt = dt;
                                u = 1;
                            }
                            current_dt = dt;
                        }
                    }
                    if (u > 0)
                    {
                        chart1.Series["transaksi"].Points.AddXY(current_dt.Hour, u);
                    }
                    pendapatan.Text = "Rp." + penghasilan.ToString()+",00";
                    keuntungan.Text = "Rp."+laba.ToString()+",00";
                    barang.Text = jml.ToString();

                }
            }

        }
    }
}
