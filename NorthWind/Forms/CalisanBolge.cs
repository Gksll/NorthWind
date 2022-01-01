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
    public partial class CalisanBolge : Form
    {
        DataModel dm = new DataModel();
        public CalisanBolge()
        {
            InitializeComponent();
        }

        private void CalisanBolge_Load(object sender, EventArgs e)
        {
            dgw_Calisan_Bolge.DataSource = dm.GetEmployeeTerritories();
        }
    }
}
