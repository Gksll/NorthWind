namespace NorthWind.Forms
{
    partial class BolgeEkle
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
            this.lbl_Aciklama = new System.Windows.Forms.Label();
            this.tb_Bolge_Aciklamasi = new System.Windows.Forms.TextBox();
            this.btn_Bolge_Aciklamasi_kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Aciklama
            // 
            this.lbl_Aciklama.AutoSize = true;
            this.lbl_Aciklama.Font = new System.Drawing.Font("Helvetica", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Aciklama.Location = new System.Drawing.Point(22, 39);
            this.lbl_Aciklama.Name = "lbl_Aciklama";
            this.lbl_Aciklama.Size = new System.Drawing.Size(205, 27);
            this.lbl_Aciklama.TabIndex = 0;
            this.lbl_Aciklama.Text = "Bölge Açıklaması:";
            // 
            // tb_Bolge_Aciklamasi
            // 
            this.tb_Bolge_Aciklamasi.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_Bolge_Aciklamasi.Location = new System.Drawing.Point(314, 36);
            this.tb_Bolge_Aciklamasi.Multiline = true;
            this.tb_Bolge_Aciklamasi.Name = "tb_Bolge_Aciklamasi";
            this.tb_Bolge_Aciklamasi.Size = new System.Drawing.Size(305, 181);
            this.tb_Bolge_Aciklamasi.TabIndex = 1;
            // 
            // btn_Bolge_Aciklamasi_kaydet
            // 
            this.btn_Bolge_Aciklamasi_kaydet.Font = new System.Drawing.Font("Helvetica", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bolge_Aciklamasi_kaydet.Location = new System.Drawing.Point(406, 260);
            this.btn_Bolge_Aciklamasi_kaydet.Name = "btn_Bolge_Aciklamasi_kaydet";
            this.btn_Bolge_Aciklamasi_kaydet.Size = new System.Drawing.Size(126, 47);
            this.btn_Bolge_Aciklamasi_kaydet.TabIndex = 2;
            this.btn_Bolge_Aciklamasi_kaydet.Text = "Kaydet";
            this.btn_Bolge_Aciklamasi_kaydet.UseVisualStyleBackColor = true;
            this.btn_Bolge_Aciklamasi_kaydet.Click += new System.EventHandler(this.btn_Bolge_Aciklamasi_kaydet_Click);
            // 
            // BolgeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Bolge_Aciklamasi_kaydet);
            this.Controls.Add(this.tb_Bolge_Aciklamasi);
            this.Controls.Add(this.lbl_Aciklama);
            this.Name = "BolgeEkle";
            this.Text = "BolgeEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Aciklama;
        private System.Windows.Forms.TextBox tb_Bolge_Aciklamasi;
        private System.Windows.Forms.Button btn_Bolge_Aciklamasi_kaydet;
    }
}