using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.IsisMtt.X509;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kasir_pro_database
{

    //backend
    static class Database
    {
        private static MySqlConnection connection;
        public static MySqlConnection Connection
        {
            get
            {
                string connectionString = "Server=localhost;Database=kasir;Uid=root;Pwd=;";
                connection = new MySqlConnection(connectionString);
                return connection;
            }
        }
    }

    public class Operator
    {
        string sql;
        public void lihat(string tabel, DataGridView data, string tambahan, int tambah)
        {
            using (MySqlConnection connection = Database.Connection)
            {
                connection.Open();
                sql = "SELECT * FROM " + tabel;
                if(tambah != 0) sql = "SELECT * FROM " + tabel + tambahan+ "'" + tambah.ToString()+ "'";
                MySqlCommand command = new MySqlCommand(sql, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    data.Rows.Clear();
                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {
                            object[] row = new object[reader.FieldCount];
                            reader.GetValues(row);
                            data.Rows.Add(row);
                        }
                    }
                }
            }
        }

        public void tambah_barang(string nama, int stok, int harga,int laba, int diskon)
        {
            using (MySqlConnection connection = Database.Connection)
            {
                connection.Open();
                sql = "INSERT INTO barang (id,nama, stok, harga,laba, diskon) VALUES (@id,@nama, @stok, @harga, @laba, @diskon)";
                MySqlCommand command = new MySqlCommand(sql, connection);
                
                command.Parameters.AddWithValue("@id", Id("barang"));
                command.Parameters.AddWithValue("@nama", nama);
                command.Parameters.AddWithValue("@stok", stok);
                command.Parameters.AddWithValue("@harga", harga);
                command.Parameters.AddWithValue("@laba", laba);
                command.Parameters.AddWithValue("@diskon", diskon);

                command.ExecuteNonQuery();
            }
        }

        public void Hapus(string tabel, int id)
        {
            using (MySqlConnection connection = Database.Connection)
            {
                connection.Open();
                sql = "DELETE FROM "+tabel+" WHERE id = @id";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }


        public void tambah_user(string nama, string password, string user)
        {
            using (MySqlConnection connection = Database.Connection)
            {
                connection.Open();
                sql = "INSERT INTO user (id, nama, password, user) VALUES (@id ,@nama, @password, @user)";
                MySqlCommand command = new MySqlCommand(sql, connection);

                command.Parameters.AddWithValue("@id", Id("user"));
                command.Parameters.AddWithValue("@nama", nama);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@user", user);

                command.ExecuteNonQuery();
            }
        }
        public void update_barang(int id, string nama, int stok, int harga,int laba, int diskon)
        {
            using (MySqlConnection connection = Database.Connection)
            {
                connection.Open();
                sql = "UPDATE barang SET nama = @nama, stok = @stok, harga = @harga,laba = @laba, diskon = @diskon WHERE id = @id";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@nama", nama);
                command.Parameters.AddWithValue("@stok", stok);
                command.Parameters.AddWithValue("@harga", harga);
                command.Parameters.AddWithValue("@laba", laba);
                command.Parameters.AddWithValue("@diskon", diskon);

                command.ExecuteNonQuery();
            }
        }

        public void update_user(int id, string nama, string password, string user)
        {
            using (MySqlConnection connection = Database.Connection)
            {
                connection.Open();
                sql = "UPDATE user SET nama = @nama, password = @password, user = @user WHERE id = @id OR nama = @nama";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@nama", nama);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@user", user);

                command.ExecuteNonQuery();
            }
        }


        public  void Login(TextBox Username_txt,TextBox Password_txt,Kasir menu,Form login)
        {
            using (MySqlConnection connection = Database.Connection)
            {
                connection.Open();
                sql = "SELECT * FROM user WHERE nama = @nama"; 
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@nama", Username_txt.Text);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string nama = reader.GetString("nama");
                    string pw = Deskripsi(reader.GetString("password"));
                    string user = reader.GetString("user");
                    if (Username_txt.Text == nama && Password_txt.Text == pw)
                    {
                        menu.nama = nama;
                        menu.user = user;
                        menu.buka_menu();
                    }
                    else MessageBox.Show("Username atau Password salah");
                }
                else MessageBox.Show("Username atau Password salah");
            }
        }
        public void tambah_pembayaran(string kasir, string pelanggan,int jml_barang, int total,int laba,DateTime date)
        {
            using (MySqlConnection connection = Database.Connection)
            {
                connection.Open();
                sql = "INSERT INTO pembayaran (id, kasir ,pelanggan, jml, total ,laba,waktu ) VALUES (@id,@kasir, @pelanggan, @jml, @total, @laba, @waktu)";
                MySqlCommand command = new MySqlCommand(sql, connection);

                command.Parameters.AddWithValue("@id", Id("pembayaran"));
                command.Parameters.AddWithValue("@kasir", kasir);
                command.Parameters.AddWithValue("@pelanggan", pelanggan);
                command.Parameters.AddWithValue("@jml", jml_barang);
                command.Parameters.AddWithValue("@total", total);
                command.Parameters.AddWithValue("@laba", laba);
                command.Parameters.AddWithValue("@waktu", date);

                command.ExecuteNonQuery();
            }
        }
        public void cek_tangggal()
        {
            using(MySqlConnection connection = Database.Connection)
            {
                connection.Open (); 
                string sql = "SELECT * FROM pembayaran";
                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    DateTime datedata = reader.GetDateTime("waktu");
                    int id = reader.GetInt32("id");

                    if (datedata.Month != DateTime.Now.Month)
                    {
                        Hapus("pembayaran", id);
                    }
                }
            }
        }






        public string Deskripsi(string pw)
        {
            string[] Kode = { "@", "$", "&", "!", "*", ":", "%", "?", "#", "+" };

            for (int i = 0; i < 10; i++)
            {
                if (pw.Contains((Kode[i]))) pw = pw.Replace(Kode[i], i.ToString());
            }

            return pw;
        }

        int Id(string tabel)
        {
            int hasil = 1;
            using (MySqlConnection connection = Database.Connection)
            {
                connection.Open();
                string sql = "SELECT id FROM " + tabel;
                MySqlCommand command = new MySqlCommand(sql, connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    List<int> Id = new List<int>();
                    while (reader.Read())
                    {
                        Id.Add(reader.GetInt32(0));
                    }

                    while (Id.Contains(hasil))
                    {
                        hasil++;
                    }
                }
            }
            return hasil;
        }
        public string Enkripsi(string pw)
        {
            string[] Kode = { "@", "$", "&", "!", "*", ":", "%", "?", "#", "+" };

            for (int i = 0; i < 10; i++)
            {
                if (pw.Contains(i.ToString())) pw = pw.Replace(i.ToString(), Kode[i]);
            }

            return pw;
        }
    }
}
