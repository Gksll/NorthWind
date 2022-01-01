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
    public partial class SiparisDetayGoster : Form
    {
        DataModel dm = new DataModel();
        public SiparisDetayGoster()
        {
            InitializeComponent();
        }

        private void SiparisDetayGoster_Load(object sender, EventArgs e)
        {
            dgw_Siparis_Detay_Goster.DataSource = dm.GetOrderDetails();
            dgw_Siparis_Detay_Goster.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgw_Siparis_Detay_Goster.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgw_Siparis_Detay_Goster.AllowUserToOrderColumns = true;
            dgw_Siparis_Detay_Goster.AllowUserToResizeColumns = true;
        }
    }
}
