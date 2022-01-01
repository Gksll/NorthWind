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
    public partial class KategoriGoster : Form
    {
        DataModel dm = new DataModel();
        public KategoriGoster()
        {
            InitializeComponent();
        }

        private void KategoriGoster_Load(object sender, EventArgs e)
        {
            dgw_Category.DataSource = dm.GetCategory();

            dgw_Category.Columns[0].Visible = false;
            dgw_Category.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgw_Category.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgw_Category.AllowUserToOrderColumns = true;
            dgw_Category.AllowUserToResizeColumns = true;
            dgw_Category.Columns[1].HeaderText = "İsimler";
            dgw_Category.Columns[2].HeaderText = "Açıklamalar";
        }


    }
}
