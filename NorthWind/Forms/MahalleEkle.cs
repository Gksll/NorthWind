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
    public partial class MahalleEkle : Form
    {
        DataModel dm = new DataModel();
        List<Territories> te;
        bool durum = false;
        public MahalleEkle()
        {
            InitializeComponent();
            te = new List<Territories>();
        }

        private void MahalleEkle_Load(object sender, EventArgs e)
        {
            cb_Bolge.DataSource = dm.GetRegion();
            cb_Bolge.ValueMember = "ID";
            cb_Bolge.DisplayMember = "RegionDescription";
            te = dm.GetTerritories();
        }

        private void btn_Mahalle_Kaydet_Click(object sender, EventArgs e)
        {

            Territories t = new Territories();
            t.ID = tb_Mahalle_Kodu.Text;
            t.TerritoryDescription = tb_Mahalle_Aciklamasi.Text;
            t.RegionID = Convert.ToInt32(cb_Bolge.SelectedValue);
            for (int i = 0; i < te.Count; i++)
            {
                if (te[i].ID == t.ID)
                {
                   
                    MessageBox.Show("Aynı mahalle kodu 2 defa girilemez!");
                    break;
                }
                else
                {
                    durum = dm.AddTerritories(t);

                }
            }
            if (durum) 
            {
                MessageBox.Show("Mahalle eklendi.");
            }
            else
            {
                MessageBox.Show("Hata oluştu!");
            }

        }
    }
}
