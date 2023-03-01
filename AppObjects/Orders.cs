using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Objects
{
    public class Orders
    {
        public int id { get; set; }
        public int order_id { get; set; }
        public int prod_id { get; set; }
        public int quantity { get; set; }
        public long date { get; set; }

        public int _id { get; set; }
        public string _name { get; set; }
        public decimal _price { get; set; }
        public string _barcode { get; set; }
        public int _stock { get; set; }
        public string _dimension { get; set; }
        public int _status { get; set; }
        public int _discount { get; set; }
    }
}
