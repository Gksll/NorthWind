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
    public partial class MusteriEkle : Form
    {
        DataModel dm = new DataModel();
        List<Customer> customers = new List<Customer>();
       bool Id_Var_Mi=false;
        public MusteriEkle()
        {
            InitializeComponent();
        }
        private void MusteriEkle_Load(object sender, EventArgs e)
        {
           
            customers = dm.GetCustomers();

        }
        private void btn_Musteri_Kaydet_Click(object sender, EventArgs e)
        {
            
            foreach (var item in customers)
            {
                if (tb_ID.Text==item.ID)
                {
                Id_Var_Mi = true;
                }

            }
            if (Id_Var_Mi==false)
            {
                Customer c = new Customer();
                c.ID = tb_ID.Text;
                c.CompanyName = tb_Sirket_Adi.Text;
                c.ContactName = tb_Yetkili_Adi.Text;
                c.ContactTitle = tb_Yetkili_Unvani.Text;
                c.Address = tb_Adres.Text;
                c.City = tb_Sehir.Text;
                c.Region = tb_Bolge.Text;
                c.PostalCode = tb_Posta_Kodu.Text;
                c.Country = tb_Ulke.Text;
                c.Phone = tb_Telefon.Text;
                c.Fax = tb_Fax.Text;
                bool durum=dm.AddCustomer(c);
                if (durum)
                {
                    MessageBox.Show("Müşteri Başarıyla Eklendi");
                }
                else
                {
                    MessageBox.Show("Bir Hata oluştu!");
                }
            }
        }

        
    }
}
