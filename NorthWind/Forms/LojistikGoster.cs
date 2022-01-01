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

namespace NorthWind
{
    public partial class LojistikGoster : Form
    {
        DataModel dm = new DataModel();
        public LojistikGoster()
        {
            InitializeComponent();
        }

        private void LojistikGoster_Load(object sender, EventArgs e)
        {
            dgw_Lojistik_Goster.DataSource = dm.GetShipper();
            dgw_Lojistik_Goster.Columns[0].Visible = false;
            dgw_Lojistik_Goster.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgw_Lojistik_Goster.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgw_Lojistik_Goster.AllowUserToOrderColumns = true;
            dgw_Lojistik_Goster.AllowUserToResizeColumns = true;

        }
    }
}
