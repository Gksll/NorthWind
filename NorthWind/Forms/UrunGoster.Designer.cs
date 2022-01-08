namespace NorthWind
{
    partial class UrunGoster
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
            this.dgw_Products = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Products)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_Products
            // 
            this.dgw_Products.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Products.Location = new System.Drawing.Point(7, 6);
            this.dgw_Products.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgw_Products.Name = "dgw_Products";
            this.dgw_Products.RowHeadersWidth = 72;
            this.dgw_Products.RowTemplate.Height = 31;
            this.dgw_Products.Size = new System.Drawing.Size(890, 626);
            this.dgw_Products.TabIndex = 0;
            this.dgw_Products.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_Products_CellContentClick);
            // 
            // UrunGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 575);
            this.Controls.Add(this.dgw_Products);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UrunGoster";
            this.Text = "UrunGoster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UrunGoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Products)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_Products;
    }
}