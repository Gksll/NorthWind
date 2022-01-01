namespace NorthWind.Forms
{
    partial class SiparisDetayEkle
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
            this.lbl_Siparis_ID = new System.Windows.Forms.Label();
            this.cb_Siparis_ID = new System.Windows.Forms.ComboBox();
            this.cb_Urun_Id = new System.Windows.Forms.ComboBox();
            this.lbl_Urun_ID = new System.Windows.Forms.Label();
            this.tb_Fiyat = new System.Windows.Forms.TextBox();
            this.lbl_Fiyat = new System.Windows.Forms.Label();
            this.lbl_Miktar = new System.Windows.Forms.Label();
            this.tb_Miktar = new System.Windows.Forms.TextBox();
            this.lbl_Indirim = new System.Windows.Forms.Label();
            this.tb_Indirim = new System.Windows.Forms.TextBox();
            this.btn_Siparil_Detay_Ekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Siparis_ID
            // 
            this.lbl_Siparis_ID.AutoSize = true;
            this.lbl_Siparis_ID.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Siparis_ID.Location = new System.Drawing.Point(88, 62);
            this.lbl_Siparis_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Siparis_ID.Name = "lbl_Siparis_ID";
            this.lbl_Siparis_ID.Size = new System.Drawing.Size(119, 33);
            this.lbl_Siparis_ID.TabIndex = 0;
            this.lbl_Siparis_ID.Text = "Sİpariş:";
            // 
            // cb_Siparis_ID
            // 
            this.cb_Siparis_ID.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Siparis_ID.FormattingEnabled = true;
            this.cb_Siparis_ID.Location = new System.Drawing.Point(266, 53);
            this.cb_Siparis_ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_Siparis_ID.Name = "cb_Siparis_ID";
            this.cb_Siparis_ID.Size = new System.Drawing.Size(606, 41);
            this.cb_Siparis_ID.TabIndex = 1;
            // 
            // cb_Urun_Id
            // 
            this.cb_Urun_Id.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Urun_Id.FormattingEnabled = true;
            this.cb_Urun_Id.Location = new System.Drawing.Point(266, 147);
            this.cb_Urun_Id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_Urun_Id.Name = "cb_Urun_Id";
            this.cb_Urun_Id.Size = new System.Drawing.Size(606, 41);
            this.cb_Urun_Id.TabIndex = 3;
            // 
            // lbl_Urun_ID
            // 
            this.lbl_Urun_ID.AutoSize = true;
            this.lbl_Urun_ID.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Urun_ID.Location = new System.Drawing.Point(126, 156);
            this.lbl_Urun_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Urun_ID.Name = "lbl_Urun_ID";
            this.lbl_Urun_ID.Size = new System.Drawing.Size(89, 33);
            this.lbl_Urun_ID.TabIndex = 2;
            this.lbl_Urun_ID.Text = "Ürün:";
            // 
            // tb_Fiyat
            // 
            this.tb_Fiyat.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Fiyat.Location = new System.Drawing.Point(266, 242);
            this.tb_Fiyat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Fiyat.Name = "tb_Fiyat";
            this.tb_Fiyat.Size = new System.Drawing.Size(606, 41);
            this.tb_Fiyat.TabIndex = 4;
            // 
            // lbl_Fiyat
            // 
            this.lbl_Fiyat.AutoSize = true;
            this.lbl_Fiyat.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fiyat.Location = new System.Drawing.Point(126, 250);
            this.lbl_Fiyat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Fiyat.Name = "lbl_Fiyat";
            this.lbl_Fiyat.Size = new System.Drawing.Size(89, 33);
            this.lbl_Fiyat.TabIndex = 5;
            this.lbl_Fiyat.Text = "Fiyat:";
            // 
            // lbl_Miktar
            // 
            this.lbl_Miktar.AutoSize = true;
            this.lbl_Miktar.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Miktar.Location = new System.Drawing.Point(115, 344);
            this.lbl_Miktar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Miktar.Name = "lbl_Miktar";
            this.lbl_Miktar.Size = new System.Drawing.Size(98, 33);
            this.lbl_Miktar.TabIndex = 7;
            this.lbl_Miktar.Text = "Miktar";
            // 
            // tb_Miktar
            // 
            this.tb_Miktar.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Miktar.Location = new System.Drawing.Point(266, 336);
            this.tb_Miktar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Miktar.Name = "tb_Miktar";
            this.tb_Miktar.Size = new System.Drawing.Size(606, 41);
            this.tb_Miktar.TabIndex = 6;
            // 
            // lbl_Indirim
            // 
            this.lbl_Indirim.AutoSize = true;
            this.lbl_Indirim.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Indirim.Location = new System.Drawing.Point(57, 439);
            this.lbl_Indirim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Indirim.Name = "lbl_Indirim";
            this.lbl_Indirim.Size = new System.Drawing.Size(143, 33);
            this.lbl_Indirim.TabIndex = 9;
            this.lbl_Indirim.Text = "İndirim %";
            // 
            // tb_Indirim
            // 
            this.tb_Indirim.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Indirim.Location = new System.Drawing.Point(266, 430);
            this.tb_Indirim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Indirim.Name = "tb_Indirim";
            this.tb_Indirim.Size = new System.Drawing.Size(606, 41);
            this.tb_Indirim.TabIndex = 8;
            // 
            // btn_Siparil_Detay_Ekle
            // 
            this.btn_Siparil_Detay_Ekle.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Siparil_Detay_Ekle.Location = new System.Drawing.Point(266, 510);
            this.btn_Siparil_Detay_Ekle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Siparil_Detay_Ekle.Name = "btn_Siparil_Detay_Ekle";
            this.btn_Siparil_Detay_Ekle.Size = new System.Drawing.Size(607, 58);
            this.btn_Siparil_Detay_Ekle.TabIndex = 10;
            this.btn_Siparil_Detay_Ekle.Text = "Kaydet";
            this.btn_Siparil_Detay_Ekle.UseVisualStyleBackColor = true;
            this.btn_Siparil_Detay_Ekle.Click += new System.EventHandler(this.btn_Siparil_Detay_Ekle_Click);
            // 
            // SiparisDetayEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 770);
            this.Controls.Add(this.btn_Siparil_Detay_Ekle);
            this.Controls.Add(this.lbl_Indirim);
            this.Controls.Add(this.tb_Indirim);
            this.Controls.Add(this.lbl_Miktar);
            this.Controls.Add(this.tb_Miktar);
            this.Controls.Add(this.lbl_Fiyat);
            this.Controls.Add(this.tb_Fiyat);
            this.Controls.Add(this.cb_Urun_Id);
            this.Controls.Add(this.lbl_Urun_ID);
            this.Controls.Add(this.cb_Siparis_ID);
            this.Controls.Add(this.lbl_Siparis_ID);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SiparisDetayEkle";
            this.Text = "SiparisDetayEkle";
            this.Load += new System.EventHandler(this.SiparisDetayEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Siparis_ID;
        private System.Windows.Forms.ComboBox cb_Siparis_ID;
        private System.Windows.Forms.ComboBox cb_Urun_Id;
        private System.Windows.Forms.Label lbl_Urun_ID;
        private System.Windows.Forms.TextBox tb_Fiyat;
        private System.Windows.Forms.Label lbl_Fiyat;
        private System.Windows.Forms.Label lbl_Miktar;
        private System.Windows.Forms.TextBox tb_Miktar;
        private System.Windows.Forms.Label lbl_Indirim;
        private System.Windows.Forms.TextBox tb_Indirim;
        private System.Windows.Forms.Button btn_Siparil_Detay_Ekle;
    }
}