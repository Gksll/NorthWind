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
    public partial class SiparisEkle : Form
    {
        DataModel dm = new DataModel();
        public SiparisEkle()
        {
            InitializeComponent();
        }

        private void SiparisEkle_Load(object sender, EventArgs e)
        {
            cb_Calisan.DataSource = dm.GetEmployees();
            cb_Calisan.ValueMember = "ID";
            cb_Calisan.DisplayMember = "FirstName";
            cb_Musteri.DataSource = dm.GetCustomers();
            cb_Musteri.ValueMember = "ID";
            cb_Musteri.DisplayMember = "CompanyName";
            cb_Lojistik_Firma.DataSource = dm.GetShipper();
            cb_Lojistik_Firma.ValueMember = "ID";
            cb_Lojistik_Firma.DisplayMember = "CompanyName";

        }

        private void btn_Siparis_Ekle_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            o.CustomerID = cb_Musteri.SelectedValue.ToString();
            o.EmployeeID = Convert.ToInt32(cb_Calisan.SelectedValue);
            o.OrderDate = dtp_Siparis_Tarihi.Value;
            o.RequiredDate = dtp_ıstenilen_Tarih.Value;
            o.ShippedDate = dtp_Gonderilme_Tarihi.Value;
            o.ShipVia = Convert.ToInt32(cb_Lojistik_Firma.SelectedValue);
            o.Freight = Convert.ToDecimal(tb_Tasima_Ucreti.Text);
            o.ShipName = tb_Alici_Ismi.Text;
            o.ShipAddress = tb_Alici_Adresi.Text;
            o.ShipCity = tb_Alici_Sehri.Text;
            o.ShipRegion = tb_Alici_Bolgesi.Text;
            o.ShipPostalCode = tb_Alici_Posta_Kodu.Text;
            o.ShipCountry = tb_Alici_Ulke.Text;
            bool durum=dm.AddOrder(o);
            if (durum)
            {
                MessageBox.Show("Sipariş Başarıyla Eklendi");
            }
            else
            {
                MessageBox.Show("Bir Hata oluştu!");
            }
        }
    }
}
