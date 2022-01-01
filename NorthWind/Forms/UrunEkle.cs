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

namespace NorthWind.Forms
{
    public partial class UrunEkle : Form
    {
        DataModel dm = new DataModel();
        public UrunEkle()
        {
            InitializeComponent();
        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {
            cb_Kategori.DataSource = dm.GetCategory();
            cb_Kategori.ValueMember = "ID";
            cb_Kategori.DisplayMember = "Name";
            cb_Tedarikci.DataSource = dm.GetSupplier();
            cb_Tedarikci.ValueMember = "ID";
            cb_Tedarikci.DisplayMember = "CompanyName";
        }

        private void btn_Urun_Kaydet_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.Name = tb_Urun_Adi.Text;
            p.Supplier_ID = Convert.ToInt32(cb_Tedarikci.SelectedValue);
            p.Category_ID= Convert.ToInt32(cb_Kategori.SelectedValue);
            p.QuentityPerUnit=tb_Urun_Paket_Miktari.Text;
            p.UnitPrice=Convert.ToInt32(tb_Urun_Fiyati.Text);
            p.UnitsInStock=Convert.ToInt16(tb_Stok_Adet.Text);
            p.UnitsOnOrder = Convert.ToInt16(tb_Siparis_Edilmis_Adet.Text);
            p.Reorderlevel = Convert.ToInt16(tb_Ortalama_Siparis_Adet.Text);
            p.Discontinued = Convert.ToBoolean(cb_Uretilme_Durum.Checked);
            bool durum=dm.AddProduct(p);
            if (durum) 
            {
                MessageBox.Show("Ürün başarıyla eklendi!");
            }
            else
            {
                MessageBox.Show("Bir hata oluştu!");
            }
        }
    }
}
