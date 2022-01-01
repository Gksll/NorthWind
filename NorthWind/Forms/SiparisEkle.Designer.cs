namespace NorthWind.Forms
{
    partial class SiparisEkle
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
            this.lbl_Musteri_ID = new System.Windows.Forms.Label();
            this.lbl_Calisan = new System.Windows.Forms.Label();
            this.lbl_Istenilen_Tarih = new System.Windows.Forms.Label();
            this.lbl_Siparis_Tarihi = new System.Windows.Forms.Label();
            this.lbl_Alıcı_Ismi = new System.Windows.Forms.Label();
            this.lbl_Tasima_Ucreti = new System.Windows.Forms.Label();
            this.lbl_Lojistik = new System.Windows.Forms.Label();
            this.lbl_Gonderilme_Tarihi = new System.Windows.Forms.Label();
            this.lbl_Alıcı_Posta_Kodu = new System.Windows.Forms.Label();
            this.lbl_Alıcı_Bolge = new System.Windows.Forms.Label();
            this.lbl_Alıcı_Sehir = new System.Windows.Forms.Label();
            this.lbl_Alıcı_Adresi = new System.Windows.Forms.Label();
            this.lbl_Alıcı_Ulke = new System.Windows.Forms.Label();
            this.cb_Musteri = new System.Windows.Forms.ComboBox();
            this.cb_Calisan = new System.Windows.Forms.ComboBox();
            this.dtp_Siparis_Tarihi = new System.Windows.Forms.DateTimePicker();
            this.dtp_ıstenilen_Tarih = new System.Windows.Forms.DateTimePicker();
            this.dtp_Gonderilme_Tarihi = new System.Windows.Forms.DateTimePicker();
            this.cb_Lojistik_Firma = new System.Windows.Forms.ComboBox();
            this.tb_Tasima_Ucreti = new System.Windows.Forms.TextBox();
            this.tb_Alici_Ismi = new System.Windows.Forms.TextBox();
            this.tb_Alici_Adresi = new System.Windows.Forms.TextBox();
            this.tb_Alici_Sehri = new System.Windows.Forms.TextBox();
            this.tb_Alici_Bolgesi = new System.Windows.Forms.TextBox();
            this.tb_Alici_Posta_Kodu = new System.Windows.Forms.TextBox();
            this.tb_Alici_Ulke = new System.Windows.Forms.TextBox();
            this.btn_Siparis_Ekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Musteri_ID
            // 
            this.lbl_Musteri_ID.AutoSize = true;
            this.lbl_Musteri_ID.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Musteri_ID.Location = new System.Drawing.Point(104, 39);
            this.lbl_Musteri_ID.Name = "lbl_Musteri_ID";
            this.lbl_Musteri_ID.Size = new System.Drawing.Size(91, 24);
            this.lbl_Musteri_ID.TabIndex = 0;
            this.lbl_Musteri_ID.Text = "Müşteri:";
            // 
            // lbl_Calisan
            // 
            this.lbl_Calisan.AutoSize = true;
            this.lbl_Calisan.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Calisan.Location = new System.Drawing.Point(107, 103);
            this.lbl_Calisan.Name = "lbl_Calisan";
            this.lbl_Calisan.Size = new System.Drawing.Size(88, 24);
            this.lbl_Calisan.TabIndex = 1;
            this.lbl_Calisan.Text = "Çalışan:";
            // 
            // lbl_Istenilen_Tarih
            // 
            this.lbl_Istenilen_Tarih.AutoSize = true;
            this.lbl_Istenilen_Tarih.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Istenilen_Tarih.Location = new System.Drawing.Point(42, 231);
            this.lbl_Istenilen_Tarih.Name = "lbl_Istenilen_Tarih";
            this.lbl_Istenilen_Tarih.Size = new System.Drawing.Size(153, 24);
            this.lbl_Istenilen_Tarih.TabIndex = 3;
            this.lbl_Istenilen_Tarih.Text = "İstenilen Tarih:";
            // 
            // lbl_Siparis_Tarihi
            // 
            this.lbl_Siparis_Tarihi.AutoSize = true;
            this.lbl_Siparis_Tarihi.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Siparis_Tarihi.Location = new System.Drawing.Point(55, 167);
            this.lbl_Siparis_Tarihi.Name = "lbl_Siparis_Tarihi";
            this.lbl_Siparis_Tarihi.Size = new System.Drawing.Size(140, 24);
            this.lbl_Siparis_Tarihi.TabIndex = 2;
            this.lbl_Siparis_Tarihi.Text = "Sipariş Tarihi:";
            // 
            // lbl_Alıcı_Ismi
            // 
            this.lbl_Alıcı_Ismi.AutoSize = true;
            this.lbl_Alıcı_Ismi.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Alıcı_Ismi.Location = new System.Drawing.Point(90, 487);
            this.lbl_Alıcı_Ismi.Name = "lbl_Alıcı_Ismi";
            this.lbl_Alıcı_Ismi.Size = new System.Drawing.Size(105, 24);
            this.lbl_Alıcı_Ismi.TabIndex = 7;
            this.lbl_Alıcı_Ismi.Text = "Alıcı İsmi:";
            // 
            // lbl_Tasima_Ucreti
            // 
            this.lbl_Tasima_Ucreti.AutoSize = true;
            this.lbl_Tasima_Ucreti.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tasima_Ucreti.Location = new System.Drawing.Point(47, 423);
            this.lbl_Tasima_Ucreti.Name = "lbl_Tasima_Ucreti";
            this.lbl_Tasima_Ucreti.Size = new System.Drawing.Size(148, 24);
            this.lbl_Tasima_Ucreti.TabIndex = 6;
            this.lbl_Tasima_Ucreti.Text = "Taşıma Ücreti:";
            // 
            // lbl_Lojistik
            // 
            this.lbl_Lojistik.AutoSize = true;
            this.lbl_Lojistik.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lojistik.Location = new System.Drawing.Point(30, 359);
            this.lbl_Lojistik.Name = "lbl_Lojistik";
            this.lbl_Lojistik.Size = new System.Drawing.Size(165, 24);
            this.lbl_Lojistik.TabIndex = 5;
            this.lbl_Lojistik.Text = "Lojistik Firması:";
            // 
            // lbl_Gonderilme_Tarihi
            // 
            this.lbl_Gonderilme_Tarihi.AutoSize = true;
            this.lbl_Gonderilme_Tarihi.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gonderilme_Tarihi.Location = new System.Drawing.Point(10, 295);
            this.lbl_Gonderilme_Tarihi.Name = "lbl_Gonderilme_Tarihi";
            this.lbl_Gonderilme_Tarihi.Size = new System.Drawing.Size(185, 24);
            this.lbl_Gonderilme_Tarihi.TabIndex = 4;
            this.lbl_Gonderilme_Tarihi.Text = "Gönderilme Tarihi:";
            // 
            // lbl_Alıcı_Posta_Kodu
            // 
            this.lbl_Alıcı_Posta_Kodu.AutoSize = true;
            this.lbl_Alıcı_Posta_Kodu.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Alıcı_Posta_Kodu.Location = new System.Drawing.Point(14, 743);
            this.lbl_Alıcı_Posta_Kodu.Name = "lbl_Alıcı_Posta_Kodu";
            this.lbl_Alıcı_Posta_Kodu.Size = new System.Drawing.Size(181, 24);
            this.lbl_Alıcı_Posta_Kodu.TabIndex = 11;
            this.lbl_Alıcı_Posta_Kodu.Text = "Alıcı Posta Kodu:";
            // 
            // lbl_Alıcı_Bolge
            // 
            this.lbl_Alıcı_Bolge.AutoSize = true;
            this.lbl_Alıcı_Bolge.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Alıcı_Bolge.Location = new System.Drawing.Point(56, 679);
            this.lbl_Alıcı_Bolge.Name = "lbl_Alıcı_Bolge";
            this.lbl_Alıcı_Bolge.Size = new System.Drawing.Size(139, 24);
            this.lbl_Alıcı_Bolge.TabIndex = 10;
            this.lbl_Alıcı_Bolge.Text = "Alıcı Bölgesi:";
            // 
            // lbl_Alıcı_Sehir
            // 
            this.lbl_Alıcı_Sehir.AutoSize = true;
            this.lbl_Alıcı_Sehir.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Alıcı_Sehir.Location = new System.Drawing.Point(80, 615);
            this.lbl_Alıcı_Sehir.Name = "lbl_Alıcı_Sehir";
            this.lbl_Alıcı_Sehir.Size = new System.Drawing.Size(115, 24);
            this.lbl_Alıcı_Sehir.TabIndex = 9;
            this.lbl_Alıcı_Sehir.Text = "Alıcı Şehri:";
            // 
            // lbl_Alıcı_Adresi
            // 
            this.lbl_Alıcı_Adresi.AutoSize = true;
            this.lbl_Alıcı_Adresi.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Alıcı_Adresi.Location = new System.Drawing.Point(68, 551);
            this.lbl_Alıcı_Adresi.Name = "lbl_Alıcı_Adresi";
            this.lbl_Alıcı_Adresi.Size = new System.Drawing.Size(127, 24);
            this.lbl_Alıcı_Adresi.TabIndex = 8;
            this.lbl_Alıcı_Adresi.Text = "Alıcı Adresi:";
            // 
            // lbl_Alıcı_Ulke
            // 
            this.lbl_Alıcı_Ulke.AutoSize = true;
            this.lbl_Alıcı_Ulke.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Alıcı_Ulke.Location = new System.Drawing.Point(71, 807);
            this.lbl_Alıcı_Ulke.Name = "lbl_Alıcı_Ulke";
            this.lbl_Alıcı_Ulke.Size = new System.Drawing.Size(124, 24);
            this.lbl_Alıcı_Ulke.TabIndex = 12;
            this.lbl_Alıcı_Ulke.Text = "Alıcı Ülkesi:";
            // 
            // cb_Musteri
            // 
            this.cb_Musteri.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Musteri.FormattingEnabled = true;
            this.cb_Musteri.Location = new System.Drawing.Point(230, 36);
            this.cb_Musteri.Name = "cb_Musteri";
            this.cb_Musteri.Size = new System.Drawing.Size(312, 32);
            this.cb_Musteri.TabIndex = 13;
            // 
            // cb_Calisan
            // 
            this.cb_Calisan.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Calisan.FormattingEnabled = true;
            this.cb_Calisan.Location = new System.Drawing.Point(230, 100);
            this.cb_Calisan.Name = "cb_Calisan";
            this.cb_Calisan.Size = new System.Drawing.Size(312, 32);
            this.cb_Calisan.TabIndex = 14;
            // 
            // dtp_Siparis_Tarihi
            // 
            this.dtp_Siparis_Tarihi.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Siparis_Tarihi.Location = new System.Drawing.Point(230, 164);
            this.dtp_Siparis_Tarihi.Name = "dtp_Siparis_Tarihi";
            this.dtp_Siparis_Tarihi.Size = new System.Drawing.Size(312, 31);
            this.dtp_Siparis_Tarihi.TabIndex = 15;
            // 
            // dtp_ıstenilen_Tarih
            // 
            this.dtp_ıstenilen_Tarih.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ıstenilen_Tarih.Location = new System.Drawing.Point(230, 227);
            this.dtp_ıstenilen_Tarih.Name = "dtp_ıstenilen_Tarih";
            this.dtp_ıstenilen_Tarih.Size = new System.Drawing.Size(312, 31);
            this.dtp_ıstenilen_Tarih.TabIndex = 16;
            // 
            // dtp_Gonderilme_Tarihi
            // 
            this.dtp_Gonderilme_Tarihi.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Gonderilme_Tarihi.Location = new System.Drawing.Point(230, 290);
            this.dtp_Gonderilme_Tarihi.Name = "dtp_Gonderilme_Tarihi";
            this.dtp_Gonderilme_Tarihi.Size = new System.Drawing.Size(312, 31);
            this.dtp_Gonderilme_Tarihi.TabIndex = 17;
            // 
            // cb_Lojistik_Firma
            // 
            this.cb_Lojistik_Firma.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Lojistik_Firma.FormattingEnabled = true;
            this.cb_Lojistik_Firma.Location = new System.Drawing.Point(230, 353);
            this.cb_Lojistik_Firma.Name = "cb_Lojistik_Firma";
            this.cb_Lojistik_Firma.Size = new System.Drawing.Size(312, 32);
            this.cb_Lojistik_Firma.TabIndex = 18;
            // 
            // tb_Tasima_Ucreti
            // 
            this.tb_Tasima_Ucreti.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Tasima_Ucreti.Location = new System.Drawing.Point(230, 417);
            this.tb_Tasima_Ucreti.Name = "tb_Tasima_Ucreti";
            this.tb_Tasima_Ucreti.Size = new System.Drawing.Size(312, 31);
            this.tb_Tasima_Ucreti.TabIndex = 19;
            // 
            // tb_Alici_Ismi
            // 
            this.tb_Alici_Ismi.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Alici_Ismi.Location = new System.Drawing.Point(230, 480);
            this.tb_Alici_Ismi.Name = "tb_Alici_Ismi";
            this.tb_Alici_Ismi.Size = new System.Drawing.Size(312, 31);
            this.tb_Alici_Ismi.TabIndex = 20;
            // 
            // tb_Alici_Adresi
            // 
            this.tb_Alici_Adresi.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Alici_Adresi.Location = new System.Drawing.Point(230, 543);
            this.tb_Alici_Adresi.Name = "tb_Alici_Adresi";
            this.tb_Alici_Adresi.Size = new System.Drawing.Size(312, 31);
            this.tb_Alici_Adresi.TabIndex = 21;
            // 
            // tb_Alici_Sehri
            // 
            this.tb_Alici_Sehri.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Alici_Sehri.Location = new System.Drawing.Point(230, 606);
            this.tb_Alici_Sehri.Name = "tb_Alici_Sehri";
            this.tb_Alici_Sehri.Size = new System.Drawing.Size(312, 31);
            this.tb_Alici_Sehri.TabIndex = 22;
            // 
            // tb_Alici_Bolgesi
            // 
            this.tb_Alici_Bolgesi.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Alici_Bolgesi.Location = new System.Drawing.Point(230, 669);
            this.tb_Alici_Bolgesi.Name = "tb_Alici_Bolgesi";
            this.tb_Alici_Bolgesi.Size = new System.Drawing.Size(312, 31);
            this.tb_Alici_Bolgesi.TabIndex = 23;
            // 
            // tb_Alici_Posta_Kodu
            // 
            this.tb_Alici_Posta_Kodu.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Alici_Posta_Kodu.Location = new System.Drawing.Point(230, 732);
            this.tb_Alici_Posta_Kodu.Name = "tb_Alici_Posta_Kodu";
            this.tb_Alici_Posta_Kodu.Size = new System.Drawing.Size(312, 31);
            this.tb_Alici_Posta_Kodu.TabIndex = 24;
            // 
            // tb_Alici_Ulke
            // 
            this.tb_Alici_Ulke.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Alici_Ulke.Location = new System.Drawing.Point(230, 795);
            this.tb_Alici_Ulke.Name = "tb_Alici_Ulke";
            this.tb_Alici_Ulke.Size = new System.Drawing.Size(312, 31);
            this.tb_Alici_Ulke.TabIndex = 25;
            // 
            // btn_Siparis_Ekle
            // 
            this.btn_Siparis_Ekle.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Siparis_Ekle.Location = new System.Drawing.Point(230, 864);
            this.btn_Siparis_Ekle.Name = "btn_Siparis_Ekle";
            this.btn_Siparis_Ekle.Size = new System.Drawing.Size(312, 33);
            this.btn_Siparis_Ekle.TabIndex = 26;
            this.btn_Siparis_Ekle.Text = "Kaydet";
            this.btn_Siparis_Ekle.UseVisualStyleBackColor = true;
            this.btn_Siparis_Ekle.Click += new System.EventHandler(this.btn_Siparis_Ekle_Click);
            // 
            // SiparisEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 946);
            this.Controls.Add(this.btn_Siparis_Ekle);
            this.Controls.Add(this.tb_Alici_Ulke);
            this.Controls.Add(this.tb_Alici_Posta_Kodu);
            this.Controls.Add(this.tb_Alici_Bolgesi);
            this.Controls.Add(this.tb_Alici_Sehri);
            this.Controls.Add(this.tb_Alici_Adresi);
            this.Controls.Add(this.tb_Alici_Ismi);
            this.Controls.Add(this.tb_Tasima_Ucreti);
            this.Controls.Add(this.cb_Lojistik_Firma);
            this.Controls.Add(this.dtp_Gonderilme_Tarihi);
            this.Controls.Add(this.dtp_ıstenilen_Tarih);
            this.Controls.Add(this.dtp_Siparis_Tarihi);
            this.Controls.Add(this.cb_Calisan);
            this.Controls.Add(this.cb_Musteri);
            this.Controls.Add(this.lbl_Alıcı_Ulke);
            this.Controls.Add(this.lbl_Alıcı_Posta_Kodu);
            this.Controls.Add(this.lbl_Alıcı_Bolge);
            this.Controls.Add(this.lbl_Alıcı_Sehir);
            this.Controls.Add(this.lbl_Alıcı_Adresi);
            this.Controls.Add(this.lbl_Alıcı_Ismi);
            this.Controls.Add(this.lbl_Tasima_Ucreti);
            this.Controls.Add(this.lbl_Lojistik);
            this.Controls.Add(this.lbl_Gonderilme_Tarihi);
            this.Controls.Add(this.lbl_Istenilen_Tarih);
            this.Controls.Add(this.lbl_Siparis_Tarihi);
            this.Controls.Add(this.lbl_Calisan);
            this.Controls.Add(this.lbl_Musteri_ID);
            this.Name = "SiparisEkle";
            this.Text = "SiparisEkle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SiparisEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Musteri_ID;
        private System.Windows.Forms.Label lbl_Calisan;
        private System.Windows.Forms.Label lbl_Istenilen_Tarih;
        private System.Windows.Forms.Label lbl_Siparis_Tarihi;
        private System.Windows.Forms.Label lbl_Alıcı_Ismi;
        private System.Windows.Forms.Label lbl_Tasima_Ucreti;
        private System.Windows.Forms.Label lbl_Lojistik;
        private System.Windows.Forms.Label lbl_Gonderilme_Tarihi;
        private System.Windows.Forms.Label lbl_Alıcı_Posta_Kodu;
        private System.Windows.Forms.Label lbl_Alıcı_Bolge;
        private System.Windows.Forms.Label lbl_Alıcı_Sehir;
        private System.Windows.Forms.Label lbl_Alıcı_Adresi;
        private System.Windows.Forms.Label lbl_Alıcı_Ulke;
        private System.Windows.Forms.ComboBox cb_Musteri;
        private System.Windows.Forms.ComboBox cb_Calisan;
        private System.Windows.Forms.DateTimePicker dtp_Siparis_Tarihi;
        private System.Windows.Forms.DateTimePicker dtp_ıstenilen_Tarih;
        private System.Windows.Forms.DateTimePicker dtp_Gonderilme_Tarihi;
        private System.Windows.Forms.ComboBox cb_Lojistik_Firma;
        private System.Windows.Forms.TextBox tb_Tasima_Ucreti;
        private System.Windows.Forms.TextBox tb_Alici_Ismi;
        private System.Windows.Forms.TextBox tb_Alici_Adresi;
        private System.Windows.Forms.TextBox tb_Alici_Sehri;
        private System.Windows.Forms.TextBox tb_Alici_Bolgesi;
        private System.Windows.Forms.TextBox tb_Alici_Posta_Kodu;
        private System.Windows.Forms.TextBox tb_Alici_Ulke;
        private System.Windows.Forms.Button btn_Siparis_Ekle;
    }
}