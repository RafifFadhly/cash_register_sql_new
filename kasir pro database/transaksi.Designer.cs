namespace kasir_pro_database
{
    partial class transaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.karyawan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Pelanggan = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.kembalian = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.bayar = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.NumericUpDown();
            this.Diskon = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Nama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Stok = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Harga = new System.Windows.Forms.NumericUpDown();
            this.Jumlah = new System.Windows.Forms.NumericUpDown();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cari_txt = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Laba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.Laba_N = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kembalian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bayar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Diskon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Harga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jumlah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Laba_N)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Laba,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(3, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(573, 687);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cari Barang";
            this.label1.Click += new System.EventHandler(this.cari_txt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Transaksi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.Jumlah);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.cari_txt);
            this.groupBox1.Controls.Add(this.Total);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1359, 788);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Barang";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(515, 16);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(61, 20);
            this.button6.TabIndex = 26;
            this.button6.Text = "Cari";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.cari_txt_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 738);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(573, 44);
            this.button5.TabIndex = 25;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(958, 738);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(179, 44);
            this.button4.TabIndex = 24;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(583, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(369, 44);
            this.button2.TabIndex = 23;
            this.button2.Text = "Beli";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.karyawan);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.Pelanggan);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.kembalian);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.bayar);
            this.groupBox3.Location = new System.Drawing.Point(583, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(764, 94);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informasi tambahan";
            // 
            // karyawan
            // 
            this.karyawan.Enabled = false;
            this.karyawan.Location = new System.Drawing.Point(71, 25);
            this.karyawan.Name = "karyawan";
            this.karyawan.ReadOnly = true;
            this.karyawan.Size = new System.Drawing.Size(292, 20);
            this.karyawan.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "karyawan";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Pelanggan";
            // 
            // Pelanggan
            // 
            this.Pelanggan.Location = new System.Drawing.Point(71, 51);
            this.Pelanggan.Name = "Pelanggan";
            this.Pelanggan.Size = new System.Drawing.Size(292, 20);
            this.Pelanggan.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(377, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Bayar";
            // 
            // kembalian
            // 
            this.kembalian.Enabled = false;
            this.kembalian.Location = new System.Drawing.Point(432, 53);
            this.kembalian.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.kembalian.Name = "kembalian";
            this.kembalian.ReadOnly = true;
            this.kembalian.Size = new System.Drawing.Size(301, 20);
            this.kembalian.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(377, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Kembali";
            // 
            // bayar
            // 
            this.bayar.Location = new System.Drawing.Point(432, 25);
            this.bayar.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.bayar.Name = "bayar";
            this.bayar.Size = new System.Drawing.Size(301, 20);
            this.bayar.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(955, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Pesanan";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(583, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 31);
            this.label9.TabIndex = 21;
            this.label9.Text = "Total Rp.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(590, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Jumlah";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Laba_N);
            this.groupBox2.Controls.Add(this.Id);
            this.groupBox2.Controls.Add(this.Diskon);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Nama);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Stok);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Harga);
            this.groupBox2.Location = new System.Drawing.Point(583, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 190);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "info Barang";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "ID";
            // 
            // Id
            // 
            this.Id.Enabled = false;
            this.Id.Location = new System.Drawing.Point(71, 25);
            this.Id.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Size = new System.Drawing.Size(292, 20);
            this.Id.TabIndex = 20;
            // 
            // Diskon
            // 
            this.Diskon.Enabled = false;
            this.Diskon.Location = new System.Drawing.Point(71, 133);
            this.Diskon.Name = "Diskon";
            this.Diskon.ReadOnly = true;
            this.Diskon.Size = new System.Drawing.Size(292, 20);
            this.Diskon.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Diskon (%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nama";
            // 
            // Nama
            // 
            this.Nama.Location = new System.Drawing.Point(71, 51);
            this.Nama.Name = "Nama";
            this.Nama.ReadOnly = true;
            this.Nama.Size = new System.Drawing.Size(292, 20);
            this.Nama.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Harga";
            // 
            // Stok
            // 
            this.Stok.Enabled = false;
            this.Stok.Location = new System.Drawing.Point(71, 107);
            this.Stok.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.Stok.Name = "Stok";
            this.Stok.ReadOnly = true;
            this.Stok.Size = new System.Drawing.Size(292, 20);
            this.Stok.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Stok";
            // 
            // Harga
            // 
            this.Harga.Enabled = false;
            this.Harga.Location = new System.Drawing.Point(71, 79);
            this.Harga.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.Harga.Name = "Harga";
            this.Harga.ReadOnly = true;
            this.Harga.Size = new System.Drawing.Size(292, 20);
            this.Harga.TabIndex = 15;
            // 
            // Jumlah
            // 
            this.Jumlah.Location = new System.Drawing.Point(654, 360);
            this.Jumlah.Name = "Jumlah";
            this.Jumlah.Size = new System.Drawing.Size(292, 20);
            this.Jumlah.TabIndex = 15;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView2.Location = new System.Drawing.Point(958, 180);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(389, 549);
            this.dataGridView2.TabIndex = 18;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ID";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 30;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Nama";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Jumlah";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Total";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // cari_txt
            // 
            this.cari_txt.Location = new System.Drawing.Point(72, 16);
            this.cari_txt.Name = "cari_txt";
            this.cari_txt.Size = new System.Drawing.Size(437, 20);
            this.cari_txt.TabIndex = 17;
            // 
            // Total
            // 
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(723, 16);
            this.Total.Multiline = true;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Size = new System.Drawing.Size(624, 42);
            this.Total.TabIndex = 8;
            this.Total.Text = "0";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1143, 738);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 44);
            this.button3.TabIndex = 7;
            this.button3.Text = "Hapus";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(369, 44);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 30;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nama";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Stok";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Harga";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Laba
            // 
            this.Laba.HeaderText = "Laba";
            this.Laba.Name = "Laba";
            this.Laba.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Diskon";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 65;
            this.label12.Text = "Laba";
            // 
            // Laba_N
            // 
            this.Laba_N.Enabled = false;
            this.Laba_N.Location = new System.Drawing.Point(71, 162);
            this.Laba_N.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.Laba_N.Name = "Laba_N";
            this.Laba_N.ReadOnly = true;
            this.Laba_N.Size = new System.Drawing.Size(292, 20);
            this.Laba_N.TabIndex = 66;
            // 
            // transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1387, 825);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "transaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "transaksi";
            this.Load += new System.EventHandler(this.transaksi_Load);
            this.Shown += new System.EventHandler(this.transaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kembalian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bayar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Diskon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Harga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jumlah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Laba_N)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Nama;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox cari_txt;
        private System.Windows.Forms.NumericUpDown Stok;
        private System.Windows.Forms.NumericUpDown Harga;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Jumlah;
        private System.Windows.Forms.NumericUpDown Diskon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown Id;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox karyawan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Pelanggan;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown kembalian;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown bayar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Laba;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown Laba_N;
    }
}