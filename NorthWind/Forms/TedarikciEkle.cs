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
    public partial class TedarikciEkle : Form
    {
        DataModel dm = new DataModel();
        public TedarikciEkle()
        {
            InitializeComponent();
        }

        private void btn_Tedarikci_Kaydet_Click(object sender, EventArgs e)
        {
            Supplier s = new Supplier();
            s.CompanyName=tb_Sirket_Adi.Text;
            s.ContactName=tb_Yetkili_Adi.Text;
            s.ContactTitle = tb_Yetkili_Unvani.Text;
            s.Address=tb_Adres.Text;
            s.City = tb_Sehir.Text;
            s.Region = tb_Bolge.Text;
            s.PostalCode = tb_Posta_Kodu.Text;
            s.Country = tb_Ulke.Text;
            s.Phone = tb_Telefon.Text;
            s.Fax = tb_Fax.Text;
            s.HomePage=tb_Kisisel_Web_Site.Text;
            bool durum = dm.AddSupplier(s);
            if (durum)
            {
                MessageBox.Show("Tedarikçi Başarıyla Eklendi");
            }
            else
            {
                MessageBox.Show("Bir Hata oluştu!");
            }
        }
    }
}
