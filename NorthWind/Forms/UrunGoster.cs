using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NorthWind
{

    public partial class UrunGoster : Form
    {
        DataModel dm = new DataModel();
        List<Product> products;
        bool durum;
        public UrunGoster()
        {
            InitializeComponent();
        }

        private void UrunGoster_Load(object sender, EventArgs e)
        {
            products = new List<Product>();
            dgw_Products.DataSource = dm.GetProduct();
            products = dm.GetProduct();
            dgw_Products.Columns[0].Visible = false;
            dgw_Products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgw_Products.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgw_Products.AllowUserToOrderColumns = true;
            dgw_Products.AllowUserToResizeColumns = true;

        }



    }
}
