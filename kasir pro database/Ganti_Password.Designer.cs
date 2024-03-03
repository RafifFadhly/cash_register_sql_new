namespace kasir_pro_database
{
    partial class Ganti_Password
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
            this.label3 = new System.Windows.Forms.Label();
            this.Nama = new System.Windows.Forms.TextBox();
            this.Password_baru = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ganti_pw_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Username";
            // 
            // Nama
            // 
            this.Nama.Location = new System.Drawing.Point(88, 44);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(328, 20);
            this.Nama.TabIndex = 58;
            // 
            // Password_baru
            // 
            this.Password_baru.Location = new System.Drawing.Point(88, 80);
            this.Password_baru.Name = "Password_baru";
            this.Password_baru.Size = new System.Drawing.Size(328, 20);
            this.Password_baru.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Password";
            // 
            // ganti_pw_btn
            // 
            this.ganti_pw_btn.Location = new System.Drawing.Point(153, 106);
            this.ganti_pw_btn.Name = "ganti_pw_btn";
            this.ganti_pw_btn.Size = new System.Drawing.Size(110, 38);
            this.ganti_pw_btn.TabIndex = 64;
            this.ganti_pw_btn.Text = "Ganti";
            this.ganti_pw_btn.UseVisualStyleBackColor = true;
            this.ganti_pw_btn.Click += new System.EventHandler(this.ganti_pw_btn_Click);
            // 
            // Ganti_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(444, 202);
            this.Controls.Add(this.ganti_pw_btn);
            this.Controls.Add(this.Password_baru);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ganti_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ganti_Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Nama;
        private System.Windows.Forms.TextBox Password_baru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ganti_pw_btn;
    }
}