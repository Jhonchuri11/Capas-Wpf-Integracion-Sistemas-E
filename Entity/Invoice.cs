using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    internal class Invoice
    {

        public int invoiceid {  get; set; }

        public string customerid { get; set; }

        public DateTime idate { get; set; }

        public decimal total { get; set; }

        public int active { get; set; }
    }
}
