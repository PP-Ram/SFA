namespace MasterSignal
{
    partial class frmChart
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
            this.dgTradeSummery = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comMonth = new System.Windows.Forms.ComboBox();
            this.lblLoss = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblProfit = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblOpen = new System.Windows.Forms.Label();
            this.grpTradeDetails = new System.Windows.Forms.GroupBox();
            this.txtDate = new System.Windows.Forms.Label();
            this.cmoTradeSize = new System.Windows.Forms.ComboBox();
            this.txtTradesize = new System.Windows.Forms.Label();
            this.lnkClear = new System.Windows.Forms.LinkLabel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.cmoNewMonth = new System.Windows.Forms.ComboBox();
            this.cmoDate = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoBuy = new System.Windows.Forms.RadioButton();
            this.rdoSell = new System.Windows.Forms.RadioButton();
            this.cmoNewAccount = new System.Windows.Forms.ComboBox();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.txtPair = new System.Windows.Forms.TextBox();
            this.txtTradeDetail = new System.Windows.Forms.TextBox();
            this.btnAddnew = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.btnShow = new System.Windows.Forms.LinkLabel();
            this.dgTradeByCurrency = new System.Windows.Forms.DataGridView();
            this.dgTradeByDate = new System.Windows.Forms.DataGridView();
            this.dgAccounts = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblMinloss = new System.Windows.Forms.Label();
            this.lblMaxloss = new System.Windows.Forms.Label();
            this.lblMaxwin = new System.Windows.Forms.Label();
            this.lblMinwin = new System.Windows.Forms.Label();
            this.btnSaveDB = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.LinkLabel();
            this.rdoSummery = new System.Windows.Forms.RadioButton();
            this.rdoCount = new System.Windows.Forms.RadioButton();
            this.rdoAmount = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgTradeSummery)).BeginInit();
            this.grpTradeDetails.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTradeByCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTradeByDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccounts)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgTradeSummery
            // 
            this.dgTradeSummery.AllowUserToAddRows = false;
            this.dgTradeSummery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTradeSummery.Location = new System.Drawing.Point(6, 46);
            this.dgTradeSummery.Name = "dgTradeSummery";
            this.dgTradeSummery.RowHeadersWidth = 51;
            this.dgTradeSummery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTradeSummery.Size = new System.Drawing.Size(271, 545);
            this.dgTradeSummery.TabIndex = 0;
            this.dgTradeSummery.Text = "dataGridView1";
            this.dgTradeSummery.SelectionChanged += new System.EventHandler(this.DgTradeSummery_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(527, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Trade Report and Chart";
            // 
            // comMonth
            // 
            this.comMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comMonth.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.comMonth.FormattingEnabled = true;
            this.comMonth.Location = new System.Drawing.Point(25, 17);
            this.comMonth.Name = "comMonth";
            this.comMonth.Size = new System.Drawing.Size(104, 28);
            this.comMonth.TabIndex = 16;
            this.comMonth.SelectedIndexChanged += new System.EventHandler(this.ComMonth_SelectedIndexChanged);
            // 
            // lblLoss
            // 
            this.lblLoss.AutoSize = true;
            this.lblLoss.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblLoss.ForeColor = System.Drawing.Color.Red;
            this.lblLoss.Location = new System.Drawing.Point(297, 41);
            this.lblLoss.Name = "lblLoss";
            this.lblLoss.Size = new System.Drawing.Size(37, 20);
            this.lblLoss.TabIndex = 17;
            this.lblLoss.Text = "Loss";
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblWin.ForeColor = System.Drawing.Color.Green;
            this.lblWin.Location = new System.Drawing.Point(173, 41);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(36, 20);
            this.lblWin.TabIndex = 17;
            this.lblWin.Text = "Win";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F);
            this.lblTotal.Location = new System.Drawing.Point(25, 41);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(112, 23);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "Total Trades: ";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Khaki;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Historic", 9F);
            this.btnAdd.Location = new System.Drawing.Point(173, 352);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 41);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Save Update";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAddTrade_click);
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F);
            this.lblProfit.Location = new System.Drawing.Point(297, 14);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(90, 23);
            this.lblProfit.TabIndex = 17;
            this.lblProfit.Text = "Profit/Loss";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Segoe UI Historic", 9F);
            this.lblClose.Location = new System.Drawing.Point(173, 16);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(45, 20);
            this.lblClose.TabIndex = 17;
            this.lblClose.Text = "Close";
            // 
            // lblOpen
            // 
            this.lblOpen.AutoSize = true;
            this.lblOpen.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F);
            this.lblOpen.Location = new System.Drawing.Point(25, 14);
            this.lblOpen.Name = "lblOpen";
            this.lblOpen.Size = new System.Drawing.Size(52, 23);
            this.lblOpen.TabIndex = 17;
            this.lblOpen.Text = "Open";
            // 
            // grpTradeDetails
            // 
            this.grpTradeDetails.Controls.Add(this.txtDate);
            this.grpTradeDetails.Controls.Add(this.cmoTradeSize);
            this.grpTradeDetails.Controls.Add(this.txtTradesize);
            this.grpTradeDetails.Controls.Add(this.lnkClear);
            this.grpTradeDetails.Controls.Add(this.lblHeading);
            this.grpTradeDetails.Controls.Add(this.cmoNewMonth);
            this.grpTradeDetails.Controls.Add(this.cmoDate);
            this.grpTradeDetails.Controls.Add(this.label6);
            this.grpTradeDetails.Controls.Add(this.label5);
            this.grpTradeDetails.Controls.Add(this.label4);
            this.grpTradeDetails.Controls.Add(this.label3);
            this.grpTradeDetails.Controls.Add(this.label2);
            this.grpTradeDetails.Controls.Add(this.rdoBuy);
            this.grpTradeDetails.Controls.Add(this.rdoSell);
            this.grpTradeDetails.Controls.Add(this.cmoNewAccount);
            this.grpTradeDetails.Controls.Add(this.txtUnits);
            this.grpTradeDetails.Controls.Add(this.txtPair);
            this.grpTradeDetails.Controls.Add(this.txtTradeDetail);
            this.grpTradeDetails.Controls.Add(this.btnAdd);
            this.grpTradeDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grpTradeDetails.Location = new System.Drawing.Point(678, 108);
            this.grpTradeDetails.Name = "grpTradeDetails";
            this.grpTradeDetails.Size = new System.Drawing.Size(309, 412);
            this.grpTradeDetails.TabIndex = 17;
            this.grpTradeDetails.TabStop = false;
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.Font = new System.Drawing.Font("Segoe UI Historic", 9F);
            this.txtDate.Location = new System.Drawing.Point(11, 178);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(41, 20);
            this.txtDate.TabIndex = 24;
            this.txtDate.Text = "Date";
            // 
            // cmoTradeSize
            // 
            this.cmoTradeSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmoTradeSize.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.cmoTradeSize.FormattingEnabled = true;
            this.cmoTradeSize.Items.AddRange(new object[] {
            "0.5",
            "1.0",
            "5.0",
            "10.0"});
            this.cmoTradeSize.Location = new System.Drawing.Point(88, 219);
            this.cmoTradeSize.Name = "cmoTradeSize";
            this.cmoTradeSize.Size = new System.Drawing.Size(198, 28);
            this.cmoTradeSize.TabIndex = 23;
            // 
            // txtTradesize
            // 
            this.txtTradesize.AutoSize = true;
            this.txtTradesize.Font = new System.Drawing.Font("Segoe UI Historic", 9F);
            this.txtTradesize.Location = new System.Drawing.Point(8, 219);
            this.txtTradesize.Name = "txtTradesize";
            this.txtTradesize.Size = new System.Drawing.Size(74, 20);
            this.txtTradesize.TabIndex = 22;
            this.txtTradesize.Text = "TradeSize";
            // 
            // lnkClear
            // 
            this.lnkClear.AutoSize = true;
            this.lnkClear.Location = new System.Drawing.Point(100, 358);
            this.lnkClear.Name = "lnkClear";
            this.lnkClear.Size = new System.Drawing.Size(51, 23);
            this.lnkClear.TabIndex = 21;
            this.lnkClear.TabStop = true;
            this.lnkClear.Text = "Close";
            this.lnkClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkClear_LinkClicked);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblHeading.Location = new System.Drawing.Point(100, 25);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(141, 23);
            this.lblHeading.TabIndex = 3;
            this.lblHeading.Text = "Add New Trade";
            // 
            // cmoNewMonth
            // 
            this.cmoNewMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmoNewMonth.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.cmoNewMonth.FormattingEnabled = true;
            this.cmoNewMonth.Location = new System.Drawing.Point(191, 175);
            this.cmoNewMonth.Name = "cmoNewMonth";
            this.cmoNewMonth.Size = new System.Drawing.Size(95, 28);
            this.cmoNewMonth.TabIndex = 16;
            // 
            // cmoDate
            // 
            this.cmoDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmoDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.cmoDate.FormattingEnabled = true;
            this.cmoDate.Location = new System.Drawing.Point(88, 173);
            this.cmoDate.Name = "cmoDate";
            this.cmoDate.Size = new System.Drawing.Size(63, 28);
            this.cmoDate.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Historic", 9F);
            this.label6.Location = new System.Drawing.Point(11, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Historic", 9F);
            this.label5.Location = new System.Drawing.Point(162, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Units";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Historic", 9F);
            this.label4.Location = new System.Drawing.Point(11, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Pair";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 9F);
            this.label3.Location = new System.Drawing.Point(11, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 9F);
            this.label2.Location = new System.Drawing.Point(11, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Action";
            // 
            // rdoBuy
            // 
            this.rdoBuy.AutoSize = true;
            this.rdoBuy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdoBuy.Location = new System.Drawing.Point(166, 138);
            this.rdoBuy.Name = "rdoBuy";
            this.rdoBuy.Size = new System.Drawing.Size(54, 24);
            this.rdoBuy.TabIndex = 19;
            this.rdoBuy.TabStop = true;
            this.rdoBuy.Text = "Buy";
            this.rdoBuy.UseVisualStyleBackColor = true;
            // 
            // rdoSell
            // 
            this.rdoSell.AutoSize = true;
            this.rdoSell.Checked = true;
            this.rdoSell.Font = new System.Drawing.Font("Segoe UI Historic", 9F);
            this.rdoSell.Location = new System.Drawing.Point(88, 138);
            this.rdoSell.Name = "rdoSell";
            this.rdoSell.Size = new System.Drawing.Size(54, 24);
            this.rdoSell.TabIndex = 18;
            this.rdoSell.TabStop = true;
            this.rdoSell.Text = "Sell";
            this.rdoSell.UseVisualStyleBackColor = true;
            // 
            // cmoNewAccount
            // 
            this.cmoNewAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmoNewAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.cmoNewAccount.FormattingEnabled = true;
            this.cmoNewAccount.Location = new System.Drawing.Point(88, 61);
            this.cmoNewAccount.Name = "cmoNewAccount";
            this.cmoNewAccount.Size = new System.Drawing.Size(198, 28);
            this.cmoNewAccount.TabIndex = 16;
            // 
            // txtUnits
            // 
            this.txtUnits.Location = new System.Drawing.Point(210, 100);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(76, 29);
            this.txtUnits.TabIndex = 17;
            this.txtUnits.Text = "0.00";
            this.txtUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPair
            // 
            this.txtPair.AutoCompleteCustomSource.AddRange(new string[] {
            "EURGBP",
            "EURAUD",
            "EURNZD",
            "EURCAD",
            "EURUSD",
            "EURJPY",
            "GBPAUD",
            "GBPNZD",
            "GBPCAD",
            "GBPUSD",
            "GBPJPY",
            "AUDUSD",
            "AUDJPY",
            "AUDCAD",
            "NZDUSD",
            "NZDJPY",
            "NZDCAD",
            "USDCAD",
            "CADJPY",
            "USDCHF",
            "SOYBN",
            "USDJPY",
            "",
            "AUDNZD",
            "",
            "EURCHF",
            "",
            "GBPCHF",
            "",
            "AUDCHF",
            "",
            "NZDCHF",
            "",
            "CADCHF",
            "",
            "CHFJPY",
            "",
            "EURMXN",
            "",
            "GBPMXN",
            "",
            "SPX",
            "",
            "OIL",
            "",
            "SILVER",
            "GOLD"});
            this.txtPair.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPair.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPair.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPair.Location = new System.Drawing.Point(88, 100);
            this.txtPair.MaxLength = 6;
            this.txtPair.Name = "txtPair";
            this.txtPair.Size = new System.Drawing.Size(71, 27);
            this.txtPair.TabIndex = 16;
            // 
            // txtTradeDetail
            // 
            this.txtTradeDetail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTradeDetail.Location = new System.Drawing.Point(88, 251);
            this.txtTradeDetail.Multiline = true;
            this.txtTradeDetail.Name = "txtTradeDetail";
            this.txtTradeDetail.Size = new System.Drawing.Size(198, 77);
            this.txtTradeDetail.TabIndex = 0;
            // 
            // btnAddnew
            // 
            this.btnAddnew.AutoSize = true;
            this.btnAddnew.Location = new System.Drawing.Point(175, 19);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(67, 20);
            this.btnAddnew.TabIndex = 21;
            this.btnAddnew.TabStop = true;
            this.btnAddnew.Text = "Add New";
            this.btnAddnew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BtnAddnew_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkAll);
            this.groupBox2.Controls.Add(this.btnShow);
            this.groupBox2.Controls.Add(this.dgTradeByCurrency);
            this.groupBox2.Controls.Add(this.dgTradeByDate);
            this.groupBox2.Controls.Add(this.dgAccounts);
            this.groupBox2.Controls.Add(this.comMonth);
            this.groupBox2.Location = new System.Drawing.Point(12, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 616);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(298, 25);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(48, 24);
            this.chkAll.TabIndex = 23;
            this.chkAll.Text = "All";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.ChkAll_CheckedChanged);
            // 
            // btnShow
            // 
            this.btnShow.AutoSize = true;
            this.btnShow.Location = new System.Drawing.Point(154, 19);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(43, 20);
            this.btnShow.TabIndex = 22;
            this.btnShow.TabStop = true;
            this.btnShow.Text = "Show";
            this.btnShow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BtnShow_LinkClicked);
            // 
            // dgTradeByCurrency
            // 
            this.dgTradeByCurrency.AllowUserToAddRows = false;
            this.dgTradeByCurrency.AllowUserToResizeRows = false;
            this.dgTradeByCurrency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTradeByCurrency.EnableHeadersVisualStyles = false;
            this.dgTradeByCurrency.Location = new System.Drawing.Point(182, 215);
            this.dgTradeByCurrency.Name = "dgTradeByCurrency";
            this.dgTradeByCurrency.RowHeadersWidth = 51;
            this.dgTradeByCurrency.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgTradeByCurrency.Size = new System.Drawing.Size(156, 378);
            this.dgTradeByCurrency.TabIndex = 0;
            this.dgTradeByCurrency.Text = "dataGridView2";
            this.dgTradeByCurrency.Click += new System.EventHandler(this.DgTradeByCurrency_Click);
            // 
            // dgTradeByDate
            // 
            this.dgTradeByDate.AllowUserToAddRows = false;
            this.dgTradeByDate.AllowUserToResizeRows = false;
            this.dgTradeByDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTradeByDate.Location = new System.Drawing.Point(6, 215);
            this.dgTradeByDate.Name = "dgTradeByDate";
            this.dgTradeByDate.RowHeadersWidth = 51;
            this.dgTradeByDate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgTradeByDate.Size = new System.Drawing.Size(170, 378);
            this.dgTradeByDate.TabIndex = 0;
            this.dgTradeByDate.Text = "dataGridView1";
            this.dgTradeByDate.Click += new System.EventHandler(this.DgTradeByDate_Click);
            // 
            // dgAccounts
            // 
            this.dgAccounts.AllowUserToAddRows = false;
            this.dgAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccounts.Location = new System.Drawing.Point(6, 48);
            this.dgAccounts.Name = "dgAccounts";
            this.dgAccounts.RowHeadersWidth = 51;
            this.dgAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAccounts.Size = new System.Drawing.Size(332, 161);
            this.dgAccounts.TabIndex = 0;
            this.dgAccounts.Text = "dataGridView1";
            this.dgAccounts.SelectionChanged += new System.EventHandler(this.DgAccounts_SelectionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox3.Controls.Add(this.lblMinloss);
            this.groupBox3.Controls.Add(this.lblMaxloss);
            this.groupBox3.Controls.Add(this.lblMaxwin);
            this.groupBox3.Controls.Add(this.lblMinwin);
            this.groupBox3.Controls.Add(this.btnSaveDB);
            this.groupBox3.Controls.Add(this.lblUserName);
            this.groupBox3.Controls.Add(this.lblEnd);
            this.groupBox3.Controls.Add(this.lblStart);
            this.groupBox3.Controls.Add(this.lblResult);
            this.groupBox3.Controls.Add(this.lblLoss);
            this.groupBox3.Controls.Add(this.lblOpen);
            this.groupBox3.Controls.Add(this.lblWin);
            this.groupBox3.Controls.Add(this.lblClose);
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Controls.Add(this.lblProfit);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(12, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1346, 65);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // lblMinloss
            // 
            this.lblMinloss.AutoSize = true;
            this.lblMinloss.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblMinloss.ForeColor = System.Drawing.Color.Red;
            this.lblMinloss.Location = new System.Drawing.Point(1051, 39);
            this.lblMinloss.Name = "lblMinloss";
            this.lblMinloss.Size = new System.Drawing.Size(71, 23);
            this.lblMinloss.TabIndex = 23;
            this.lblMinloss.Text = "MinLoss";
            // 
            // lblMaxloss
            // 
            this.lblMaxloss.AutoSize = true;
            this.lblMaxloss.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblMaxloss.ForeColor = System.Drawing.Color.Red;
            this.lblMaxloss.Location = new System.Drawing.Point(1051, 14);
            this.lblMaxloss.Name = "lblMaxloss";
            this.lblMaxloss.Size = new System.Drawing.Size(74, 23);
            this.lblMaxloss.TabIndex = 22;
            this.lblMaxloss.Text = "MaxLoss";
            // 
            // lblMaxwin
            // 
            this.lblMaxwin.AutoSize = true;
            this.lblMaxwin.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblMaxwin.ForeColor = System.Drawing.Color.Green;
            this.lblMaxwin.Location = new System.Drawing.Point(903, 14);
            this.lblMaxwin.Name = "lblMaxwin";
            this.lblMaxwin.Size = new System.Drawing.Size(72, 23);
            this.lblMaxwin.TabIndex = 21;
            this.lblMaxwin.Text = "MaxWin";
            // 
            // lblMinwin
            // 
            this.lblMinwin.AutoSize = true;
            this.lblMinwin.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblMinwin.ForeColor = System.Drawing.Color.Green;
            this.lblMinwin.Location = new System.Drawing.Point(903, 39);
            this.lblMinwin.Name = "lblMinwin";
            this.lblMinwin.Size = new System.Drawing.Size(69, 23);
            this.lblMinwin.TabIndex = 20;
            this.lblMinwin.Text = "MinWin";
            // 
            // btnSaveDB
            // 
            this.btnSaveDB.Location = new System.Drawing.Point(1254, 24);
            this.btnSaveDB.Name = "btnSaveDB";
            this.btnSaveDB.Size = new System.Drawing.Size(86, 28);
            this.btnSaveDB.TabIndex = 18;
            this.btnSaveDB.Text = "Save to DB";
            this.btnSaveDB.UseVisualStyleBackColor = true;
            this.btnSaveDB.Click += new System.EventHandler(this.BtnSaveDB_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F);
            this.lblUserName.Location = new System.Drawing.Point(493, 39);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(112, 23);
            this.lblUserName.TabIndex = 17;
            this.lblUserName.Text = "Total Trades: ";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F);
            this.lblEnd.Location = new System.Drawing.Point(778, 14);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(39, 23);
            this.lblEnd.TabIndex = 17;
            this.lblEnd.Text = "End";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F);
            this.lblStart.Location = new System.Drawing.Point(644, 14);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(46, 23);
            this.lblStart.TabIndex = 17;
            this.lblStart.Text = "Start";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI Historic", 9.75F);
            this.lblResult.Location = new System.Drawing.Point(493, 14);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(56, 23);
            this.lblResult.TabIndex = 17;
            this.lblResult.Text = "Result";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAddnew);
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Controls.Add(this.dgTradeSummery);
            this.groupBox4.Location = new System.Drawing.Point(362, 101);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(288, 615);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(237, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 20);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.TabStop = true;
            this.btnDelete.Text = "Delete";
            this.btnDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BtnDelete_LinkClicked);
            // 
            // rdoSummery
            // 
            this.rdoSummery.AutoSize = true;
            this.rdoSummery.Location = new System.Drawing.Point(1105, 15);
            this.rdoSummery.Name = "rdoSummery";
            this.rdoSummery.Size = new System.Drawing.Size(91, 24);
            this.rdoSummery.TabIndex = 21;
            this.rdoSummery.TabStop = true;
            this.rdoSummery.Text = "Summary";
            this.rdoSummery.UseVisualStyleBackColor = true;
            this.rdoSummery.CheckedChanged += new System.EventHandler(this.rdo_ReportOption);
            // 
            // rdoCount
            // 
            this.rdoCount.AutoSize = true;
            this.rdoCount.Location = new System.Drawing.Point(1259, 15);
            this.rdoCount.Name = "rdoCount";
            this.rdoCount.Size = new System.Drawing.Size(105, 24);
            this.rdoCount.TabIndex = 22;
            this.rdoCount.TabStop = true;
            this.rdoCount.Text = "TradeCount";
            this.rdoCount.UseVisualStyleBackColor = true;
            this.rdoCount.CheckedChanged += new System.EventHandler(this.rdo_ReportOption);
            // 
            // rdoAmount
            // 
            this.rdoAmount.AutoSize = true;
            this.rdoAmount.Location = new System.Drawing.Point(1186, 15);
            this.rdoAmount.Name = "rdoAmount";
            this.rdoAmount.Size = new System.Drawing.Size(65, 24);
            this.rdoAmount.TabIndex = 23;
            this.rdoAmount.TabStop = true;
            this.rdoAmount.Text = "Profit";
            this.rdoAmount.UseVisualStyleBackColor = true;
            this.rdoAmount.CheckedChanged += new System.EventHandler(this.rdo_ReportOption);
            // 
            // frmChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1611, 749);
            this.Controls.Add(this.rdoCount);
            this.Controls.Add(this.rdoSummery);
            this.Controls.Add(this.rdoAmount);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpTradeDetails);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.Name = "frmChart";
            this.Text = "frmChart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTradeSummery)).EndInit();
            this.grpTradeDetails.ResumeLayout(false);
            this.grpTradeDetails.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTradeByCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTradeByDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccounts)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgTradeSummery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comMonth;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblOpen;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpTradeDetails;
        private System.Windows.Forms.TextBox txtTradeDetail;
        private System.Windows.Forms.Label lblLoss;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgTradeByCurrency;
        private System.Windows.Forms.DataGridView dgTradeByDate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgAccounts;
        private System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.TextBox txtPair;
        private System.Windows.Forms.RadioButton rdoBuy;
        private System.Windows.Forms.RadioButton rdoSell;
        private System.Windows.Forms.ComboBox cmoNewAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmoDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmoNewMonth;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.LinkLabel btnAddnew;
        private System.Windows.Forms.LinkLabel btnDelete;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.LinkLabel btnShow;
        private System.Windows.Forms.LinkLabel lnkClear;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnSaveDB;
        private System.Windows.Forms.Label lblMinloss;
        private System.Windows.Forms.Label lblMaxloss;
        private System.Windows.Forms.Label lblMaxwin;
        private System.Windows.Forms.Label lblMinwin;
        private System.Windows.Forms.RadioButton rdoSummery;
        private System.Windows.Forms.RadioButton rdoCount;
        private System.Windows.Forms.RadioButton rdoAmount;
        private System.Windows.Forms.Label txtDate;
        private System.Windows.Forms.ComboBox cmoTradeSize;
        private System.Windows.Forms.Label txtTradesize;
    }
}