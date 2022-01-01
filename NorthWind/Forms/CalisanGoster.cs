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
    public partial class CalisanGoster : Form
    {
        DataModel dm = new DataModel();
        public CalisanGoster()
        {
            InitializeComponent();
        }

        private void CalisanGoster_Load(object sender, EventArgs e)
        {
            dgw_Calisan_Goster.DataSource = dm.GetEmployees();
            dgw_Calisan_Goster.Columns[0].Visible = false;
            dgw_Calisan_Goster.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgw_Calisan_Goster.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgw_Calisan_Goster.AllowUserToOrderColumns = true;
            dgw_Calisan_Goster.AllowUserToResizeColumns = true;

        }
    }
}
