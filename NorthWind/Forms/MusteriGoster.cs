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
    public partial class MusteriGoster : Form
    {
        DataModel dm = new DataModel();
        public MusteriGoster()
        {
            InitializeComponent();
        }

        private void MusteriGoster_Load(object sender, EventArgs e)
        {
            dgw_Musteri_Goster.DataSource = dm.GetCustomers();
            dgw_Musteri_Goster.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgw_Musteri_Goster.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgw_Musteri_Goster.AllowUserToOrderColumns = true;
            dgw_Musteri_Goster.AllowUserToResizeColumns = true;
        }
    }
}
