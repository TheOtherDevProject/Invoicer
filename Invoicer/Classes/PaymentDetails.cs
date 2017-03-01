using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoicer.Classes
{
    public class PaymentDetails
    {
        public string BankName { get; set; }
        public string PayeeName { get; set; }
        public string BSB { get; set; }
        public string AccountNumber { get; set; }

    }
}
