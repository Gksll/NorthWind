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
    public partial class MahalleGoster : Form
    {
        DataModel dm = new DataModel();
        public MahalleGoster()
        {
            InitializeComponent();
        }

        private void MahalleGoster_Load(object sender, EventArgs e)
        {
            dgw_Mahalle_Goster.DataSource=dm.GetTerritories();
        }
    }
}
