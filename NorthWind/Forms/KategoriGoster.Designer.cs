namespace NorthWind
{
    partial class KategoriGoster
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
            this.dgw_Category = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Category)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_Category
            // 
            this.dgw_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_Category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Category.Location = new System.Drawing.Point(30, 27);
            this.dgw_Category.Name = "dgw_Category";
            this.dgw_Category.RowHeadersWidth = 72;
            this.dgw_Category.RowTemplate.Height = 31;
            this.dgw_Category.Size = new System.Drawing.Size(1127, 630);
            this.dgw_Category.TabIndex = 0;
            // 
            // KategoriGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 659);
            this.Controls.Add(this.dgw_Category);
            this.Name = "KategoriGoster";
            this.Text = "KategoriGoster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KategoriGoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Category)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_Category;
    }
}