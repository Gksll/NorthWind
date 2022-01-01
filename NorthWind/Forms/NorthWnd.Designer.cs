namespace NorthWind
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ürünİşlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Urun_Goster = new System.Windows.Forms.ToolStripMenuItem();
            this.Urun_Ekle = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Kategori_Goster = new System.Windows.Forms.ToolStripMenuItem();
            this.Kategori_Ekle = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SiparisEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.SiparisleriGöster = new System.Windows.Forms.ToolStripMenuItem();
            this.SiparisDetay = new System.Windows.Forms.ToolStripMenuItem();
            this.SiparisDetayGoster = new System.Windows.Forms.ToolStripMenuItem();
            this.SiparisDetayEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MusteriGoster = new System.Windows.Forms.ToolStripMenuItem();
            this.Musteri_Ekle = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalisanlariGoster = new System.Windows.Forms.ToolStripMenuItem();
            this.CalisanEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.Bolgeler = new System.Windows.Forms.ToolStripMenuItem();
            this.BolgeGoster = new System.Windows.Forms.ToolStripMenuItem();
            this.BolgeEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.ilçeVeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MahalleGoster = new System.Windows.Forms.ToolStripMenuItem();
            this.MahalleEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanBölgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalisanBolge = new System.Windows.Forms.ToolStripMenuItem();
            this.lojistikFirmalarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LojistikGoster = new System.Windows.Forms.ToolStripMenuItem();
            this.LojistikEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tedarikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tedarikci_Goster = new System.Windows.Forms.ToolStripMenuItem();
            this.Tedarikci_Ekle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünİşlemlerToolStripMenuItem,
            this.siparişlerToolStripMenuItem,
            this.müşterilerToolStripMenuItem,
            this.çalışanlarToolStripMenuItem,
            this.lojistikFirmalarıToolStripMenuItem,
            this.tedarikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1120, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ürünİşlemlerToolStripMenuItem
            // 
            this.ürünİşlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünToolStripMenuItem,
            this.kategoriToolStripMenuItem});
            this.ürünİşlemlerToolStripMenuItem.Name = "ürünİşlemlerToolStripMenuItem";
            this.ürünİşlemlerToolStripMenuItem.Size = new System.Drawing.Size(154, 28);
            this.ürünİşlemlerToolStripMenuItem.Text = "Ürün İşlemleri";
            // 
            // ürünToolStripMenuItem
            // 
            this.ürünToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Urun_Goster,
            this.Urun_Ekle});
            this.ürünToolStripMenuItem.Name = "ürünToolStripMenuItem";
            this.ürünToolStripMenuItem.Size = new System.Drawing.Size(174, 28);
            this.ürünToolStripMenuItem.Text = "Ürün";
            // 
            // Urun_Goster
            // 
            this.Urun_Goster.Name = "Urun_Goster";
            this.Urun_Goster.Size = new System.Drawing.Size(211, 28);
            this.Urun_Goster.Text = "Ürün Göster";
            this.Urun_Goster.Click += new System.EventHandler(this.Urun_Goster_Click);
            // 
            // Urun_Ekle
            // 
            this.Urun_Ekle.Name = "Urun_Ekle";
            this.Urun_Ekle.Size = new System.Drawing.Size(211, 28);
            this.Urun_Ekle.Text = "Ürün Ekle";
            this.Urun_Ekle.Click += new System.EventHandler(this.Urun_Ekle_Click);
            // 
            // kategoriToolStripMenuItem
            // 
            this.kategoriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Kategori_Goster,
            this.Kategori_Ekle});
            this.kategoriToolStripMenuItem.Name = "kategoriToolStripMenuItem";
            this.kategoriToolStripMenuItem.Size = new System.Drawing.Size(174, 28);
            this.kategoriToolStripMenuItem.Text = "Kategori";
            // 
            // Kategori_Goster
            // 
            this.Kategori_Goster.Name = "Kategori_Goster";
            this.Kategori_Goster.Size = new System.Drawing.Size(245, 28);
            this.Kategori_Goster.Text = "Kategori Göster";
            this.Kategori_Goster.Click += new System.EventHandler(this.Kategori_Goster_Click);
            // 
            // Kategori_Ekle
            // 
            this.Kategori_Ekle.Name = "Kategori_Ekle";
            this.Kategori_Ekle.Size = new System.Drawing.Size(245, 28);
            this.Kategori_Ekle.Text = "Kategori Ekle";
            this.Kategori_Ekle.Click += new System.EventHandler(this.Kategori_Ekle_Click);
            // 
            // siparişlerToolStripMenuItem
            // 
            this.siparişlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SiparisEkle,
            this.SiparisleriGöster,
            this.SiparisDetay});
            this.siparişlerToolStripMenuItem.Name = "siparişlerToolStripMenuItem";
            this.siparişlerToolStripMenuItem.Size = new System.Drawing.Size(113, 28);
            this.siparişlerToolStripMenuItem.Text = "Siparişler";
            // 
            // SiparisEkle
            // 
            this.SiparisEkle.Name = "SiparisEkle";
            this.SiparisEkle.Size = new System.Drawing.Size(259, 28);
            this.SiparisEkle.Text = "Sipariş Ekle";
            this.SiparisEkle.Click += new System.EventHandler(this.SiparisEkle_Click);
            // 
            // SiparisleriGöster
            // 
            this.SiparisleriGöster.Name = "SiparisleriGöster";
            this.SiparisleriGöster.Size = new System.Drawing.Size(259, 28);
            this.SiparisleriGöster.Text = "Siparişleri Göster";
            this.SiparisleriGöster.Click += new System.EventHandler(this.SiparisleriGöster_Click);
            // 
            // SiparisDetay
            // 
            this.SiparisDetay.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SiparisDetayGoster,
            this.SiparisDetayEkle});
            this.SiparisDetay.Name = "SiparisDetay";
            this.SiparisDetay.Size = new System.Drawing.Size(259, 28);
            this.SiparisDetay.Text = "Sipariş Detayları";
            // 
            // SiparisDetayGoster
            // 
            this.SiparisDetayGoster.Name = "SiparisDetayGoster";
            this.SiparisDetayGoster.Size = new System.Drawing.Size(290, 28);
            this.SiparisDetayGoster.Text = "Sipariş Detay Göster";
            this.SiparisDetayGoster.Click += new System.EventHandler(this.SiparisDetayGoster_Click);
            // 
            // SiparisDetayEkle
            // 
            this.SiparisDetayEkle.Name = "SiparisDetayEkle";
            this.SiparisDetayEkle.Size = new System.Drawing.Size(290, 28);
            this.SiparisDetayEkle.Text = "Sipariş Detay Ekle";
            this.SiparisDetayEkle.Click += new System.EventHandler(this.SiparisDetayEkle_Click);
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MusteriGoster,
            this.Musteri_Ekle});
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(119, 28);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            // 
            // MusteriGoster
            // 
            this.MusteriGoster.Name = "MusteriGoster";
            this.MusteriGoster.Size = new System.Drawing.Size(236, 28);
            this.MusteriGoster.Text = "Müşteri Göster";
            this.MusteriGoster.Click += new System.EventHandler(this.Musteri_Goster_Click);
            // 
            // Musteri_Ekle
            // 
            this.Musteri_Ekle.Name = "Musteri_Ekle";
            this.Musteri_Ekle.Size = new System.Drawing.Size(236, 28);
            this.Musteri_Ekle.Text = "Müşteri Ekle";
            this.Musteri_Ekle.Click += new System.EventHandler(this.Musteri_Ekle_Click);
            // 
            // çalışanlarToolStripMenuItem
            // 
            this.çalışanlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CalisanlariGoster,
            this.CalisanEkle,
            this.Bolgeler,
            this.ilçeVeToolStripMenuItem,
            this.çalışanBölgeToolStripMenuItem});
            this.çalışanlarToolStripMenuItem.Name = "çalışanlarToolStripMenuItem";
            this.çalışanlarToolStripMenuItem.Size = new System.Drawing.Size(117, 28);
            this.çalışanlarToolStripMenuItem.Text = "Çalışanlar";
            // 
            // CalisanlariGoster
            // 
            this.CalisanlariGoster.Name = "CalisanlariGoster";
            this.CalisanlariGoster.Size = new System.Drawing.Size(263, 28);
            this.CalisanlariGoster.Text = "Çalışanları Göster";
            this.CalisanlariGoster.Click += new System.EventHandler(this.CalisanlariGoster_Click);
            // 
            // CalisanEkle
            // 
            this.CalisanEkle.Name = "CalisanEkle";
            this.CalisanEkle.Size = new System.Drawing.Size(263, 28);
            this.CalisanEkle.Text = "Çalışan Ekle";
            this.CalisanEkle.Click += new System.EventHandler(this.CalisanEkle_Click);
            // 
            // Bolgeler
            // 
            this.Bolgeler.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BolgeGoster,
            this.BolgeEkle});
            this.Bolgeler.Name = "Bolgeler";
            this.Bolgeler.Size = new System.Drawing.Size(263, 28);
            this.Bolgeler.Text = "Bolge";
            // 
            // BolgeGoster
            // 
            this.BolgeGoster.Name = "BolgeGoster";
            this.BolgeGoster.Size = new System.Drawing.Size(215, 28);
            this.BolgeGoster.Text = "Bölge göster";
            this.BolgeGoster.Click += new System.EventHandler(this.BolgeGoster_Click);
            // 
            // BolgeEkle
            // 
            this.BolgeEkle.Name = "BolgeEkle";
            this.BolgeEkle.Size = new System.Drawing.Size(215, 28);
            this.BolgeEkle.Text = "Bölge Ekle";
            this.BolgeEkle.Click += new System.EventHandler(this.BolgeEkle_Click);
            // 
            // ilçeVeToolStripMenuItem
            // 
            this.ilçeVeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MahalleGoster,
            this.MahalleEkle});
            this.ilçeVeToolStripMenuItem.Name = "ilçeVeToolStripMenuItem";
            this.ilçeVeToolStripMenuItem.Size = new System.Drawing.Size(263, 28);
            this.ilçeVeToolStripMenuItem.Text = "Mahalle ";
            // 
            // MahalleGoster
            // 
            this.MahalleGoster.Name = "MahalleGoster";
            this.MahalleGoster.Size = new System.Drawing.Size(237, 28);
            this.MahalleGoster.Text = "Mahalle Göster";
            this.MahalleGoster.Click += new System.EventHandler(this.MahalleGoster_Click);
            // 
            // MahalleEkle
            // 
            this.MahalleEkle.Name = "MahalleEkle";
            this.MahalleEkle.Size = new System.Drawing.Size(237, 28);
            this.MahalleEkle.Text = "Mahalle Ekle";
            this.MahalleEkle.Click += new System.EventHandler(this.MahalleEkle_Click);
            // 
            // çalışanBölgeToolStripMenuItem
            // 
            this.çalışanBölgeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CalisanBolge});
            this.çalışanBölgeToolStripMenuItem.Name = "çalışanBölgeToolStripMenuItem";
            this.çalışanBölgeToolStripMenuItem.Size = new System.Drawing.Size(263, 28);
            this.çalışanBölgeToolStripMenuItem.Text = "Çalışan Bölge";
            // 
            // CalisanBolge
            // 
            this.CalisanBolge.Name = "CalisanBolge";
            this.CalisanBolge.Size = new System.Drawing.Size(294, 28);
            this.CalisanBolge.Text = "Çalışan Bölge Göster";
            this.CalisanBolge.Click += new System.EventHandler(this.CalisanBolge_Click);
            // 
            // lojistikFirmalarıToolStripMenuItem
            // 
            this.lojistikFirmalarıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LojistikGoster,
            this.LojistikEkle});
            this.lojistikFirmalarıToolStripMenuItem.Name = "lojistikFirmalarıToolStripMenuItem";
            this.lojistikFirmalarıToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
            this.lojistikFirmalarıToolStripMenuItem.Text = "Lojistik Firmaları";
            // 
            // LojistikGoster
            // 
            this.LojistikGoster.Name = "LojistikGoster";
            this.LojistikGoster.Size = new System.Drawing.Size(321, 28);
            this.LojistikGoster.Text = "Lojistik Firmaları Göster";
            this.LojistikGoster.Click += new System.EventHandler(this.LojistikGoster_Click);
            // 
            // LojistikEkle
            // 
            this.LojistikEkle.Name = "LojistikEkle";
            this.LojistikEkle.Size = new System.Drawing.Size(321, 28);
            this.LojistikEkle.Text = "Lojistik Firması Ekle";
            this.LojistikEkle.Click += new System.EventHandler(this.LojistikEkle_Click);
            // 
            // tedarikToolStripMenuItem
            // 
            this.tedarikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tedarikci_Goster,
            this.Tedarikci_Ekle});
            this.tedarikToolStripMenuItem.Name = "tedarikToolStripMenuItem";
            this.tedarikToolStripMenuItem.Size = new System.Drawing.Size(178, 28);
            this.tedarikToolStripMenuItem.Text = "Tedarik İşlemleri";
            // 
            // Tedarikci_Goster
            // 
            this.Tedarikci_Goster.Name = "Tedarikci_Goster";
            this.Tedarikci_Goster.Size = new System.Drawing.Size(251, 28);
            this.Tedarikci_Goster.Text = "Tedarikçi Göster";
            this.Tedarikci_Goster.Click += new System.EventHandler(this.Tedarikci_Goster_Click_1);
            // 
            // Tedarikci_Ekle
            // 
            this.Tedarikci_Ekle.Name = "Tedarikci_Ekle";
            this.Tedarikci_Ekle.Size = new System.Drawing.Size(251, 28);
            this.Tedarikci_Ekle.Text = "Tedarikçi Ekle";
            this.Tedarikci_Ekle.Click += new System.EventHandler(this.Tedarikci_Ekle_Click_1);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(224, 24);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 636);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1120, 30);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1120, 666);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NorthWnd";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ürünİşlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Urun_Goster;
        private System.Windows.Forms.ToolStripMenuItem Urun_Ekle;
        private System.Windows.Forms.ToolStripMenuItem kategoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Kategori_Goster;
        private System.Windows.Forms.ToolStripMenuItem Kategori_Ekle;
        private System.Windows.Forms.ToolStripMenuItem siparişlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışanlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MusteriGoster;
        private System.Windows.Forms.ToolStripMenuItem Musteri_Ekle;
        private System.Windows.Forms.ToolStripMenuItem CalisanlariGoster;
        private System.Windows.Forms.ToolStripMenuItem CalisanEkle;
        private System.Windows.Forms.ToolStripMenuItem SiparisleriGöster;
        private System.Windows.Forms.ToolStripMenuItem SiparisEkle;
        private System.Windows.Forms.ToolStripMenuItem lojistikFirmalarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LojistikGoster;
        private System.Windows.Forms.ToolStripMenuItem LojistikEkle;
        private System.Windows.Forms.ToolStripMenuItem tedarikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tedarikci_Goster;
        private System.Windows.Forms.ToolStripMenuItem Tedarikci_Ekle;
        private System.Windows.Forms.ToolStripMenuItem SiparisDetay;
        private System.Windows.Forms.ToolStripMenuItem SiparisDetayGoster;
        private System.Windows.Forms.ToolStripMenuItem SiparisDetayEkle;
        private System.Windows.Forms.ToolStripMenuItem Bolgeler;
        private System.Windows.Forms.ToolStripMenuItem BolgeGoster;
        private System.Windows.Forms.ToolStripMenuItem BolgeEkle;
        private System.Windows.Forms.ToolStripMenuItem ilçeVeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MahalleGoster;
        private System.Windows.Forms.ToolStripMenuItem MahalleEkle;
        private System.Windows.Forms.ToolStripMenuItem çalışanBölgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CalisanBolge;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

