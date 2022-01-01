using DataAccessLayer;
using NorthWind.Forms;
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
    public partial class Form1 : Form
    {
        DataModel dm = new DataModel();
        public Form1()
        {
            KullaniciGiris frm = new KullaniciGiris();
            frm.ShowDialog();
            InitializeComponent();
            toolStripStatusLabel1.Text = GirisYapanKullanici.Kullanici.Isim + " " + GirisYapanKullanici.Kullanici.Soyad;
           
        }
       
        
        private void Urun_Goster_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["UrunGoster"] == null)
            {
                UrunGoster frm = new UrunGoster();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void Kategori_Goster_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["KategoriGoster"] == null)
            {
                KategoriGoster frm = new KategoriGoster();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void Kategori_Ekle_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["KategoriEkle"] == null)
            {
                KategoriEkle frm = new KategoriEkle();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void Urun_Ekle_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["UrunEkle"] == null)
            {
                UrunEkle frm = new UrunEkle();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void Tedarikci_Goster_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["TedarikciGoster"] == null)
            {
                TedarikciGoster frm = new TedarikciGoster();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void Tedarikci_Ekle_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["TedarikciEkle"] == null)
            {
                TedarikciEkle frm = new TedarikciEkle();
                frm.MdiParent = this;
                frm.Show();
            }
        }

       

        private void Musteri_Ekle_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["MusteriEkle"] == null)
            {
                MusteriEkle frm = new MusteriEkle();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void Musteri_Goster_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["MusteriGoster"] == null)
            {
                MusteriGoster frm = new MusteriGoster();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void CalisanlariGoster_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CalisanGoster"] == null)
            {
                CalisanGoster frm = new CalisanGoster();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void CalisanEkle_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CalisanEkle"] == null)
            {
                CalisanEkle frm = new CalisanEkle();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void SiparisleriGöster_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SiparisleriGoster"] == null)
            {
                SiparisleriGoster frm = new SiparisleriGoster();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void SiparisEkle_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SiparisEkle"] == null)
            {
                SiparisEkle frm = new SiparisEkle();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void LojistikGoster_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["LojistikGoster"] == null)
            {
                LojistikGoster frm = new LojistikGoster();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void LojistikEkle_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["LojistikEkle"] == null)
            {
                LojistikEkle frm = new LojistikEkle();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void Tedarikci_Goster_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms["TedarikciGoster"] == null)
            {
                TedarikciGoster frm = new TedarikciGoster();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void Tedarikci_Ekle_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms["TedarikciEkle"] == null)
            {
                TedarikciEkle frm = new TedarikciEkle();
                frm.MdiParent = this;
                frm.Show();
            }
            
        }

        private void SiparisDetayGoster_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SiparisDetayGoster"] == null)
            {
                SiparisDetayGoster frm = new SiparisDetayGoster();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void SiparisDetayEkle_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["SiparisDetayEkle"] == null)
            {
                SiparisDetayEkle frm = new SiparisDetayEkle();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void BolgeGoster_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["BolgeGoster"] == null)
            {
                BolgeGoster frm = new BolgeGoster();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void BolgeEkle_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["BolgeEkle"] == null)
            {
                BolgeEkle frm = new BolgeEkle();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void MahalleGoster_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["MahalleGoster"] == null)
            {
                MahalleGoster frm = new MahalleGoster();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void MahalleEkle_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["MahalleEkle"] == null)
            {
                MahalleEkle frm = new MahalleEkle();
                frm.MdiParent = this;
                frm.Show();
            }

        }

        private void CalisanBolge_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["CalisanBolge"] == null)
            {
                CalisanBolge frm = new CalisanBolge();
                frm.MdiParent = this;
                frm.Show();
            }
        }

       

        

    }
}
