namespace MasterSignal
{
    partial class frmPayment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grpWidthdraw = new System.Windows.Forms.GroupBox();
            this.lblERate = new System.Windows.Forms.Label();
            this.txtErate = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lnkClear = new System.Windows.Forms.LinkLabel();
            this.dgDisbursement = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNetamount = new System.Windows.Forms.TextBox();
            this.txtCaptialinterest = new System.Windows.Forms.TextBox();
            this.lblCrossamount = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lnkCalculate = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmbAccounts = new System.Windows.Forms.ComboBox();
            this.daTimeInvoice = new System.Windows.Forms.DateTimePicker();
            this.rdoWithdraw = new System.Windows.Forms.RadioButton();
            this.rdoHistory = new System.Windows.Forms.RadioButton();
            this.grpHistory = new System.Windows.Forms.GroupBox();
            this.btndelete = new System.Windows.Forms.LinkLabel();
            this.cboInvoiceType = new System.Windows.Forms.ComboBox();
            this.lblInvoiceType = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.rdoInvoiceItem = new System.Windows.Forms.RadioButton();
            this.lblMainTotal = new System.Windows.Forms.Label();
            this.radInvoice = new System.Windows.Forms.RadioButton();
            this.dgItem = new System.Windows.Forms.DataGridView();
            this.dgInvoice = new System.Windows.Forms.DataGridView();
            this.grpWidthdraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisbursement)).BeginInit();
            this.grpHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Payments";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label5.Location = new System.Drawing.Point(30, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label7.Location = new System.Drawing.Point(30, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Account Name";
            // 
            // grpWidthdraw
            // 
            this.grpWidthdraw.Controls.Add(this.lblERate);
            this.grpWidthdraw.Controls.Add(this.txtErate);
            this.grpWidthdraw.Controls.Add(this.btnAdd);
            this.grpWidthdraw.Controls.Add(this.lnkClear);
            this.grpWidthdraw.Controls.Add(this.dgDisbursement);
            this.grpWidthdraw.Controls.Add(this.label3);
            this.grpWidthdraw.Controls.Add(this.txtNetamount);
            this.grpWidthdraw.Controls.Add(this.txtCaptialinterest);
            this.grpWidthdraw.Controls.Add(this.lblCrossamount);
            this.grpWidthdraw.Controls.Add(this.cmbType);
            this.grpWidthdraw.Controls.Add(this.lblType);
            this.grpWidthdraw.Controls.Add(this.lnkCalculate);
            this.grpWidthdraw.Controls.Add(this.label2);
            this.grpWidthdraw.Controls.Add(this.txtAmount);
            this.grpWidthdraw.Controls.Add(this.cmbAccounts);
            this.grpWidthdraw.Controls.Add(this.daTimeInvoice);
            this.grpWidthdraw.Controls.Add(this.label5);
            this.grpWidthdraw.Controls.Add(this.label7);
            this.grpWidthdraw.Location = new System.Drawing.Point(70, 55);
            this.grpWidthdraw.Name = "grpWidthdraw";
            this.grpWidthdraw.Size = new System.Drawing.Size(625, 704);
            this.grpWidthdraw.TabIndex = 16;
            this.grpWidthdraw.TabStop = false;
            // 
            // lblERate
            // 
            this.lblERate.AutoSize = true;
            this.lblERate.Location = new System.Drawing.Point(416, 36);
            this.lblERate.Name = "lblERate";
            this.lblERate.Size = new System.Drawing.Size(104, 17);
            this.lblERate.TabIndex = 19;
            this.lblERate.Text = "Exchange Rate";
            // 
            // txtErate
            // 
            this.txtErate.Location = new System.Drawing.Point(521, 33);
            this.txtErate.Name = "txtErate";
            this.txtErate.Size = new System.Drawing.Size(47, 22);
            this.txtErate.TabIndex = 20;
            this.txtErate.Text = "100.00";
            this.txtErate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(387, 647);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(182, 34);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Widthdraw Money";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lnkClear
            // 
            this.lnkClear.AutoSize = true;
            this.lnkClear.Location = new System.Drawing.Point(509, 283);
            this.lnkClear.Name = "lnkClear";
            this.lnkClear.Size = new System.Drawing.Size(41, 17);
            this.lnkClear.TabIndex = 11;
            this.lnkClear.TabStop = true;
            this.lnkClear.Text = "Clear";
            this.lnkClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkClear_LinkClicked);
            // 
            // dgDisbursement
            // 
            this.dgDisbursement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDisbursement.Location = new System.Drawing.Point(31, 323);
            this.dgDisbursement.Name = "dgDisbursement";
            this.dgDisbursement.RowHeadersWidth = 51;
            this.dgDisbursement.Size = new System.Drawing.Size(543, 292);
            this.dgDisbursement.TabIndex = 17;
            this.dgDisbursement.Text = "dataGridView1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(306, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Net Amount";
            // 
            // txtNetamount
            // 
            this.txtNetamount.Location = new System.Drawing.Point(402, 164);
            this.txtNetamount.Name = "txtNetamount";
            this.txtNetamount.ReadOnly = true;
            this.txtNetamount.Size = new System.Drawing.Size(75, 22);
            this.txtNetamount.TabIndex = 9;
            this.txtNetamount.Text = "0.00";
            this.txtNetamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCaptialinterest
            // 
            this.txtCaptialinterest.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtCaptialinterest.Location = new System.Drawing.Point(192, 165);
            this.txtCaptialinterest.Name = "txtCaptialinterest";
            this.txtCaptialinterest.Size = new System.Drawing.Size(100, 27);
            this.txtCaptialinterest.TabIndex = 8;
            this.txtCaptialinterest.Text = "0.00";
            this.txtCaptialinterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCrossamount
            // 
            this.lblCrossamount.AutoSize = true;
            this.lblCrossamount.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblCrossamount.Location = new System.Drawing.Point(30, 164);
            this.lblCrossamount.Name = "lblCrossamount";
            this.lblCrossamount.Size = new System.Drawing.Size(126, 23);
            this.lblCrossamount.TabIndex = 7;
            this.lblCrossamount.Text = "Capital Interest";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(192, 207);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(203, 31);
            this.cmbType.TabIndex = 6;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.CmbType_SelectedIndexChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblType.Location = new System.Drawing.Point(30, 207);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(123, 23);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Withdraw Type";
            // 
            // lnkCalculate
            // 
            this.lnkCalculate.AutoSize = true;
            this.lnkCalculate.Location = new System.Drawing.Point(419, 283);
            this.lnkCalculate.Name = "lnkCalculate";
            this.lnkCalculate.Size = new System.Drawing.Size(66, 17);
            this.lnkCalculate.TabIndex = 4;
            this.lnkCalculate.TabStop = true;
            this.lnkCalculate.Text = "Calculate";
            this.lnkCalculate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkCalculate_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.label2.Location = new System.Drawing.Point(30, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gross Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtAmount.Location = new System.Drawing.Point(192, 124);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 27);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.Text = "0.00";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbAccounts
            // 
            this.cmbAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccounts.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.cmbAccounts.FormattingEnabled = true;
            this.cmbAccounts.Location = new System.Drawing.Point(192, 33);
            this.cmbAccounts.Name = "cmbAccounts";
            this.cmbAccounts.Size = new System.Drawing.Size(203, 31);
            this.cmbAccounts.TabIndex = 2;
            this.cmbAccounts.SelectedIndexChanged += new System.EventHandler(this.CmbAccounts_SelectedIndexChanged);
            // 
            // daTimeInvoice
            // 
            this.daTimeInvoice.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.daTimeInvoice.Location = new System.Drawing.Point(192, 79);
            this.daTimeInvoice.Name = "daTimeInvoice";
            this.daTimeInvoice.Size = new System.Drawing.Size(203, 30);
            this.daTimeInvoice.TabIndex = 1;
            // 
            // rdoWithdraw
            // 
            this.rdoWithdraw.AutoSize = true;
            this.rdoWithdraw.Checked = true;
            this.rdoWithdraw.Location = new System.Drawing.Point(495, 22);
            this.rdoWithdraw.Name = "rdoWithdraw";
            this.rdoWithdraw.Size = new System.Drawing.Size(87, 21);
            this.rdoWithdraw.TabIndex = 19;
            this.rdoWithdraw.TabStop = true;
            this.rdoWithdraw.Text = "Withdraw";
            this.rdoWithdraw.UseVisualStyleBackColor = true;
            this.rdoWithdraw.CheckedChanged += new System.EventHandler(this.RdoWithdraw_CheckedChanged);
            // 
            // rdoHistory
            // 
            this.rdoHistory.AutoSize = true;
            this.rdoHistory.Location = new System.Drawing.Point(592, 22);
            this.rdoHistory.Name = "rdoHistory";
            this.rdoHistory.Size = new System.Drawing.Size(73, 21);
            this.rdoHistory.TabIndex = 20;
            this.rdoHistory.Text = "History";
            this.rdoHistory.UseVisualStyleBackColor = true;
            this.rdoHistory.CheckedChanged += new System.EventHandler(this.RdoHistory_CheckedChanged);
            // 
            // grpHistory
            // 
            this.grpHistory.Controls.Add(this.btndelete);
            this.grpHistory.Controls.Add(this.cboInvoiceType);
            this.grpHistory.Controls.Add(this.lblInvoiceType);
            this.grpHistory.Controls.Add(this.lblSubTotal);
            this.grpHistory.Controls.Add(this.rdoInvoiceItem);
            this.grpHistory.Controls.Add(this.lblMainTotal);
            this.grpHistory.Controls.Add(this.radInvoice);
            this.grpHistory.Controls.Add(this.dgItem);
            this.grpHistory.Controls.Add(this.dgInvoice);
            this.grpHistory.Location = new System.Drawing.Point(23, 49);
            this.grpHistory.Name = "grpHistory";
            this.grpHistory.Size = new System.Drawing.Size(703, 717);
            this.grpHistory.TabIndex = 22;
            this.grpHistory.TabStop = false;
            this.grpHistory.Visible = false;
            // 
            // btndelete
            // 
            this.btndelete.AutoSize = true;
            this.btndelete.Location = new System.Drawing.Point(25, 351);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(49, 17);
            this.btndelete.TabIndex = 23;
            this.btndelete.TabStop = true;
            this.btndelete.Text = "Delete";
            this.btndelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btndelete_LinkClicked);
            // 
            // cboInvoiceType
            // 
            this.cboInvoiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInvoiceType.FormattingEnabled = true;
            this.cboInvoiceType.Location = new System.Drawing.Point(509, 35);
            this.cboInvoiceType.Name = "cboInvoiceType";
            this.cboInvoiceType.Size = new System.Drawing.Size(163, 24);
            this.cboInvoiceType.TabIndex = 22;
            this.cboInvoiceType.SelectedIndexChanged += new System.EventHandler(this.cboInvoiceType_SelectedIndexChanged);
            // 
            // lblInvoiceType
            // 
            this.lblInvoiceType.AutoSize = true;
            this.lblInvoiceType.Location = new System.Drawing.Point(414, 38);
            this.lblInvoiceType.Name = "lblInvoiceType";
            this.lblInvoiceType.Size = new System.Drawing.Size(88, 17);
            this.lblInvoiceType.TabIndex = 21;
            this.lblInvoiceType.Text = "Invoice Type";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblSubTotal.Location = new System.Drawing.Point(353, 675);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(73, 30);
            this.lblSubTotal.TabIndex = 20;
            this.lblSubTotal.Text = "label2";
            // 
            // rdoInvoiceItem
            // 
            this.rdoInvoiceItem.AutoSize = true;
            this.rdoInvoiceItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.rdoInvoiceItem.Location = new System.Drawing.Point(143, 32);
            this.rdoInvoiceItem.Name = "rdoInvoiceItem";
            this.rdoInvoiceItem.Size = new System.Drawing.Size(146, 27);
            this.rdoInvoiceItem.TabIndex = 19;
            this.rdoInvoiceItem.Text = "Payment Items";
            this.rdoInvoiceItem.UseVisualStyleBackColor = true;
            this.rdoInvoiceItem.CheckedChanged += new System.EventHandler(this.RdoInvoiceItem_CheckedChanged);
            // 
            // lblMainTotal
            // 
            this.lblMainTotal.AutoSize = true;
            this.lblMainTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblMainTotal.Location = new System.Drawing.Point(488, 351);
            this.lblMainTotal.Name = "lblMainTotal";
            this.lblMainTotal.Size = new System.Drawing.Size(73, 30);
            this.lblMainTotal.TabIndex = 18;
            this.lblMainTotal.Text = "label2";
            // 
            // radInvoice
            // 
            this.radInvoice.AutoSize = true;
            this.radInvoice.Checked = true;
            this.radInvoice.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.radInvoice.Location = new System.Drawing.Point(54, 32);
            this.radInvoice.Name = "radInvoice";
            this.radInvoice.Size = new System.Drawing.Size(86, 27);
            this.radInvoice.TabIndex = 18;
            this.radInvoice.TabStop = true;
            this.radInvoice.Text = "Invoice";
            this.radInvoice.UseVisualStyleBackColor = true;
            // 
            // dgItem
            // 
            this.dgItem.AllowUserToAddRows = false;
            this.dgItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItem.Location = new System.Drawing.Point(27, 397);
            this.dgItem.Name = "dgItem";
            this.dgItem.ReadOnly = true;
            this.dgItem.RowHeadersVisible = false;
            this.dgItem.RowHeadersWidth = 51;
            this.dgItem.Size = new System.Drawing.Size(645, 272);
            this.dgItem.TabIndex = 17;
            this.dgItem.Text = "dataGridView2";
            // 
            // dgInvoice
            // 
            this.dgInvoice.AllowUserToAddRows = false;
            this.dgInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInvoice.Location = new System.Drawing.Point(27, 75);
            this.dgInvoice.Name = "dgInvoice";
            this.dgInvoice.ReadOnly = true;
            this.dgInvoice.RowHeadersVisible = false;
            this.dgInvoice.RowHeadersWidth = 51;
            this.dgInvoice.Size = new System.Drawing.Size(645, 268);
            this.dgInvoice.TabIndex = 17;
            this.dgInvoice.Text = "dataGridView1";
            this.dgInvoice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DgInvoice_MouseClick);
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 779);
            this.Controls.Add(this.rdoHistory);
            this.Controls.Add(this.rdoWithdraw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpHistory);
            this.Controls.Add(this.grpWidthdraw);
            this.Name = "frmPayment";
            this.Text = "frmPayment";
            this.Load += new System.EventHandler(this.FrmPayment_Load);
            this.grpWidthdraw.ResumeLayout(false);
            this.grpWidthdraw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisbursement)).EndInit();
            this.grpHistory.ResumeLayout(false);
            this.grpHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpWidthdraw;
        private System.Windows.Forms.DateTimePicker daTimeInvoice;
        private System.Windows.Forms.ComboBox cmbAccounts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DataGridView dgDisbursement;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.LinkLabel lnkCalculate;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblERate;
        private System.Windows.Forms.TextBox txtErate;
        private System.Windows.Forms.TextBox txtNetamount;
        private System.Windows.Forms.TextBox txtCaptialinterest;
        private System.Windows.Forms.Label lblCrossamount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnkClear;
        private System.Windows.Forms.RadioButton rdoWithdraw;
        private System.Windows.Forms.RadioButton rdoHistory;
        private System.Windows.Forms.GroupBox grpHistory;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.RadioButton rdoInvoiceItem;
        private System.Windows.Forms.Label lblMainTotal;
        private System.Windows.Forms.RadioButton radInvoice;
        private System.Windows.Forms.DataGridView dgItem;
        private System.Windows.Forms.DataGridView dgInvoice;
        private System.Windows.Forms.ComboBox cboInvoiceType;
        private System.Windows.Forms.Label lblInvoiceType;
        private System.Windows.Forms.LinkLabel btndelete;
    }
}