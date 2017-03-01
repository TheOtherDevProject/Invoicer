using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoicer
{
    public partial class LineInputForm : MaterialForm
    {
        private Form1 ParentContextHandle;
        public LineInputForm(Form1 parentContext)
        {
            InitializeComponent();

            MaterialSkinManager uiManager = MaterialSkin.MaterialSkinManager.Instance;
            uiManager.AddFormToManage(this);
            uiManager.Theme = MaterialSkinManager.Themes.LIGHT;
            uiManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            this.ParentContextHandle = parentContext;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.ParentContextHandle.InvoiceLinesDisplay.Items.Add($"{this.LineAmountInput.Text} - {this.DescriptionInput.Text}");
        }
    }
}
