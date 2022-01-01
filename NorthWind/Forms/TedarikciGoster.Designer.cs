namespace NorthWind.Forms
{
    partial class TedarikciGoster
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
            this.dgw_Tedarikci_Goster = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Tedarikci_Goster)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_Tedarikci_Goster
            // 
            this.dgw_Tedarikci_Goster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_Tedarikci_Goster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Tedarikci_Goster.Location = new System.Drawing.Point(12, 12);
            this.dgw_Tedarikci_Goster.Name = "dgw_Tedarikci_Goster";
            this.dgw_Tedarikci_Goster.RowHeadersWidth = 51;
            this.dgw_Tedarikci_Goster.RowTemplate.Height = 24;
            this.dgw_Tedarikci_Goster.Size = new System.Drawing.Size(1183, 940);
            this.dgw_Tedarikci_Goster.TabIndex = 0;
            // 
            // TedarikciGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 964);
            this.Controls.Add(this.dgw_Tedarikci_Goster);
            this.Name = "TedarikciGoster";
            this.Text = "TedarikciGoster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TedarikciGoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Tedarikci_Goster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_Tedarikci_Goster;
    }
}