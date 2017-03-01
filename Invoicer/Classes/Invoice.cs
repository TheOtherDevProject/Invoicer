using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoicer.Classes
{
    public class Invoice
    {
        public decimal InvoiceTotal { get; private set; }
        public string InvoiceDescription { get; private set; }
        public DateTime InvoiceDueDate { get; private set; }
        public DateTime InvoiceIssueDate { get; private set; }
        public string InvoiceABN { get; private set; }
        public string BillToAddress { get; private set; }
        public string IssuanceCompanyName { get; private set; }
        public string BillFromAddress { get; private set; }
        public List<InvoiceLineItem> LineItems { get; set; }

        public Invoice()
        {

        }

        public void AddInvoiceLine(string lineItemDesc, decimal lineItemCost)
        {
            this.LineItems.Add(new InvoiceLineItem
            {
                LineItemDesc = lineItemDesc,
                 LineItemPrice = lineItemCost
            });
            this.RecalculateLineItemTotals();
        }

        private void RecalculateLineItemTotals()
        {
            InvoiceTotal = Decimal.Round(LineItems.Sum(o => o.LineItemPrice), MidpointRounding.AwayFromZero) ;
        }


    }
}
