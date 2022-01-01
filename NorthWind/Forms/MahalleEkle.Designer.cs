namespace NorthWind.Forms
{
    partial class MahalleEkle
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
            this.lbl_Mahalle_Kodu = new System.Windows.Forms.Label();
            this.tb_Mahalle_Kodu = new System.Windows.Forms.TextBox();
            this.lbl_Mahalle_Aciklamasi = new System.Windows.Forms.Label();
            this.tb_Mahalle_Aciklamasi = new System.Windows.Forms.TextBox();
            this.lbl_Bolge = new System.Windows.Forms.Label();
            this.cb_Bolge = new System.Windows.Forms.ComboBox();
            this.btn_Mahalle_Kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Mahalle_Kodu
            // 
            this.lbl_Mahalle_Kodu.AutoSize = true;
            this.lbl_Mahalle_Kodu.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mahalle_Kodu.Location = new System.Drawing.Point(60, 25);
            this.lbl_Mahalle_Kodu.Name = "lbl_Mahalle_Kodu";
            this.lbl_Mahalle_Kodu.Size = new System.Drawing.Size(149, 24);
            this.lbl_Mahalle_Kodu.TabIndex = 0;
            this.lbl_Mahalle_Kodu.Text = "Mahalle Kodu:";
            // 
            // tb_Mahalle_Kodu
            // 
            this.tb_Mahalle_Kodu.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mahalle_Kodu.Location = new System.Drawing.Point(215, 25);
            this.tb_Mahalle_Kodu.Name = "tb_Mahalle_Kodu";
            this.tb_Mahalle_Kodu.Size = new System.Drawing.Size(250, 31);
            this.tb_Mahalle_Kodu.TabIndex = 1;
            // 
            // lbl_Mahalle_Aciklamasi
            // 
            this.lbl_Mahalle_Aciklamasi.AutoSize = true;
            this.lbl_Mahalle_Aciklamasi.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mahalle_Aciklamasi.Location = new System.Drawing.Point(9, 75);
            this.lbl_Mahalle_Aciklamasi.Name = "lbl_Mahalle_Aciklamasi";
            this.lbl_Mahalle_Aciklamasi.Size = new System.Drawing.Size(200, 24);
            this.lbl_Mahalle_Aciklamasi.TabIndex = 2;
            this.lbl_Mahalle_Aciklamasi.Text = "Mahalle Açıklaması:";
            // 
            // tb_Mahalle_Aciklamasi
            // 
            this.tb_Mahalle_Aciklamasi.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mahalle_Aciklamasi.Location = new System.Drawing.Point(215, 75);
            this.tb_Mahalle_Aciklamasi.Multiline = true;
            this.tb_Mahalle_Aciklamasi.Name = "tb_Mahalle_Aciklamasi";
            this.tb_Mahalle_Aciklamasi.Size = new System.Drawing.Size(250, 83);
            this.tb_Mahalle_Aciklamasi.TabIndex = 3;
            // 
            // lbl_Bolge
            // 
            this.lbl_Bolge.AutoSize = true;
            this.lbl_Bolge.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bolge.Location = new System.Drawing.Point(135, 200);
            this.lbl_Bolge.Name = "lbl_Bolge";
            this.lbl_Bolge.Size = new System.Drawing.Size(74, 24);
            this.lbl_Bolge.TabIndex = 4;
            this.lbl_Bolge.Text = "Bölge:";
            // 
            // cb_Bolge
            // 
            this.cb_Bolge.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Bolge.FormattingEnabled = true;
            this.cb_Bolge.Location = new System.Drawing.Point(215, 200);
            this.cb_Bolge.Name = "cb_Bolge";
            this.cb_Bolge.Size = new System.Drawing.Size(250, 32);
            this.cb_Bolge.TabIndex = 5;
            // 
            // btn_Mahalle_Kaydet
            // 
            this.btn_Mahalle_Kaydet.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mahalle_Kaydet.Location = new System.Drawing.Point(316, 252);
            this.btn_Mahalle_Kaydet.Name = "btn_Mahalle_Kaydet";
            this.btn_Mahalle_Kaydet.Size = new System.Drawing.Size(149, 42);
            this.btn_Mahalle_Kaydet.TabIndex = 6;
            this.btn_Mahalle_Kaydet.Text = "Kaydet";
            this.btn_Mahalle_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Mahalle_Kaydet.Click += new System.EventHandler(this.btn_Mahalle_Kaydet_Click);
            // 
            // MahalleEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Mahalle_Kaydet);
            this.Controls.Add(this.cb_Bolge);
            this.Controls.Add(this.lbl_Bolge);
            this.Controls.Add(this.tb_Mahalle_Aciklamasi);
            this.Controls.Add(this.lbl_Mahalle_Aciklamasi);
            this.Controls.Add(this.tb_Mahalle_Kodu);
            this.Controls.Add(this.lbl_Mahalle_Kodu);
            this.Name = "MahalleEkle";
            this.Text = "MahalleEkle";
            this.Load += new System.EventHandler(this.MahalleEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Mahalle_Kodu;
        private System.Windows.Forms.TextBox tb_Mahalle_Kodu;
        private System.Windows.Forms.Label lbl_Mahalle_Aciklamasi;
        private System.Windows.Forms.TextBox tb_Mahalle_Aciklamasi;
        private System.Windows.Forms.Label lbl_Bolge;
        private System.Windows.Forms.ComboBox cb_Bolge;
        private System.Windows.Forms.Button btn_Mahalle_Kaydet;
    }
}