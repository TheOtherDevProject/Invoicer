using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoicer.Classes
{
    public class InvoiceLineItem
    {
        public decimal LineItemPrice { get; set; }
        public string LineItemDesc { get; set; }
    }
}
