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
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgw_Products.Columns.Add(btn);
            btn.HeaderText = "Delete";
            btn.Text = "Sil";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
        }

        private void dgw_Products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // MessageBox.Show((e.ColumnIndex.ToString())+" - "+(e.RowIndex.ToString()));
            if (e.ColumnIndex == 0)
            {
                Product product = new Product();
                product = products[e.RowIndex];
               DialogResult s= MessageBox.Show(product.Name+" adlı ürün siliecektir. Onayılıyor musunuz?","Uyarı",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (s == DialogResult.Yes) 
                {
                     durum = dm.DeleteProduct(product.ID);
                }
                else
                {
                    durum = false;
                }
                
                if (durum)
                {
                    MessageBox.Show("Kayıt silinmiştir.");
                }
                else
                {
                    MessageBox.Show("Hata");
                }
                
         }
            dgw_Products.DataSource = dm.GetProduct();
        }
    }
}
