namespace NorthWind.Forms
{
    partial class CalisanBolge
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
            this.dgw_Calisan_Bolge = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Calisan_Bolge)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_Calisan_Bolge
            // 
            this.dgw_Calisan_Bolge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_Calisan_Bolge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Calisan_Bolge.Location = new System.Drawing.Point(12, 12);
            this.dgw_Calisan_Bolge.Name = "dgw_Calisan_Bolge";
            this.dgw_Calisan_Bolge.RowHeadersWidth = 51;
            this.dgw_Calisan_Bolge.RowTemplate.Height = 24;
            this.dgw_Calisan_Bolge.Size = new System.Drawing.Size(776, 426);
            this.dgw_Calisan_Bolge.TabIndex = 0;
            // 
            // CalisanBolge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgw_Calisan_Bolge);
            this.Name = "CalisanBolge";
            this.Text = "CalisanBolge";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CalisanBolge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Calisan_Bolge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_Calisan_Bolge;
    }
}