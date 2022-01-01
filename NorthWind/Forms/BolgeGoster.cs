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
    public partial class BolgeGoster : Form
    {
        DataModel dm = new DataModel();
        public BolgeGoster()
        {
            InitializeComponent();
        }

        private void BolgeGoster_Load(object sender, EventArgs e)
        {
            dgw_Bolge_Goster.DataSource = dm.GetRegion();
        }
    }
}
