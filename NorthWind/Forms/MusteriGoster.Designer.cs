namespace NorthWind.Forms
{
    partial class MusteriGoster
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
            this.dgw_Musteri_Goster = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Musteri_Goster)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_Musteri_Goster
            // 
            this.dgw_Musteri_Goster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_Musteri_Goster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Musteri_Goster.Location = new System.Drawing.Point(12, 12);
            this.dgw_Musteri_Goster.Name = "dgw_Musteri_Goster";
            this.dgw_Musteri_Goster.RowHeadersWidth = 72;
            this.dgw_Musteri_Goster.RowTemplate.Height = 31;
            this.dgw_Musteri_Goster.Size = new System.Drawing.Size(1242, 923);
            this.dgw_Musteri_Goster.TabIndex = 0;
            // 
            // MusteriGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 947);
            this.Controls.Add(this.dgw_Musteri_Goster);
            this.Name = "MusteriGoster";
            this.Text = "MusteriGoster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MusteriGoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Musteri_Goster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_Musteri_Goster;
    }
}