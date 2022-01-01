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
    public partial class SiparisleriGoster : Form
    {
        DataModel dm = new DataModel();
        public SiparisleriGoster()
        {
            InitializeComponent();
        }

        private void SiparisleriGoster_Load(object sender, EventArgs e)
        {
            dgw_Siparisleri_Goster.DataSource = dm.GetOrders();
            //dgw_Siparisleri_Goster.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            //dgw_Siparisleri_Goster.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgw_Siparisleri_Goster.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgw_Siparisleri_Goster.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgw_Siparisleri_Goster.AllowUserToOrderColumns = true;
            dgw_Siparisleri_Goster.AllowUserToResizeColumns = true;
            

        }
    }
}
