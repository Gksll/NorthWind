using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWind.Forms
{
    public partial class CalisanEkle : Form
    {
        DataModel dm = new DataModel();
        byte[] photo;
        public CalisanEkle()
        {
            InitializeComponent();
        }

        private void tb_Fotograf_Yolu_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Title = "Open Image file";
            fileOpen.Filter = "JPG Files (*.jpg)| *.jpg";

            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                pb_1.Image = Image.FromFile(fileOpen.FileName);
            }
            fileOpen.Dispose();
            tb_Fotograf_Yolu.Text = fileOpen.FileName;
            photo = converterDemo(pb_1.Image);
        }

        private void btn_Calisan_Kaydet_Click(object sender, EventArgs e)
        {
            Employee k = new Employee();
            k.FirstName = tb_Isim.Text;
            k.LastName = tb_Soy_Isim.Text;
            k.Title = tb_Unvan.Text;
            k.TitleOfCourtesy = tb_Resmi_Unvan.Text;
            k.BirthDate = dtp_Dogum_Tarihi.Value;
            k.HireDate = dtp_Ise_Baslama_Tarihi.Value;
            k.Address = tb_Adres.Text;
            k.City = tb_Sehir.Text;
            k.Region = tb_Bolge.Text;
            k.PostalCode = tb_Posta_Kodu.Text;
            k.Country = tb_Ulke.Text;
            k.HomePhone = tb_Ev_Telefonu.Text;
            k.Extension = tb_Dahili_Numarasi.Text;
            k.Notes = tb_Not.Text;
            k.ReportsTo = Convert.ToInt32(tb_Kime_Rapor_Veriyor.Text);
            k.PhotoPath = tb_Fotograf_Yolu.Text;
            k.Photo = photo;
            bool durum = dm.AddEmployee(k);
            if (durum)
            {
                MessageBox.Show("Çalışan Başarıyla Eklendi");
            }
            else
            {
                MessageBox.Show("Bir Hata oluştu!");
            }
        }

        public static byte[] converterDemo(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }


    }
}
