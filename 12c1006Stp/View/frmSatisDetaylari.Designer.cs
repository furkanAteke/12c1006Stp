namespace _12c1006Stp
{
    partial class frmSatisDetaylari
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdSatislar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.grdSatilanUrunler = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSatisIptal = new System.Windows.Forms.Button();
            this.txtSatisToplam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatislar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatilanUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSatisIptal);
            this.groupBox1.Controls.Add(this.txtSatisToplam);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.grdSatilanUrunler);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.grdSatislar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // grdSatislar
            // 
            this.grdSatislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSatislar.Location = new System.Drawing.Point(6, 19);
            this.grdSatislar.Name = "grdSatislar";
            this.grdSatislar.Size = new System.Drawing.Size(385, 201);
            this.grdSatislar.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "SATILAN ÜRÜNLER";
            // 
            // grdSatilanUrunler
            // 
            this.grdSatilanUrunler.AllowUserToAddRows = false;
            this.grdSatilanUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSatilanUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.grdSatilanUrunler.Location = new System.Drawing.Point(414, 35);
            this.grdSatilanUrunler.Name = "grdSatilanUrunler";
            this.grdSatilanUrunler.Size = new System.Drawing.Size(253, 135);
            this.grdSatilanUrunler.TabIndex = 26;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Kod";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ürün Adı";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Miktar";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "BirimFiyat";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Toplam";
            this.Column5.Name = "Column5";
            // 
            // btnSatisIptal
            // 
            this.btnSatisIptal.Enabled = false;
            this.btnSatisIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSatisIptal.ImageKey = "right.png";
            this.btnSatisIptal.Location = new System.Drawing.Point(404, 197);
            this.btnSatisIptal.Name = "btnSatisIptal";
            this.btnSatisIptal.Size = new System.Drawing.Size(75, 23);
            this.btnSatisIptal.TabIndex = 32;
            this.btnSatisIptal.Text = "Satışı iptal et";
            this.btnSatisIptal.UseVisualStyleBackColor = true;
            // 
            // txtSatisToplam
            // 
            this.txtSatisToplam.Enabled = false;
            this.txtSatisToplam.Location = new System.Drawing.Point(592, 200);
            this.txtSatisToplam.Name = "txtSatisToplam";
            this.txtSatisToplam.Size = new System.Drawing.Size(40, 20);
            this.txtSatisToplam.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(513, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Genel Toplam : ";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 265);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatislar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatilanUrunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdSatislar;
        private System.Windows.Forms.DataGridView grdSatilanUrunler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnSatisIptal;
        private System.Windows.Forms.TextBox txtSatisToplam;
        private System.Windows.Forms.Label label4;
    }
}