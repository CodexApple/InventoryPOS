using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Objects
{
    public class Receivables
    {
        public int transaction_number { get; set; }
        public string customer_name { get; set; }
        public decimal amount { get; set; }
        public long date { get; set; }
        public long due_date { get; set; }
    }
}
