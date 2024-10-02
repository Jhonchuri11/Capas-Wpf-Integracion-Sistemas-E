using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class InvoiceDetail
    {
        public  int detailid {  get; set; }

        public int invoiceid { get; set; }

        public int productid { get; set; }

        public int quantity { get; set; }

        public decimal price { get; set; }

        public decimal subtotal { get; set; }

        public int active { get; set; }

    }
}
