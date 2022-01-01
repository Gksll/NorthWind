namespace NorthWind.Forms
{
    partial class CalisanGoster
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
            this.dgw_Calisan_Goster = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Calisan_Goster)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_Calisan_Goster
            // 
            this.dgw_Calisan_Goster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_Calisan_Goster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Calisan_Goster.Location = new System.Drawing.Point(9, 8);
            this.dgw_Calisan_Goster.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgw_Calisan_Goster.Name = "dgw_Calisan_Goster";
            this.dgw_Calisan_Goster.RowHeadersWidth = 72;
            this.dgw_Calisan_Goster.RowTemplate.Height = 31;
            this.dgw_Calisan_Goster.Size = new System.Drawing.Size(1231, 709);
            this.dgw_Calisan_Goster.TabIndex = 0;
            // 
            // CalisanGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 725);
            this.Controls.Add(this.dgw_Calisan_Goster);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CalisanGoster";
            this.Text = "CalisanGoster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CalisanGoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Calisan_Goster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_Calisan_Goster;
    }
}