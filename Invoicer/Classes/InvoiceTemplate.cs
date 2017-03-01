using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoicer.Classes
{
    public class InvoiceTemplate
    {
        private List<KeyValuePair<string, string>> TemplateKeys { get; set; }

        public InvoiceTemplate(AcroFields fields)
        {
            foreach (KeyValuePair<string, string> field in this.TemplateKeys)
            {
                foreach(KeyValuePair<string, AcroFields.Item> item in fields.Fields)
                {
                    
                }
                
            }
        }

        public AcroFields BuildAcroFields()
        {
            throw new NotImplementedException();   
        }
    }
}
