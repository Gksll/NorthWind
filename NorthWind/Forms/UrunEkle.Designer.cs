namespace NorthWind.Forms
{
    partial class UrunEkle
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
            this.lbl_Urun_Adi = new System.Windows.Forms.Label();
            this.tb_Urun_Adi = new System.Windows.Forms.TextBox();
            this.tb_Urun_Paket_Miktari = new System.Windows.Forms.TextBox();
            this.lbl_Paket_Miktari = new System.Windows.Forms.Label();
            this.lbl_Tedarikci_ID = new System.Windows.Forms.Label();
            this.lbl_Kategori_ID = new System.Windows.Forms.Label();
            this.lbl_Urun_Fiyat = new System.Windows.Forms.Label();
            this.tb_Urun_Fiyati = new System.Windows.Forms.TextBox();
            this.tb_Stok_Adet = new System.Windows.Forms.TextBox();
            this.lbl_Stok = new System.Windows.Forms.Label();
            this.tb_Siparis_Edilmis_Adet = new System.Windows.Forms.TextBox();
            this.lbl_Siparis_Edilmis_Adet = new System.Windows.Forms.Label();
            this.tb_Ortalama_Siparis_Adet = new System.Windows.Forms.TextBox();
            this.lbl_Ortalama_Siparis = new System.Windows.Forms.Label();
            this.lbl_Uretilme_Durumu = new System.Windows.Forms.Label();
            this.cb_Tedarikci = new System.Windows.Forms.ComboBox();
            this.cb_Kategori = new System.Windows.Forms.ComboBox();
            this.cb_Uretilme_Durum = new System.Windows.Forms.CheckBox();
            this.btn_Urun_Kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Urun_Adi
            // 
            this.lbl_Urun_Adi.AutoSize = true;
            this.lbl_Urun_Adi.Location = new System.Drawing.Point(62, 46);
            this.lbl_Urun_Adi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Urun_Adi.Name = "lbl_Urun_Adi";
            this.lbl_Urun_Adi.Size = new System.Drawing.Size(60, 16);
            this.lbl_Urun_Adi.TabIndex = 0;
            this.lbl_Urun_Adi.Text = "Ürün adı:";
            // 
            // tb_Urun_Adi
            // 
            this.tb_Urun_Adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_Urun_Adi.Location = new System.Drawing.Point(218, 43);
            this.tb_Urun_Adi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Urun_Adi.Name = "tb_Urun_Adi";
            this.tb_Urun_Adi.Size = new System.Drawing.Size(297, 30);
            this.tb_Urun_Adi.TabIndex = 1;
            // 
            // tb_Urun_Paket_Miktari
            // 
            this.tb_Urun_Paket_Miktari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_Urun_Paket_Miktari.Location = new System.Drawing.Point(218, 201);
            this.tb_Urun_Paket_Miktari.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Urun_Paket_Miktari.Name = "tb_Urun_Paket_Miktari";
            this.tb_Urun_Paket_Miktari.Size = new System.Drawing.Size(297, 30);
            this.tb_Urun_Paket_Miktari.TabIndex = 3;
            // 
            // lbl_Paket_Miktari
            // 
            this.lbl_Paket_Miktari.AutoSize = true;
            this.lbl_Paket_Miktari.Location = new System.Drawing.Point(62, 204);
            this.lbl_Paket_Miktari.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Paket_Miktari.Name = "lbl_Paket_Miktari";
            this.lbl_Paket_Miktari.Size = new System.Drawing.Size(118, 16);
            this.lbl_Paket_Miktari.TabIndex = 2;
            this.lbl_Paket_Miktari.Text = "Ürün Paket Miktarı:";
            // 
            // lbl_Tedarikci_ID
            // 
            this.lbl_Tedarikci_ID.AutoSize = true;
            this.lbl_Tedarikci_ID.Location = new System.Drawing.Point(62, 99);
            this.lbl_Tedarikci_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Tedarikci_ID.Name = "lbl_Tedarikci_ID";
            this.lbl_Tedarikci_ID.Size = new System.Drawing.Size(67, 16);
            this.lbl_Tedarikci_ID.TabIndex = 4;
            this.lbl_Tedarikci_ID.Text = "Tedarikçi:";
            // 
            // lbl_Kategori_ID
            // 
            this.lbl_Kategori_ID.AutoSize = true;
            this.lbl_Kategori_ID.Location = new System.Drawing.Point(62, 151);
            this.lbl_Kategori_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Kategori_ID.Name = "lbl_Kategori_ID";
            this.lbl_Kategori_ID.Size = new System.Drawing.Size(60, 16);
            this.lbl_Kategori_ID.TabIndex = 5;
            this.lbl_Kategori_ID.Text = "Kategori:";
            // 
            // lbl_Urun_Fiyat
            // 
            this.lbl_Urun_Fiyat.AutoSize = true;
            this.lbl_Urun_Fiyat.Location = new System.Drawing.Point(62, 257);
            this.lbl_Urun_Fiyat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Urun_Fiyat.Name = "lbl_Urun_Fiyat";
            this.lbl_Urun_Fiyat.Size = new System.Drawing.Size(73, 16);
            this.lbl_Urun_Fiyat.TabIndex = 6;
            this.lbl_Urun_Fiyat.Text = "Ürün Fiyatı:";
            // 
            // tb_Urun_Fiyati
            // 
            this.tb_Urun_Fiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_Urun_Fiyati.Location = new System.Drawing.Point(218, 253);
            this.tb_Urun_Fiyati.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Urun_Fiyati.Name = "tb_Urun_Fiyati";
            this.tb_Urun_Fiyati.Size = new System.Drawing.Size(297, 30);
            this.tb_Urun_Fiyati.TabIndex = 7;
            // 
            // tb_Stok_Adet
            // 
            this.tb_Stok_Adet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_Stok_Adet.Location = new System.Drawing.Point(218, 305);
            this.tb_Stok_Adet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Stok_Adet.Name = "tb_Stok_Adet";
            this.tb_Stok_Adet.Size = new System.Drawing.Size(297, 30);
            this.tb_Stok_Adet.TabIndex = 9;
            // 
            // lbl_Stok
            // 
            this.lbl_Stok.AutoSize = true;
            this.lbl_Stok.Location = new System.Drawing.Point(62, 309);
            this.lbl_Stok.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Stok.Name = "lbl_Stok";
            this.lbl_Stok.Size = new System.Drawing.Size(68, 16);
            this.lbl_Stok.TabIndex = 8;
            this.lbl_Stok.Text = "Stok Adet:";
            // 
            // tb_Siparis_Edilmis_Adet
            // 
            this.tb_Siparis_Edilmis_Adet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_Siparis_Edilmis_Adet.Location = new System.Drawing.Point(218, 357);
            this.tb_Siparis_Edilmis_Adet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Siparis_Edilmis_Adet.Name = "tb_Siparis_Edilmis_Adet";
            this.tb_Siparis_Edilmis_Adet.Size = new System.Drawing.Size(297, 30);
            this.tb_Siparis_Edilmis_Adet.TabIndex = 11;
            // 
            // lbl_Siparis_Edilmis_Adet
            // 
            this.lbl_Siparis_Edilmis_Adet.AutoSize = true;
            this.lbl_Siparis_Edilmis_Adet.Location = new System.Drawing.Point(62, 362);
            this.lbl_Siparis_Edilmis_Adet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Siparis_Edilmis_Adet.Name = "lbl_Siparis_Edilmis_Adet";
            this.lbl_Siparis_Edilmis_Adet.Size = new System.Drawing.Size(130, 16);
            this.lbl_Siparis_Edilmis_Adet.TabIndex = 10;
            this.lbl_Siparis_Edilmis_Adet.Text = "Sipariş Edilmiş Adet:";
            // 
            // tb_Ortalama_Siparis_Adet
            // 
            this.tb_Ortalama_Siparis_Adet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_Ortalama_Siparis_Adet.Location = new System.Drawing.Point(218, 409);
            this.tb_Ortalama_Siparis_Adet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Ortalama_Siparis_Adet.Name = "tb_Ortalama_Siparis_Adet";
            this.tb_Ortalama_Siparis_Adet.Size = new System.Drawing.Size(297, 30);
            this.tb_Ortalama_Siparis_Adet.TabIndex = 13;
            // 
            // lbl_Ortalama_Siparis
            // 
            this.lbl_Ortalama_Siparis.AutoSize = true;
            this.lbl_Ortalama_Siparis.Location = new System.Drawing.Point(62, 415);
            this.lbl_Ortalama_Siparis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Ortalama_Siparis.Name = "lbl_Ortalama_Siparis";
            this.lbl_Ortalama_Siparis.Size = new System.Drawing.Size(141, 16);
            this.lbl_Ortalama_Siparis.TabIndex = 12;
            this.lbl_Ortalama_Siparis.Text = "Ortalama Sipariş Adet:";
            // 
            // lbl_Uretilme_Durumu
            // 
            this.lbl_Uretilme_Durumu.AutoSize = true;
            this.lbl_Uretilme_Durumu.Location = new System.Drawing.Point(62, 467);
            this.lbl_Uretilme_Durumu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Uretilme_Durumu.Name = "lbl_Uretilme_Durumu";
            this.lbl_Uretilme_Durumu.Size = new System.Drawing.Size(107, 16);
            this.lbl_Uretilme_Durumu.TabIndex = 14;
            this.lbl_Uretilme_Durumu.Text = "Artık Üretilmiyor?";
            // 
            // cb_Tedarikci
            // 
            this.cb_Tedarikci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_Tedarikci.FormattingEnabled = true;
            this.cb_Tedarikci.Location = new System.Drawing.Point(218, 95);
            this.cb_Tedarikci.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_Tedarikci.Name = "cb_Tedarikci";
            this.cb_Tedarikci.Size = new System.Drawing.Size(297, 33);
            this.cb_Tedarikci.TabIndex = 15;
            // 
            // cb_Kategori
            // 
            this.cb_Kategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cb_Kategori.FormattingEnabled = true;
            this.cb_Kategori.Location = new System.Drawing.Point(218, 148);
            this.cb_Kategori.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_Kategori.Name = "cb_Kategori";
            this.cb_Kategori.Size = new System.Drawing.Size(297, 33);
            this.cb_Kategori.TabIndex = 16;
            // 
            // cb_Uretilme_Durum
            // 
            this.cb_Uretilme_Durum.AutoSize = true;
            this.cb_Uretilme_Durum.Location = new System.Drawing.Point(218, 467);
            this.cb_Uretilme_Durum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_Uretilme_Durum.Name = "cb_Uretilme_Durum";
            this.cb_Uretilme_Durum.Size = new System.Drawing.Size(18, 17);
            this.cb_Uretilme_Durum.TabIndex = 17;
            this.cb_Uretilme_Durum.UseVisualStyleBackColor = true;
            // 
            // btn_Urun_Kaydet
            // 
            this.btn_Urun_Kaydet.Location = new System.Drawing.Point(218, 509);
            this.btn_Urun_Kaydet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Urun_Kaydet.Name = "btn_Urun_Kaydet";
            this.btn_Urun_Kaydet.Size = new System.Drawing.Size(296, 34);
            this.btn_Urun_Kaydet.TabIndex = 18;
            this.btn_Urun_Kaydet.Text = "Kaydet";
            this.btn_Urun_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Urun_Kaydet.Click += new System.EventHandler(this.btn_Urun_Kaydet_Click);
            // 
            // UrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 813);
            this.Controls.Add(this.btn_Urun_Kaydet);
            this.Controls.Add(this.cb_Uretilme_Durum);
            this.Controls.Add(this.cb_Kategori);
            this.Controls.Add(this.cb_Tedarikci);
            this.Controls.Add(this.lbl_Uretilme_Durumu);
            this.Controls.Add(this.tb_Ortalama_Siparis_Adet);
            this.Controls.Add(this.lbl_Ortalama_Siparis);
            this.Controls.Add(this.tb_Siparis_Edilmis_Adet);
            this.Controls.Add(this.lbl_Siparis_Edilmis_Adet);
            this.Controls.Add(this.tb_Stok_Adet);
            this.Controls.Add(this.lbl_Stok);
            this.Controls.Add(this.tb_Urun_Fiyati);
            this.Controls.Add(this.lbl_Urun_Fiyat);
            this.Controls.Add(this.lbl_Kategori_ID);
            this.Controls.Add(this.lbl_Tedarikci_ID);
            this.Controls.Add(this.tb_Urun_Paket_Miktari);
            this.Controls.Add(this.lbl_Paket_Miktari);
            this.Controls.Add(this.tb_Urun_Adi);
            this.Controls.Add(this.lbl_Urun_Adi);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UrunEkle";
            this.Text = "UrunEkle";
            this.Load += new System.EventHandler(this.UrunEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Urun_Adi;
        private System.Windows.Forms.TextBox tb_Urun_Adi;
        private System.Windows.Forms.TextBox tb_Urun_Paket_Miktari;
        private System.Windows.Forms.Label lbl_Paket_Miktari;
        private System.Windows.Forms.Label lbl_Tedarikci_ID;
        private System.Windows.Forms.Label lbl_Kategori_ID;
        private System.Windows.Forms.Label lbl_Urun_Fiyat;
        private System.Windows.Forms.TextBox tb_Urun_Fiyati;
        private System.Windows.Forms.TextBox tb_Stok_Adet;
        private System.Windows.Forms.Label lbl_Stok;
        private System.Windows.Forms.TextBox tb_Siparis_Edilmis_Adet;
        private System.Windows.Forms.Label lbl_Siparis_Edilmis_Adet;
        private System.Windows.Forms.TextBox tb_Ortalama_Siparis_Adet;
        private System.Windows.Forms.Label lbl_Ortalama_Siparis;
        private System.Windows.Forms.Label lbl_Uretilme_Durumu;
        private System.Windows.Forms.ComboBox cb_Tedarikci;
        private System.Windows.Forms.ComboBox cb_Kategori;
        private System.Windows.Forms.CheckBox cb_Uretilme_Durum;
        private System.Windows.Forms.Button btn_Urun_Kaydet;
    }
}