namespace QuanLyNT_GUI
{
    partial class Menu_GUI
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
            this.btHoaDon = new System.Windows.Forms.Button();
            this.btNhanVien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btHoaDon
            // 
            this.btHoaDon.Location = new System.Drawing.Point(96, 116);
            this.btHoaDon.Name = "btHoaDon";
            this.btHoaDon.Size = new System.Drawing.Size(75, 23);
            this.btHoaDon.TabIndex = 0;
            this.btHoaDon.Text = "Hóa đơn";
            this.btHoaDon.UseVisualStyleBackColor = true;
            this.btHoaDon.Click += new System.EventHandler(this.btHoaDon_Click);
            // 
            // btNhanVien
            // 
            this.btNhanVien.Location = new System.Drawing.Point(96, 156);
            this.btNhanVien.Name = "btNhanVien";
            this.btNhanVien.Size = new System.Drawing.Size(75, 23);
            this.btNhanVien.TabIndex = 1;
            this.btNhanVien.Text = "Nhân viên";
            this.btNhanVien.UseVisualStyleBackColor = true;
            // 
            // Menu_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btNhanVien);
            this.Controls.Add(this.btHoaDon);
            this.Name = "Menu_GUI";
            this.Text = "Menu_GUI";
            this.Load += new System.EventHandler(this.Menu_GUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btHoaDon;
        private System.Windows.Forms.Button btNhanVien;
    }
}