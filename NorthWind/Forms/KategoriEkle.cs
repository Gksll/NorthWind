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
    public partial class KategoriEkle : Form
    {
        DataModel dm = new DataModel();
        public KategoriEkle()
        {
            InitializeComponent();
        }

        private void btn_Kategori_Kaydet_Click(object sender, EventArgs e)
        {
            bool durum = false;
            Category c = new Category();
            c.Name=tb_Kategori_Adi.Text;
            c.Description = tb_Kategori_Aciklamasi.Text;
            durum=dm.AddCategory(c);
            if (durum)
            {
                MessageBox.Show("Kategori başarıyla eklendi!");
            }
            else
            {
                MessageBox.Show("Kategori eklenirken sorun oluştu!");
            }
            
        }
    }
}
