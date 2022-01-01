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
    public partial class TedarikciGoster : Form
    {
        DataModel dm = new DataModel();
        public TedarikciGoster()
        {
            InitializeComponent();
        }

        private void TedarikciGoster_Load(object sender, EventArgs e)
        {
            dgw_Tedarikci_Goster.DataSource = dm.GetSupplier();
            dgw_Tedarikci_Goster.Columns[0].Visible = false;
            dgw_Tedarikci_Goster.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgw_Tedarikci_Goster.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgw_Tedarikci_Goster.AllowUserToOrderColumns = true;
            dgw_Tedarikci_Goster.AllowUserToResizeColumns = true;
        }
    }
}
