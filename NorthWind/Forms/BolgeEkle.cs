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
    public partial class BolgeEkle : Form
    {
        DataModel dm = new DataModel();
        public BolgeEkle()
        {
            InitializeComponent();
        }

        private void btn_Bolge_Aciklamasi_kaydet_Click(object sender, EventArgs e)
        {
            DataAccessLayer.Region r = new DataAccessLayer.Region();
            r.RegionDescription =tb_Bolge_Aciklamasi.Text;
            dm.AddRegion(r);
        }
    }
}
