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
    public partial class KullaniciGiris : Form
    {
        bool giris;
        public KullaniciGiris()
        {
            giris = false;
            InitializeComponent();
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            KayitOl frm = new KayitOl();
            frm.ShowDialog();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            DataModel dm = new DataModel();
            if (!String.IsNullOrEmpty(tb_kullaniciAdi.Text) && !String.IsNullOrEmpty(tb_Sifre.Text))
            {
                Kullanici k = dm.KullaniciGiris(tb_kullaniciAdi.Text, tb_Sifre.Text);
                if (k != null)
                {
                    this.Close();
                    giris = true;
                    GirisYapanKullanici.Kullanici = k;
                }
                else
                {
                    MessageBox.Show("Şifre yada Kullanıcı hatalı");
                }
            }
            else
            {
                MessageBox.Show("Email Ve şifre boş bırakılamaz", "Boş Veri Algılandı");
            }
        }

        private void KullaniciGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (giris == false)
            {
                MessageBox.Show("Kullanıcı Girişi Yapılmadı. Uygulama Kapatılacak");
                Application.Exit();
            }
        }
    }
}
