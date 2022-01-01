namespace NorthWind
{
    partial class LojistikEkle
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
            this.btn_Lojistik_Ekle = new System.Windows.Forms.Button();
            this.lbl_Firma_Adı = new System.Windows.Forms.Label();
            this.tb_Sirket_Adi = new System.Windows.Forms.TextBox();
            this.tb_Tel = new System.Windows.Forms.TextBox();
            this.lbl_Tel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Lojistik_Ekle
            // 
            this.btn_Lojistik_Ekle.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lojistik_Ekle.Location = new System.Drawing.Point(163, 159);
            this.btn_Lojistik_Ekle.Name = "btn_Lojistik_Ekle";
            this.btn_Lojistik_Ekle.Size = new System.Drawing.Size(208, 43);
            this.btn_Lojistik_Ekle.TabIndex = 0;
            this.btn_Lojistik_Ekle.Text = "Kaydet";
            this.btn_Lojistik_Ekle.UseVisualStyleBackColor = true;
            this.btn_Lojistik_Ekle.Click += new System.EventHandler(this.btn_Lojistik_Ekle_Click);
            // 
            // lbl_Firma_Adı
            // 
            this.lbl_Firma_Adı.AutoSize = true;
            this.lbl_Firma_Adı.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Firma_Adı.Location = new System.Drawing.Point(29, 42);
            this.lbl_Firma_Adı.Name = "lbl_Firma_Adı";
            this.lbl_Firma_Adı.Size = new System.Drawing.Size(111, 24);
            this.lbl_Firma_Adı.TabIndex = 1;
            this.lbl_Firma_Adı.Text = "Şirket Adı:";
            // 
            // tb_Sirket_Adi
            // 
            this.tb_Sirket_Adi.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sirket_Adi.Location = new System.Drawing.Point(163, 35);
            this.tb_Sirket_Adi.Name = "tb_Sirket_Adi";
            this.tb_Sirket_Adi.Size = new System.Drawing.Size(208, 31);
            this.tb_Sirket_Adi.TabIndex = 2;
            // 
            // tb_Tel
            // 
            this.tb_Tel.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Tel.Location = new System.Drawing.Point(163, 93);
            this.tb_Tel.Name = "tb_Tel";
            this.tb_Tel.Size = new System.Drawing.Size(208, 31);
            this.tb_Tel.TabIndex = 4;
            // 
            // lbl_Tel
            // 
            this.lbl_Tel.AutoSize = true;
            this.lbl_Tel.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tel.Location = new System.Drawing.Point(51, 100);
            this.lbl_Tel.Name = "lbl_Tel";
            this.lbl_Tel.Size = new System.Drawing.Size(89, 24);
            this.lbl_Tel.TabIndex = 3;
            this.lbl_Tel.Text = "Telefon:";
            // 
            // LojistikEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 450);
            this.Controls.Add(this.tb_Tel);
            this.Controls.Add(this.lbl_Tel);
            this.Controls.Add(this.tb_Sirket_Adi);
            this.Controls.Add(this.lbl_Firma_Adı);
            this.Controls.Add(this.btn_Lojistik_Ekle);
            this.Name = "LojistikEkle";
            this.Text = "LojistikEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Lojistik_Ekle;
        private System.Windows.Forms.Label lbl_Firma_Adı;
        private System.Windows.Forms.TextBox tb_Sirket_Adi;
        private System.Windows.Forms.TextBox tb_Tel;
        private System.Windows.Forms.Label lbl_Tel;
    }
}