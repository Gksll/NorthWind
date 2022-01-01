using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWind
{

    public partial class UrunGoster : Form
    {
        DataModel dm = new DataModel();
        public UrunGoster()
        {
            InitializeComponent();
        }

        private void UrunGoster_Load(object sender, EventArgs e)
        {
            dgw_Products.DataSource = dm.GetProduct();
            dgw_Products.Columns[0].Visible = false;
            dgw_Products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgw_Products.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgw_Products.AllowUserToOrderColumns = true;
            dgw_Products.AllowUserToResizeColumns = true;
            //dgw_Products.Columns[5].Width = 150;
            dgw_Products.Columns[1].HeaderText ="Ürün İsmi";
            dgw_Products.Columns[4].HeaderText = "Ürün Paket Miktarı";
            dgw_Products.Columns[5].HeaderText = "Ürün Fiyatı";
            dgw_Products.Columns[6].HeaderText = "Stok Adet";
            dgw_Products.Columns[7].HeaderText = "Sipariş edilmiş Adet";
            dgw_Products.Columns[8].HeaderText = "Ortalama Sipariş Adet";
            dgw_Products.Columns[9].HeaderText = "Üretilmiyor?";


           // dgw_Products.Columns[2].Visible = false;
          //  dgw_Products.Columns[3].Visible = false;
        }


    }
}
