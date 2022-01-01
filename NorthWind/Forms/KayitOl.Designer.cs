namespace NorthWind.Forms
{
    partial class KayitOl
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
            this.lbl_Isim = new System.Windows.Forms.Label();
            this.lbl_Soy_Isim = new System.Windows.Forms.Label();
            this.lbl_Mail = new System.Windows.Forms.Label();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.lbl_Onayla = new System.Windows.Forms.Label();
            this.tb_Isim = new System.Windows.Forms.TextBox();
            this.tb_Soy_Isim = new System.Windows.Forms.TextBox();
            this.tb_Mail = new System.Windows.Forms.TextBox();
            this.tb_Sifre = new System.Windows.Forms.TextBox();
            this.tb_Onay = new System.Windows.Forms.TextBox();
            this.btn_Uye_Kaydet = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Isim
            // 
            this.lbl_Isim.AutoSize = true;
            this.lbl_Isim.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Isim.Location = new System.Drawing.Point(56, 222);
            this.lbl_Isim.Name = "lbl_Isim";
            this.lbl_Isim.Size = new System.Drawing.Size(57, 24);
            this.lbl_Isim.TabIndex = 0;
            this.lbl_Isim.Text = "İsim:";
            // 
            // lbl_Soy_Isim
            // 
            this.lbl_Soy_Isim.AutoSize = true;
            this.lbl_Soy_Isim.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Soy_Isim.Location = new System.Drawing.Point(12, 269);
            this.lbl_Soy_Isim.Name = "lbl_Soy_Isim";
            this.lbl_Soy_Isim.Size = new System.Drawing.Size(101, 24);
            this.lbl_Soy_Isim.TabIndex = 1;
            this.lbl_Soy_Isim.Text = "Soy İsim:";
            // 
            // lbl_Mail
            // 
            this.lbl_Mail.AutoSize = true;
            this.lbl_Mail.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mail.Location = new System.Drawing.Point(57, 312);
            this.lbl_Mail.Name = "lbl_Mail";
            this.lbl_Mail.Size = new System.Drawing.Size(56, 24);
            this.lbl_Mail.TabIndex = 2;
            this.lbl_Mail.Text = "Mail:";
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sifre.Location = new System.Drawing.Point(51, 359);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(62, 24);
            this.lbl_Sifre.TabIndex = 3;
            this.lbl_Sifre.Text = "Şifre:";
            // 
            // lbl_Onayla
            // 
            this.lbl_Onayla.AutoSize = true;
            this.lbl_Onayla.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Onayla.Location = new System.Drawing.Point(30, 406);
            this.lbl_Onayla.Name = "lbl_Onayla";
            this.lbl_Onayla.Size = new System.Drawing.Size(83, 24);
            this.lbl_Onayla.TabIndex = 4;
            this.lbl_Onayla.Text = "Onayla:";
            // 
            // tb_Isim
            // 
            this.tb_Isim.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Isim.Location = new System.Drawing.Point(126, 215);
            this.tb_Isim.Name = "tb_Isim";
            this.tb_Isim.Size = new System.Drawing.Size(251, 31);
            this.tb_Isim.TabIndex = 5;
            this.tb_Isim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Isim_KeyPress);
            // 
            // tb_Soy_Isim
            // 
            this.tb_Soy_Isim.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Soy_Isim.Location = new System.Drawing.Point(126, 262);
            this.tb_Soy_Isim.Name = "tb_Soy_Isim";
            this.tb_Soy_Isim.Size = new System.Drawing.Size(251, 31);
            this.tb_Soy_Isim.TabIndex = 6;
            this.tb_Soy_Isim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Soy_Isim_KeyPress);
            // 
            // tb_Mail
            // 
            this.tb_Mail.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mail.Location = new System.Drawing.Point(126, 309);
            this.tb_Mail.Name = "tb_Mail";
            this.tb_Mail.Size = new System.Drawing.Size(251, 31);
            this.tb_Mail.TabIndex = 7;
            this.tb_Mail.Validated += new System.EventHandler(this.tb_Mail_Validated);
            // 
            // tb_Sifre
            // 
            this.tb_Sifre.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sifre.Location = new System.Drawing.Point(126, 356);
            this.tb_Sifre.Name = "tb_Sifre";
            this.tb_Sifre.Size = new System.Drawing.Size(251, 31);
            this.tb_Sifre.TabIndex = 8;
            // 
            // tb_Onay
            // 
            this.tb_Onay.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Onay.Location = new System.Drawing.Point(126, 406);
            this.tb_Onay.Name = "tb_Onay";
            this.tb_Onay.Size = new System.Drawing.Size(251, 31);
            this.tb_Onay.TabIndex = 9;
            this.tb_Onay.Validated += new System.EventHandler(this.tb_Onay_Validated);
            // 
            // btn_Uye_Kaydet
            // 
            this.btn_Uye_Kaydet.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Uye_Kaydet.Location = new System.Drawing.Point(126, 450);
            this.btn_Uye_Kaydet.Name = "btn_Uye_Kaydet";
            this.btn_Uye_Kaydet.Size = new System.Drawing.Size(249, 32);
            this.btn_Uye_Kaydet.TabIndex = 10;
            this.btn_Uye_Kaydet.Text = "Kaydet";
            this.btn_Uye_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Uye_Kaydet.Click += new System.EventHandler(this.btn_Uye_Kaydet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NorthWind.Properties.Resources.team;
            this.pictureBox1.Location = new System.Drawing.Point(126, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // KayitOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 511);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Uye_Kaydet);
            this.Controls.Add(this.tb_Onay);
            this.Controls.Add(this.tb_Sifre);
            this.Controls.Add(this.tb_Mail);
            this.Controls.Add(this.tb_Soy_Isim);
            this.Controls.Add(this.tb_Isim);
            this.Controls.Add(this.lbl_Onayla);
            this.Controls.Add(this.lbl_Sifre);
            this.Controls.Add(this.lbl_Mail);
            this.Controls.Add(this.lbl_Soy_Isim);
            this.Controls.Add(this.lbl_Isim);
            this.Name = "KayitOl";
            this.Text = "KayitOl";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Isim;
        private System.Windows.Forms.Label lbl_Soy_Isim;
        private System.Windows.Forms.Label lbl_Mail;
        private System.Windows.Forms.Label lbl_Sifre;
        private System.Windows.Forms.Label lbl_Onayla;
        private System.Windows.Forms.TextBox tb_Isim;
        private System.Windows.Forms.TextBox tb_Soy_Isim;
        private System.Windows.Forms.TextBox tb_Mail;
        private System.Windows.Forms.TextBox tb_Sifre;
        private System.Windows.Forms.TextBox tb_Onay;
        private System.Windows.Forms.Button btn_Uye_Kaydet;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}