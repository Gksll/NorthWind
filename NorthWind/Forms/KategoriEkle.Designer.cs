namespace NorthWind.Forms
{
    partial class KategoriEkle
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
            this.lbl_Kategori_Adi = new System.Windows.Forms.Label();
            this.tb_Kategori_Adi = new System.Windows.Forms.TextBox();
            this.lbl_Kategori_Aciklama = new System.Windows.Forms.Label();
            this.tb_Kategori_Aciklamasi = new System.Windows.Forms.TextBox();
            this.btn_Kategori_Kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Kategori_Adi
            // 
            this.lbl_Kategori_Adi.AutoSize = true;
            this.lbl_Kategori_Adi.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Kategori_Adi.Location = new System.Drawing.Point(83, 36);
            this.lbl_Kategori_Adi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Kategori_Adi.Name = "lbl_Kategori_Adi";
            this.lbl_Kategori_Adi.Size = new System.Drawing.Size(137, 24);
            this.lbl_Kategori_Adi.TabIndex = 0;
            this.lbl_Kategori_Adi.Text = "Kategori Adı:";
            // 
            // tb_Kategori_Adi
            // 
            this.tb_Kategori_Adi.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_Kategori_Adi.Location = new System.Drawing.Point(242, 36);
            this.tb_Kategori_Adi.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Kategori_Adi.Name = "tb_Kategori_Adi";
            this.tb_Kategori_Adi.Size = new System.Drawing.Size(237, 31);
            this.tb_Kategori_Adi.TabIndex = 1;
            // 
            // lbl_Kategori_Aciklama
            // 
            this.lbl_Kategori_Aciklama.AutoSize = true;
            this.lbl_Kategori_Aciklama.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Kategori_Aciklama.Location = new System.Drawing.Point(11, 99);
            this.lbl_Kategori_Aciklama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Kategori_Aciklama.Name = "lbl_Kategori_Aciklama";
            this.lbl_Kategori_Aciklama.Size = new System.Drawing.Size(209, 24);
            this.lbl_Kategori_Aciklama.TabIndex = 2;
            this.lbl_Kategori_Aciklama.Text = "Kategori Açıklaması:";
            // 
            // tb_Kategori_Aciklamasi
            // 
            this.tb_Kategori_Aciklamasi.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Kategori_Aciklamasi.Location = new System.Drawing.Point(242, 84);
            this.tb_Kategori_Aciklamasi.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Kategori_Aciklamasi.Multiline = true;
            this.tb_Kategori_Aciklamasi.Name = "tb_Kategori_Aciklamasi";
            this.tb_Kategori_Aciklamasi.Size = new System.Drawing.Size(237, 66);
            this.tb_Kategori_Aciklamasi.TabIndex = 3;
            // 
            // btn_Kategori_Kaydet
            // 
            this.btn_Kategori_Kaydet.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kategori_Kaydet.Location = new System.Drawing.Point(243, 163);
            this.btn_Kategori_Kaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Kategori_Kaydet.Name = "btn_Kategori_Kaydet";
            this.btn_Kategori_Kaydet.Size = new System.Drawing.Size(236, 31);
            this.btn_Kategori_Kaydet.TabIndex = 4;
            this.btn_Kategori_Kaydet.Text = "Kaydet";
            this.btn_Kategori_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kategori_Kaydet.Click += new System.EventHandler(this.btn_Kategori_Kaydet_Click);
            // 
            // KategoriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 318);
            this.Controls.Add(this.btn_Kategori_Kaydet);
            this.Controls.Add(this.tb_Kategori_Aciklamasi);
            this.Controls.Add(this.lbl_Kategori_Aciklama);
            this.Controls.Add(this.tb_Kategori_Adi);
            this.Controls.Add(this.lbl_Kategori_Adi);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KategoriEkle";
            this.Text = "KategoriEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Kategori_Adi;
        private System.Windows.Forms.TextBox tb_Kategori_Adi;
        private System.Windows.Forms.Label lbl_Kategori_Aciklama;
        private System.Windows.Forms.TextBox tb_Kategori_Aciklamasi;
        private System.Windows.Forms.Button btn_Kategori_Kaydet;
    }
}