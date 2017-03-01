namespace Invoicer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.companyNameLbl = new MaterialSkin.Controls.MaterialLabel();
            this.companyNameInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.InvoiceLinesDisplay = new System.Windows.Forms.ListBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BillFromAddressInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PhoneNumberInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ABNInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BankNameInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PayeeNameInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BSBInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.AccountNumberInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.DescriptionInput = new System.Windows.Forms.TextBox();
            this.BillToAddressInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.InvoiceDatePicker = new System.Windows.Forms.DateTimePicker();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.SubTotalDisplay = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 723);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Debug Output";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // companyNameLbl
            // 
            this.companyNameLbl.AutoSize = true;
            this.companyNameLbl.Depth = 0;
            this.companyNameLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.companyNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.companyNameLbl.Location = new System.Drawing.Point(3, 0);
            this.companyNameLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.companyNameLbl.Name = "companyNameLbl";
            this.companyNameLbl.Size = new System.Drawing.Size(116, 19);
            this.companyNameLbl.TabIndex = 1;
            this.companyNameLbl.Text = "Company Name";
            // 
            // companyNameInput
            // 
            this.companyNameInput.Depth = 0;
            this.companyNameInput.Hint = "";
            this.companyNameInput.Location = new System.Drawing.Point(157, 3);
            this.companyNameInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.companyNameInput.Name = "companyNameInput";
            this.companyNameInput.PasswordChar = '\0';
            this.companyNameInput.SelectedText = "";
            this.companyNameInput.SelectionLength = 0;
            this.companyNameInput.SelectionStart = 0;
            this.companyNameInput.Size = new System.Drawing.Size(149, 23);
            this.companyNameInput.TabIndex = 2;
            this.companyNameInput.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 32);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(128, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Bill From Address";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(3, 64);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(108, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Phone Number";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(3, 96);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(39, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "ABN";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(583, 726);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(140, 32);
            this.materialRaisedButton1.TabIndex = 6;
            this.materialRaisedButton1.Text = "Generate Invoice";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(3, 128);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(86, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Bank Name";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(3, 160);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(93, 19);
            this.materialLabel5.TabIndex = 8;
            this.materialLabel5.Text = "Payee Name";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(3, 192);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(36, 19);
            this.materialLabel6.TabIndex = 9;
            this.materialLabel6.Text = "BSB";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(3, 224);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(122, 19);
            this.materialLabel7.TabIndex = 10;
            this.materialLabel7.Text = "Account Number";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(16, 350);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(707, 10);
            this.materialDivider1.TabIndex = 11;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // InvoiceLinesDisplay
            // 
            this.InvoiceLinesDisplay.FormattingEnabled = true;
            this.InvoiceLinesDisplay.Location = new System.Drawing.Point(16, 404);
            this.InvoiceLinesDisplay.Name = "InvoiceLinesDisplay";
            this.InvoiceLinesDisplay.Size = new System.Drawing.Size(707, 225);
            this.InvoiceLinesDisplay.TabIndex = 12;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(3, 0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(92, 19);
            this.materialLabel8.TabIndex = 13;
            this.materialLabel8.Text = "Invoice Date";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.companyNameLbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.companyNameInput, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.BillFromAddressInput, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PhoneNumberInput, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ABNInput, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.BankNameInput, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.PayeeNameInput, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.BSBInput, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.AccountNumberInput, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 81);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(309, 263);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // BillFromAddressInput
            // 
            this.BillFromAddressInput.Depth = 0;
            this.BillFromAddressInput.Hint = "";
            this.BillFromAddressInput.Location = new System.Drawing.Point(157, 35);
            this.BillFromAddressInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.BillFromAddressInput.Name = "BillFromAddressInput";
            this.BillFromAddressInput.PasswordChar = '\0';
            this.BillFromAddressInput.SelectedText = "";
            this.BillFromAddressInput.SelectionLength = 0;
            this.BillFromAddressInput.SelectionStart = 0;
            this.BillFromAddressInput.Size = new System.Drawing.Size(149, 23);
            this.BillFromAddressInput.TabIndex = 11;
            this.BillFromAddressInput.UseSystemPasswordChar = false;
            // 
            // PhoneNumberInput
            // 
            this.PhoneNumberInput.Depth = 0;
            this.PhoneNumberInput.Hint = "";
            this.PhoneNumberInput.Location = new System.Drawing.Point(157, 67);
            this.PhoneNumberInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.PhoneNumberInput.Name = "PhoneNumberInput";
            this.PhoneNumberInput.PasswordChar = '\0';
            this.PhoneNumberInput.SelectedText = "";
            this.PhoneNumberInput.SelectionLength = 0;
            this.PhoneNumberInput.SelectionStart = 0;
            this.PhoneNumberInput.Size = new System.Drawing.Size(149, 23);
            this.PhoneNumberInput.TabIndex = 12;
            this.PhoneNumberInput.UseSystemPasswordChar = false;
            // 
            // ABNInput
            // 
            this.ABNInput.Depth = 0;
            this.ABNInput.Hint = "";
            this.ABNInput.Location = new System.Drawing.Point(157, 99);
            this.ABNInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.ABNInput.Name = "ABNInput";
            this.ABNInput.PasswordChar = '\0';
            this.ABNInput.SelectedText = "";
            this.ABNInput.SelectionLength = 0;
            this.ABNInput.SelectionStart = 0;
            this.ABNInput.Size = new System.Drawing.Size(149, 23);
            this.ABNInput.TabIndex = 13;
            this.ABNInput.UseSystemPasswordChar = false;
            // 
            // BankNameInput
            // 
            this.BankNameInput.Depth = 0;
            this.BankNameInput.Hint = "";
            this.BankNameInput.Location = new System.Drawing.Point(157, 131);
            this.BankNameInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.BankNameInput.Name = "BankNameInput";
            this.BankNameInput.PasswordChar = '\0';
            this.BankNameInput.SelectedText = "";
            this.BankNameInput.SelectionLength = 0;
            this.BankNameInput.SelectionStart = 0;
            this.BankNameInput.Size = new System.Drawing.Size(149, 23);
            this.BankNameInput.TabIndex = 14;
            this.BankNameInput.UseSystemPasswordChar = false;
            // 
            // PayeeNameInput
            // 
            this.PayeeNameInput.Depth = 0;
            this.PayeeNameInput.Hint = "";
            this.PayeeNameInput.Location = new System.Drawing.Point(157, 163);
            this.PayeeNameInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.PayeeNameInput.Name = "PayeeNameInput";
            this.PayeeNameInput.PasswordChar = '\0';
            this.PayeeNameInput.SelectedText = "";
            this.PayeeNameInput.SelectionLength = 0;
            this.PayeeNameInput.SelectionStart = 0;
            this.PayeeNameInput.Size = new System.Drawing.Size(149, 23);
            this.PayeeNameInput.TabIndex = 15;
            this.PayeeNameInput.UseSystemPasswordChar = false;
            // 
            // BSBInput
            // 
            this.BSBInput.Depth = 0;
            this.BSBInput.Hint = "";
            this.BSBInput.Location = new System.Drawing.Point(157, 195);
            this.BSBInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.BSBInput.Name = "BSBInput";
            this.BSBInput.PasswordChar = '\0';
            this.BSBInput.SelectedText = "";
            this.BSBInput.SelectionLength = 0;
            this.BSBInput.SelectionStart = 0;
            this.BSBInput.Size = new System.Drawing.Size(149, 23);
            this.BSBInput.TabIndex = 16;
            this.BSBInput.UseSystemPasswordChar = false;
            // 
            // AccountNumberInput
            // 
            this.AccountNumberInput.Depth = 0;
            this.AccountNumberInput.Hint = "";
            this.AccountNumberInput.Location = new System.Drawing.Point(157, 227);
            this.AccountNumberInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.AccountNumberInput.Name = "AccountNumberInput";
            this.AccountNumberInput.PasswordChar = '\0';
            this.AccountNumberInput.SelectedText = "";
            this.AccountNumberInput.SelectionLength = 0;
            this.AccountNumberInput.SelectionStart = 0;
            this.AccountNumberInput.Size = new System.Drawing.Size(149, 23);
            this.AccountNumberInput.TabIndex = 17;
            this.AccountNumberInput.UseSystemPasswordChar = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.10204F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.89796F));
            this.tableLayoutPanel2.Controls.Add(this.materialLabel8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel9, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel10, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.DescriptionInput, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.BillToAddressInput, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.InvoiceDatePicker, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(331, 81);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(392, 263);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(3, 65);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(111, 19);
            this.materialLabel9.TabIndex = 14;
            this.materialLabel9.Text = "Bill To Address";
            this.materialLabel9.Click += new System.EventHandler(this.materialLabel9_Click);
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(3, 130);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(86, 19);
            this.materialLabel10.TabIndex = 15;
            this.materialLabel10.Text = "Description";
            // 
            // DescriptionInput
            // 
            this.DescriptionInput.Location = new System.Drawing.Point(120, 133);
            this.DescriptionInput.Multiline = true;
            this.DescriptionInput.Name = "DescriptionInput";
            this.DescriptionInput.Size = new System.Drawing.Size(268, 127);
            this.DescriptionInput.TabIndex = 16;
            // 
            // BillToAddressInput
            // 
            this.BillToAddressInput.Depth = 0;
            this.BillToAddressInput.Hint = "";
            this.BillToAddressInput.Location = new System.Drawing.Point(120, 68);
            this.BillToAddressInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.BillToAddressInput.Name = "BillToAddressInput";
            this.BillToAddressInput.PasswordChar = '\0';
            this.BillToAddressInput.SelectedText = "";
            this.BillToAddressInput.SelectionLength = 0;
            this.BillToAddressInput.SelectionStart = 0;
            this.BillToAddressInput.Size = new System.Drawing.Size(268, 23);
            this.BillToAddressInput.TabIndex = 17;
            this.BillToAddressInput.UseSystemPasswordChar = false;
            // 
            // InvoiceDatePicker
            // 
            this.InvoiceDatePicker.Location = new System.Drawing.Point(120, 3);
            this.InvoiceDatePicker.Name = "InvoiceDatePicker";
            this.InvoiceDatePicker.Size = new System.Drawing.Size(268, 20);
            this.InvoiceDatePicker.TabIndex = 18;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(3, 0);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(83, 19);
            this.materialLabel11.TabIndex = 16;
            this.materialLabel11.Text = "SUBTOTAL";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.materialLabel11, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.SubTotalDisplay, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.materialLabel12, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.materialLabel13, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(523, 635);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 85);
            this.tableLayoutPanel3.TabIndex = 17;
            // 
            // SubTotalDisplay
            // 
            this.SubTotalDisplay.AutoSize = true;
            this.SubTotalDisplay.Depth = 0;
            this.SubTotalDisplay.Font = new System.Drawing.Font("Roboto", 11F);
            this.SubTotalDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SubTotalDisplay.Location = new System.Drawing.Point(103, 0);
            this.SubTotalDisplay.MouseState = MaterialSkin.MouseState.HOVER;
            this.SubTotalDisplay.Name = "SubTotalDisplay";
            this.SubTotalDisplay.Size = new System.Drawing.Size(0, 19);
            this.SubTotalDisplay.TabIndex = 17;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(3, 28);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(37, 19);
            this.materialLabel12.TabIndex = 18;
            this.materialLabel12.Text = "GST";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(3, 56);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(55, 19);
            this.materialLabel13.TabIndex = 19;
            this.materialLabel13.Text = "TOTAL";
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(16, 366);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(39, 35);
            this.materialRaisedButton2.TabIndex = 18;
            this.materialRaisedButton2.Text = "+";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(59, 373);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(119, 19);
            this.materialLabel14.TabIndex = 19;
            this.materialLabel14.Text = "Add Invoice Line";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 770);
            this.Controls.Add(this.materialLabel14);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.InvoiceLinesDisplay);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Invoicer - The Open Source Invoice Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private MaterialSkin.Controls.MaterialLabel companyNameLbl;
        private MaterialSkin.Controls.MaterialSingleLineTextField companyNameInput;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        public System.Windows.Forms.ListBox InvoiceLinesDisplay;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField BillFromAddressInput;
        private MaterialSkin.Controls.MaterialSingleLineTextField PhoneNumberInput;
        private MaterialSkin.Controls.MaterialSingleLineTextField ABNInput;
        private MaterialSkin.Controls.MaterialSingleLineTextField BankNameInput;
        private MaterialSkin.Controls.MaterialSingleLineTextField PayeeNameInput;
        private MaterialSkin.Controls.MaterialSingleLineTextField BSBInput;
        private MaterialSkin.Controls.MaterialSingleLineTextField AccountNumberInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private System.Windows.Forms.TextBox DescriptionInput;
        private MaterialSkin.Controls.MaterialSingleLineTextField BillToAddressInput;
        private System.Windows.Forms.DateTimePicker InvoiceDatePicker;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialLabel SubTotalDisplay;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
    }
}

