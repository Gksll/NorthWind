using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Supplier_ID { get; set; }
        public int Category_ID { get; set; }
        public string QuentityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public short UnitsOnOrder { get; set; }
        public short Reorderlevel { get; set; }
        public bool Discontinued { get; set; }
    }
}
