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
    public partial class SiparisDetayEkle : Form
    {
        DataModel dm = new DataModel();

        List<OrderDetails> siparis = new List<OrderDetails>();


      
        public SiparisDetayEkle()
        {
            InitializeComponent();

        }

        private void SiparisDetayEkle_Load(object sender, EventArgs e)
        {
            cb_Siparis_ID.DataSource = dm.GetOrders();
            cb_Siparis_ID.ValueMember = "ID";
            cb_Siparis_ID.DisplayMember = "ID";
            cb_Urun_Id.DataSource = dm.GetProduct();
            cb_Urun_Id.ValueMember = "ID";
            cb_Urun_Id.DisplayMember = "Name";
        }

        private void btn_Siparil_Detay_Ekle_Click(object sender, EventArgs e)
        {
            siparis = dm.GetOrderDetails();
            OrderDetails o = new OrderDetails();
            o.OrderID = Convert.ToInt32(cb_Siparis_ID.SelectedValue);
            o.ProductID = Convert.ToInt32(cb_Urun_Id.SelectedValue);
            o.UnitPrice = Convert.ToDecimal(tb_Fiyat.Text);
            o.Quantity = Convert.ToInt16(tb_Miktar.Text);
            o.Discount = Convert.ToSingle(tb_Indirim.Text);
            bool var = false;
            for (int i = 0; i < siparis.Count; i++)
            {
                if (siparis[i].OrderID == o.OrderID && siparis[i].ProductID == o.ProductID)
                {
                    var = true;
                    break;
                }
                else
                {
                    dm.AddOrderDetail(o);
                   
                }
            }
            if (var) 
            {
                MessageBox.Show("Aynı sipariş ve ürün numarasına ait kayıt var!");
            }
            else
            {
                MessageBox.Show("Sipariş detayı başarıyla eklendi");
            }

        }
    }
}
