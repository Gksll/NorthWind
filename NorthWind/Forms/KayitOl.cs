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
    public partial class KayitOl : Form
    {
        DataModel dm = new DataModel();
        bool sifreDurum = false;
        public KayitOl()
        {
            InitializeComponent();
        }

        private void btn_Uye_Kaydet_Click(object sender, EventArgs e)
        {
            if (sifreDurum == true)
            {

                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item.Text == "")
                        {
                            ErrorProvider errorProvider1 = new ErrorProvider();
                            errorProvider1.SetError(item, "Bu alan boş bırakılamaz");
                        }
                    }
                }
                Kullanici k = new Kullanici();
                k.Isim = tb_Isim.Text;
                k.Soyad = tb_Soy_Isim.Text;
                k.Mail = tb_Mail.Text;
                k.Sifre = tb_Sifre.Text;
                bool durum = dm.KullaniciKaydet(k);
                if (durum == true)
                {
                    MessageBox.Show("Kayıt işlemi başarılı!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("kayıt sırasında sorun oluştu!");
                }

            }
            else
            {
                MessageBox.Show("Şifreler aynı olmalıdır!");
            }
        }

        private void tb_Isim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                if (e.KeyChar.Equals(' ') == false)
                {
                    e.Handled = true;
                }
            }
        }

        private void tb_Soy_Isim_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                if (e.KeyChar.Equals(' ') == false)
                {
                    e.Handled = true;
                }
            }
        }

        private void tb_Mail_Validated(object sender, EventArgs e)
        {
            dm.EmailKontrol(tb_Mail.Text);
        }

        private void tb_Onay_Validated(object sender, EventArgs e)
        {
           
                if (tb_Onay.Text == String.Empty)
                {
                btn_Onayla.Visible = false;
                }
            
            if (tb_Sifre.Text != tb_Onay.Text && tb_Sifre.Text != String.Empty && tb_Onay.Text != String.Empty)
            {
                MessageBox.Show("Girdiğiniz şifreler eşleşmedi. Tekrar deneyin.");
                sifreDurum = false;
            }
            else
            {
                sifreDurum = true;
            }
        }

        private void btn_Sifre_Goster_Click(object sender, EventArgs e)
        {
            bool d = tb_Sifre.UseSystemPasswordChar;
            if (d)
            {
                tb_Sifre.UseSystemPasswordChar = false;
            }
            else
            {
                tb_Sifre.UseSystemPasswordChar = true;
            }
        }

        private void KayitOl_Load(object sender, EventArgs e)
        {
            if (tb_Sifre.Text==String.Empty)
            {
                btn_Sifre_Goster.Visible = false;
            }
            if (tb_Onay.Text == String.Empty)
            {
                btn_Onayla.Visible = false;
            }
        }

       

        private void tb_Sifre_TextChanged(object sender, EventArgs e)
        {
            if (tb_Sifre.Text != String.Empty)
            {
                btn_Sifre_Goster.Visible = true;
            }

        }

        private void tb_Onay_TextChanged(object sender, EventArgs e)
        {
            if (tb_Onay.Text != String.Empty)
            {
                btn_Onayla.Visible = true;
            }
        }

        private void btn_Onayla_Click(object sender, EventArgs e)
        {
            bool d = tb_Onay.UseSystemPasswordChar;
            if (d)
            {
                tb_Onay.UseSystemPasswordChar = false;
            }
            else
            {
                tb_Onay.UseSystemPasswordChar = true;
            }
        }

        private void tb_Sifre_Validated(object sender, EventArgs e)
        {
            if (true)
            {
                if (tb_Sifre.Text == String.Empty)
                {
                    btn_Sifre_Goster.Visible = false;
                }
            }
        }
    }
}
