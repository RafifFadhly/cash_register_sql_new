namespace kasir_pro_database
{
    partial class barang
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
            this.Diskon = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Nama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Stok = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Harga = new System.Windows.Forms.NumericUpDown();
            this.cari_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.Stok_dikit = new System.Windows.Forms.CheckBox();
            this.Stok_kurang = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.Laba_N = new System.Windows.Forms.NumericUpDown();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Diskon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Harga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stok_kurang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Laba_N)).BeginInit();
            this.SuspendLayout();
            // 
            // Diskon
            // 
            this.Diskon.Location = new System.Drawing.Point(72, 137);
            this.Diskon.Name = "Diskon";
            this.Diskon.Size = new System.Drawing.Size(386, 20);
            this.Diskon.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Diskon (%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nama";
            // 
            // Nama
            // 
            this.Nama.Location = new System.Drawing.Point(72, 27);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(386, 20);
            this.Nama.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Harga";
            // 
            // Stok
            // 
            this.Stok.Location = new System.Drawing.Point(72, 55);
            this.Stok.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.Stok.Name = "Stok";
            this.Stok.Size = new System.Drawing.Size(386, 20);
            this.Stok.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Stok";
            // 
            // Harga
            // 
            this.Harga.Location = new System.Drawing.Point(72, 83);
            this.Harga.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.Harga.Name = "Harga";
            this.Harga.Size = new System.Drawing.Size(386, 20);
            this.Harga.TabIndex = 25;
            // 
            // cari_txt
            // 
            this.cari_txt.Location = new System.Drawing.Point(542, 54);
            this.cari_txt.Name = "cari_txt";
            this.cari_txt.Size = new System.Drawing.Size(437, 20);
            this.cari_txt.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Cari Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Barang CRUD";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 48);
            this.button1.TabIndex = 34;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 48);
            this.button2.TabIndex = 35;
            this.button2.Text = "Hapus";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(313, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 48);
            this.button3.TabIndex = 36;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(985, 55);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(61, 20);
            this.button6.TabIndex = 37;
            this.button6.Text = "Cari";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(162, 217);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(296, 48);
            this.refresh.TabIndex = 38;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.laba,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(473, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(574, 714);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(11, 217);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 48);
            this.button4.TabIndex = 60;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Stok_dikit
            // 
            this.Stok_dikit.AutoSize = true;
            this.Stok_dikit.Location = new System.Drawing.Point(473, 31);
            this.Stok_dikit.Name = "Stok_dikit";
            this.Stok_dikit.Size = new System.Drawing.Size(178, 17);
            this.Stok_dikit.TabIndex = 61;
            this.Stok_dikit.Text = "Barang dengan stok kurang dari";
            this.Stok_dikit.UseVisualStyleBackColor = true;
            this.Stok_dikit.CheckedChanged += new System.EventHandler(this.Stok_dikit_CheckedChanged);
            // 
            // Stok_kurang
            // 
            this.Stok_kurang.Location = new System.Drawing.Point(657, 30);
            this.Stok_kurang.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.Stok_kurang.Name = "Stok_kurang";
            this.Stok_kurang.Size = new System.Drawing.Size(75, 20);
            this.Stok_kurang.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Laba";
            // 
            // Laba_N
            // 
            this.Laba_N.Location = new System.Drawing.Point(72, 111);
            this.Laba_N.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.Laba_N.Name = "Laba_N";
            this.Laba_N.Size = new System.Drawing.Size(386, 20);
            this.Laba_N.TabIndex = 64;
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
            // laba
            // 
            this.laba.HeaderText = "laba";
            this.laba.Name = "laba";
            this.laba.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Diskon";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // barang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 825);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Laba_N);
            this.Controls.Add(this.Stok_kurang);
            this.Controls.Add(this.Stok_dikit);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cari_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Diskon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Stok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Harga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "barang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "barang";
            this.Load += new System.EventHandler(this.barang_Load);
            this.Shown += new System.EventHandler(this.barang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Diskon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Harga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stok_kurang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Laba_N)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown Diskon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Nama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Stok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Harga;
        private System.Windows.Forms.TextBox cari_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox Stok_dikit;
        private System.Windows.Forms.NumericUpDown Stok_kurang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn laba;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Laba_N;
    }
}