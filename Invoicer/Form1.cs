using iTextSharp.text;
using iTextSharp.text.pdf;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoicer
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pdfTemplate = @"C:\Users\Justthetip\Documents\Invoicer\Invoicer\Templates\MDL - With Fields.pdf.pdf";
            string pdf = @"C:\Users\Justthetip\Documents\Invoicer\Invoicer\Templates\MDL - Text Fields 2.pdf";
            PdfReader reader = new PdfReader(pdfTemplate);

            PdfStamper pdfStamper = new PdfStamper(reader, new FileStream(pdf, FileMode.Create));
            AcroFields pdfFormFields = pdfStamper.AcroFields;
            pdfFormFields.SetField("companyNameField", this.companyNameInput.Text);
            pdfFormFields.SetField("payeeAddressField", this.BillFromAddressInput.Text);
            pdfFormFields.SetField("phoneField", this.PhoneNumberInput.Text);
            pdfFormFields.SetField("ABNField", this.ABNInput.Text);
            pdfFormFields.SetField("invoiceDateField", this.InvoiceDatePicker.Text);
            pdfFormFields.SetField("descriptionField", this.DescriptionInput.Text);
            pdfFormFields.SetField("subTotalField", this.SubTotalDisplay.Text);
            pdfStamper.FormFlattening = true;
            pdfStamper.Close();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaterialSkinManager uiManager = MaterialSkin.MaterialSkinManager.Instance;
            uiManager.AddFormToManage(this);
            uiManager.Theme = MaterialSkinManager.Themes.LIGHT;
            uiManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void materialLabel9_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            var x = new LineInputForm(this);
            x.Show();
        }
    }
}
