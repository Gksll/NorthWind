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
    public partial class LojistikEkle : Form
    {
        DataModel dm = new DataModel();
        public LojistikEkle()
        {
            InitializeComponent();
        }

        private void btn_Lojistik_Ekle_Click(object sender, EventArgs e)
        {
            Shipper shipper = new Shipper();
            shipper.CompanyName=tb_Sirket_Adi.Text;
            shipper.Phone=tb_Tel.Text;
            bool durum=dm.AddShipper(shipper);
            if (durum)
            {
                MessageBox.Show("Lojistik Firması Başarıyla Eklendi");
            }
            else
            {
                MessageBox.Show("Bir Hata oluştu!");
            }
        }
    }
}
