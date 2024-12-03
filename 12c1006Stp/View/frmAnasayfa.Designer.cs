namespace _12c1006Stp
{
    partial class frmAnasayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnasayfa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdUrunListesi = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList3 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mskTxtMusteriTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMusteriSec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSec = new System.Windows.Forms.Button();
            this.menuTedarikci = new System.Windows.Forms.Button();
            this.menuUrun = new System.Windows.Forms.Button();
            this.menuSatis = new System.Windows.Forms.Button();
            this.menuMusteri = new System.Windows.Forms.Button();
            this.menuPersonel = new System.Windows.Forms.Button();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGenelToplam = new System.Windows.Forms.TextBox();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.grdSatilacakUrunler = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPersonelAdSoyad = new System.Windows.Forms.Label();
            this.lblYetki = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUrunListesi)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatilacakUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdUrunListesi);
            this.groupBox1.Location = new System.Drawing.Point(11, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 342);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Listesi";
            // 
            // grdUrunListesi
            // 
            this.grdUrunListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUrunListesi.Location = new System.Drawing.Point(6, 19);
            this.grdUrunListesi.Name = "grdUrunListesi";
            this.grdUrunListesi.Size = new System.Drawing.Size(360, 317);
            this.grdUrunListesi.TabIndex = 14;
            // 
            // btnEkle
            // 
            this.btnEkle.Enabled = false;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.ImageKey = "right.png";
            this.btnEkle.ImageList = this.ımageList2;
            this.btnEkle.Location = new System.Drawing.Point(390, 189);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.ImageKey = "left.png";
            this.btnSil.ImageList = this.ımageList3;
            this.btnSil.Location = new System.Drawing.Point(389, 218);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "right.png");
            // 
            // ımageList3
            // 
            this.ımageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList3.ImageStream")));
            this.ımageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList3.Images.SetKeyName(0, "left.png");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdSatilacakUrunler);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNot);
            this.groupBox2.Controls.Add(this.btnSec);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnMusteriSec);
            this.groupBox2.Controls.Add(this.mskTxtMusteriTelefon);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(471, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 342);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Satış İşlemi";
            // 
            // mskTxtMusteriTelefon
            // 
            this.mskTxtMusteriTelefon.Location = new System.Drawing.Point(171, 19);
            this.mskTxtMusteriTelefon.Mask = "(999) 000-0000";
            this.mskTxtMusteriTelefon.Name = "mskTxtMusteriTelefon";
            this.mskTxtMusteriTelefon.Size = new System.Drawing.Size(100, 20);
            this.mskTxtMusteriTelefon.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Müşteri Telefon : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Müşteri : ";
            // 
            // btnMusteriSec
            // 
            this.btnMusteriSec.Location = new System.Drawing.Point(171, 45);
            this.btnMusteriSec.Name = "btnMusteriSec";
            this.btnMusteriSec.Size = new System.Drawing.Size(100, 20);
            this.btnMusteriSec.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Satış yapılacak ürünler";
            // 
            // btnSec
            // 
            this.btnSec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSec.ImageKey = "(none)";
            this.btnSec.ImageList = this.ımageList2;
            this.btnSec.Location = new System.Drawing.Point(277, 17);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(35, 23);
            this.btnSec.TabIndex = 16;
            this.btnSec.Text = "Seç";
            this.btnSec.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSec.UseVisualStyleBackColor = true;
            // 
            // menuTedarikci
            // 
            this.menuTedarikci.Location = new System.Drawing.Point(11, 13);
            this.menuTedarikci.Name = "menuTedarikci";
            this.menuTedarikci.Size = new System.Drawing.Size(75, 37);
            this.menuTedarikci.TabIndex = 16;
            this.menuTedarikci.Text = "Tedarikçi İşlemleri";
            this.menuTedarikci.UseVisualStyleBackColor = true;
            // 
            // menuUrun
            // 
            this.menuUrun.Location = new System.Drawing.Point(92, 12);
            this.menuUrun.Name = "menuUrun";
            this.menuUrun.Size = new System.Drawing.Size(75, 37);
            this.menuUrun.TabIndex = 17;
            this.menuUrun.Text = "Ürün İşlemleri";
            this.menuUrun.UseVisualStyleBackColor = true;
            // 
            // menuSatis
            // 
            this.menuSatis.Location = new System.Drawing.Point(173, 13);
            this.menuSatis.Name = "menuSatis";
            this.menuSatis.Size = new System.Drawing.Size(75, 37);
            this.menuSatis.TabIndex = 18;
            this.menuSatis.Text = "Satış Detayları";
            this.menuSatis.UseVisualStyleBackColor = true;
            // 
            // menuMusteri
            // 
            this.menuMusteri.Location = new System.Drawing.Point(254, 13);
            this.menuMusteri.Name = "menuMusteri";
            this.menuMusteri.Size = new System.Drawing.Size(75, 37);
            this.menuMusteri.TabIndex = 19;
            this.menuMusteri.Text = "Müşteri İşlemleri";
            this.menuMusteri.UseVisualStyleBackColor = true;
            // 
            // menuPersonel
            // 
            this.menuPersonel.Location = new System.Drawing.Point(335, 13);
            this.menuPersonel.Name = "menuPersonel";
            this.menuPersonel.Size = new System.Drawing.Size(75, 37);
            this.menuPersonel.TabIndex = 20;
            this.menuPersonel.Text = "Personel İşlemleri";
            this.menuPersonel.UseVisualStyleBackColor = true;
            // 
            // txtNot
            // 
            this.txtNot.Enabled = false;
            this.txtNot.Location = new System.Drawing.Point(171, 287);
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(136, 20);
            this.txtNot.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Not Ekle : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(659, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Genel Toplam : ";
            // 
            // txtGenelToplam
            // 
            this.txtGenelToplam.Enabled = false;
            this.txtGenelToplam.Location = new System.Drawing.Point(738, 398);
            this.txtGenelToplam.Name = "txtGenelToplam";
            this.txtGenelToplam.Size = new System.Drawing.Size(40, 20);
            this.txtGenelToplam.TabIndex = 25;
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.Enabled = false;
            this.btnSatisYap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSatisYap.ImageKey = "right.png";
            this.btnSatisYap.Location = new System.Drawing.Point(550, 395);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(75, 23);
            this.btnSatisYap.TabIndex = 26;
            this.btnSatisYap.Text = "Satış Yap";
            this.btnSatisYap.UseVisualStyleBackColor = true;
            // 
            // grdSatilacakUrunler
            // 
            this.grdSatilacakUrunler.AllowUserToAddRows = false;
            this.grdSatilacakUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSatilacakUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.grdSatilacakUrunler.Location = new System.Drawing.Point(54, 100);
            this.grdSatilacakUrunler.Name = "grdSatilacakUrunler";
            this.grdSatilacakUrunler.Size = new System.Drawing.Size(253, 181);
            this.grdSatilacakUrunler.TabIndex = 25;
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
            // lblPersonelAdSoyad
            // 
            this.lblPersonelAdSoyad.AutoSize = true;
            this.lblPersonelAdSoyad.Location = new System.Drawing.Point(471, 13);
            this.lblPersonelAdSoyad.Name = "lblPersonelAdSoyad";
            this.lblPersonelAdSoyad.Size = new System.Drawing.Size(66, 13);
            this.lblPersonelAdSoyad.TabIndex = 27;
            this.lblPersonelAdSoyad.Text = "Personel Adı";
            // 
            // lblYetki
            // 
            this.lblYetki.AutoSize = true;
            this.lblYetki.Location = new System.Drawing.Point(639, 13);
            this.lblYetki.Name = "lblYetki";
            this.lblYetki.Size = new System.Drawing.Size(31, 13);
            this.lblYetki.TabIndex = 28;
            this.lblYetki.Text = "Yetki";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.lblYetki);
            this.Controls.Add(this.lblPersonelAdSoyad);
            this.Controls.Add(this.btnSatisYap);
            this.Controls.Add(this.txtGenelToplam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuPersonel);
            this.Controls.Add(this.menuMusteri);
            this.Controls.Add(this.menuSatis);
            this.Controls.Add(this.menuUrun);
            this.Controls.Add(this.menuTedarikci);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUrunListesi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatilacakUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdUrunListesi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.ImageList ımageList3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mskTxtMusteriTelefon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox btnMusteriSec;
        private System.Windows.Forms.Button menuTedarikci;
        private System.Windows.Forms.Button menuUrun;
        private System.Windows.Forms.Button menuSatis;
        private System.Windows.Forms.Button menuMusteri;
        private System.Windows.Forms.Button menuPersonel;
        private System.Windows.Forms.DataGridView grdSatilacakUrunler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGenelToplam;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.Label lblPersonelAdSoyad;
        private System.Windows.Forms.Label lblYetki;
    }
}