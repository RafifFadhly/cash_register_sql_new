namespace kasir_pro_database
{
    partial class Kasir
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ganriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barangToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pendapatanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.userToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ganriToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // ganriToolStripMenuItem
            // 
            this.ganriToolStripMenuItem.Name = "ganriToolStripMenuItem";
            this.ganriToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.ganriToolStripMenuItem.Text = "Ganti Password";
            this.ganriToolStripMenuItem.Click += new System.EventHandler(this.ganriToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.userToolStripMenuItem.Text = "transaksi";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.transaksiToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barangToolStripMenuItem1,
            this.userToolStripMenuItem1,
            this.pendapatanToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // barangToolStripMenuItem1
            // 
            this.barangToolStripMenuItem1.Name = "barangToolStripMenuItem1";
            this.barangToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.barangToolStripMenuItem1.Text = "Barang";
            this.barangToolStripMenuItem1.Click += new System.EventHandler(this.barangToolStripMenuItem1_Click);
            // 
            // userToolStripMenuItem1
            // 
            this.userToolStripMenuItem1.Name = "userToolStripMenuItem1";
            this.userToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.userToolStripMenuItem1.Text = "User";
            this.userToolStripMenuItem1.Click += new System.EventHandler(this.userToolStripMenuItem1_Click);
            // 
            // pendapatanToolStripMenuItem
            // 
            this.pendapatanToolStripMenuItem.Name = "pendapatanToolStripMenuItem";
            this.pendapatanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pendapatanToolStripMenuItem.Text = "Pendapatan";
            this.pendapatanToolStripMenuItem.Click += new System.EventHandler(this.pendapatanToolStripMenuItem_Click);
            // 
            // Kasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Kasir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasir Database";
            this.Load += new System.EventHandler(this.Kasir_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barangToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pendapatanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ganriToolStripMenuItem;
    }
}

