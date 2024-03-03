namespace kasir_pro_database
{
    partial class Print
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
            this.Print_btn = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Print_btn
            // 
            this.Print_btn.Location = new System.Drawing.Point(173, 452);
            this.Print_btn.Name = "Print_btn";
            this.Print_btn.Size = new System.Drawing.Size(93, 30);
            this.Print_btn.TabIndex = 3;
            this.Print_btn.Text = "Print";
            this.Print_btn.UseVisualStyleBackColor = true;
            this.Print_btn.Click += new System.EventHandler(this.Print_btn_Click);
            // 
            // list
            // 
            this.list.Location = new System.Drawing.Point(12, 12);
            this.list.Multiline = true;
            this.list.Name = "list";
            this.list.ReadOnly = true;
            this.list.Size = new System.Drawing.Size(422, 427);
            this.list.TabIndex = 2;
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 494);
            this.ControlBox = false;
            this.Controls.Add(this.Print_btn);
            this.Controls.Add(this.list);
            this.Name = "Print";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Print_btn;
        internal System.Windows.Forms.TextBox list;
    }
}