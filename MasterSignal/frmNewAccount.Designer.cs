
namespace MasterSignal
{
    partial class frmNewAccount
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.cmbPlatform = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.grpAccountmanagement = new System.Windows.Forms.GroupBox();
            this.txtTradepattern = new System.Windows.Forms.RichTextBox();
            this.grpTradingoption = new System.Windows.Forms.GroupBox();
            this.ckWeekendTrade = new System.Windows.Forms.CheckBox();
            this.ckStoporders = new System.Windows.Forms.CheckBox();
            this.ckNewsTrade = new System.Windows.Forms.CheckBox();
            this.lblTradepattern = new System.Windows.Forms.Label();
            this.dtpAccclosedate = new System.Windows.Forms.DateTimePicker();
            this.dtpAccopendate = new System.Windows.Forms.DateTimePicker();
            this.lblTradeenddate = new System.Windows.Forms.Label();
            this.lblTradestartdate = new System.Windows.Forms.Label();
            this.lblActuallotsize = new System.Windows.Forms.Label();
            this.lblLotsizerange = new System.Windows.Forms.Label();
            this.txtActuallotsize = new System.Windows.Forms.TextBox();
            this.txtLotsizerange = new System.Windows.Forms.TextBox();
            this.lblClosingopenpositions = new System.Windows.Forms.Label();
            this.lblMinpositionduration = new System.Windows.Forms.Label();
            this.lblMintradingdays = new System.Windows.Forms.Label();
            this.lblTradingdays = new System.Windows.Forms.Label();
            this.txtClosingopenpositions = new System.Windows.Forms.TextBox();
            this.txtMinpositionduration = new System.Windows.Forms.TextBox();
            this.txtMintradingdays = new System.Windows.Forms.TextBox();
            this.txtTotaltradingdays = new System.Windows.Forms.TextBox();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.lblWebsite = new System.Windows.Forms.Label();
            this.dtpTradeenddate = new System.Windows.Forms.DateTimePicker();
            this.dtpTradestartdate = new System.Windows.Forms.DateTimePicker();
            this.lblTradePair = new System.Windows.Forms.Label();
            this.txtCurrencyPair = new System.Windows.Forms.TextBox();
            this.cmbTrader = new System.Windows.Forms.ComboBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.txtChallengeFees = new System.Windows.Forms.TextBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblChallengefee = new System.Windows.Forms.Label();
            this.lblTradecondition = new System.Windows.Forms.Label();
            this.grpProfitTarget = new System.Windows.Forms.GroupBox();
            this.txtTamount = new System.Windows.Forms.TextBox();
            this.txtTpercent = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblper2 = new System.Windows.Forms.Label();
            this.grpMaxTotalLoss = new System.Windows.Forms.GroupBox();
            this.lblper1 = new System.Windows.Forms.Label();
            this.lblAmt = new System.Windows.Forms.Label();
            this.txtTLpercent = new System.Windows.Forms.TextBox();
            this.txtTLamount = new System.Windows.Forms.TextBox();
            this.grpMaxdailyLoss = new System.Windows.Forms.GroupBox();
            this.lblPer = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.Label();
            this.txtDLamount = new System.Windows.Forms.TextBox();
            this.txtDLpercent = new System.Windows.Forms.TextBox();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.lblCapital = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtProfitshare = new System.Windows.Forms.TextBox();
            this.lblFundingfirm = new System.Windows.Forms.Label();
            this.cmbFundingfirm = new System.Windows.Forms.ComboBox();
            this.lblPlatform = new System.Windows.Forms.Label();
            this.lblProfitShare = new System.Windows.Forms.Label();
            this.lblAccenddate = new System.Windows.Forms.Label();
            this.lblAccstartdate = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAccountNum = new System.Windows.Forms.Label();
            this.grpValidation = new System.Windows.Forms.GroupBox();
            this.rdoP3 = new System.Windows.Forms.RadioButton();
            this.rdoP2 = new System.Windows.Forms.RadioButton();
            this.rdoP1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoGBP = new System.Windows.Forms.RadioButton();
            this.rdoUSD = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoFund = new System.Windows.Forms.RadioButton();
            this.rdoPersonal = new System.Windows.Forms.RadioButton();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgAccounts = new System.Windows.Forms.DataGridView();
            this.lnkBtnAdd = new System.Windows.Forms.LinkLabel();
            this.grpAccountmanagement.SuspendLayout();
            this.grpTradingoption.SuspendLayout();
            this.grpProfitTarget.SuspendLayout();
            this.grpMaxTotalLoss.SuspendLayout();
            this.grpMaxdailyLoss.SuspendLayout();
            this.grpValidation.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNo.Location = new System.Drawing.Point(234, 94);
            this.txtAccountNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(207, 29);
            this.txtAccountNo.TabIndex = 20;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(234, 268);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(207, 29);
            this.txtPassword.TabIndex = 50;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(234, 211);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(207, 29);
            this.txtUserName.TabIndex = 40;
            // 
            // cmbPlatform
            // 
            this.cmbPlatform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlatform.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPlatform.FormattingEnabled = true;
            this.cmbPlatform.ItemHeight = 24;
            this.cmbPlatform.Location = new System.Drawing.Point(1260, 472);
            this.cmbPlatform.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPlatform.Name = "cmbPlatform";
            this.cmbPlatform.Size = new System.Drawing.Size(207, 32);
            this.cmbPlatform.TabIndex = 310;
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.ItemHeight = 24;
            this.cmbStatus.Items.AddRange(new object[] {
            "Active",
            "Failed",
            "Completed"});
            this.cmbStatus.Location = new System.Drawing.Point(1261, 530);
            this.cmbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(207, 32);
            this.cmbStatus.TabIndex = 320;
            // 
            // grpAccountmanagement
            // 
            this.grpAccountmanagement.Controls.Add(this.txtTradepattern);
            this.grpAccountmanagement.Controls.Add(this.grpTradingoption);
            this.grpAccountmanagement.Controls.Add(this.lblTradepattern);
            this.grpAccountmanagement.Controls.Add(this.dtpAccclosedate);
            this.grpAccountmanagement.Controls.Add(this.dtpAccopendate);
            this.grpAccountmanagement.Controls.Add(this.lblTradeenddate);
            this.grpAccountmanagement.Controls.Add(this.lblTradestartdate);
            this.grpAccountmanagement.Controls.Add(this.lblActuallotsize);
            this.grpAccountmanagement.Controls.Add(this.lblLotsizerange);
            this.grpAccountmanagement.Controls.Add(this.txtActuallotsize);
            this.grpAccountmanagement.Controls.Add(this.txtLotsizerange);
            this.grpAccountmanagement.Controls.Add(this.lblClosingopenpositions);
            this.grpAccountmanagement.Controls.Add(this.lblMinpositionduration);
            this.grpAccountmanagement.Controls.Add(this.lblMintradingdays);
            this.grpAccountmanagement.Controls.Add(this.lblTradingdays);
            this.grpAccountmanagement.Controls.Add(this.txtClosingopenpositions);
            this.grpAccountmanagement.Controls.Add(this.txtMinpositionduration);
            this.grpAccountmanagement.Controls.Add(this.txtMintradingdays);
            this.grpAccountmanagement.Controls.Add(this.txtTotaltradingdays);
            this.grpAccountmanagement.Controls.Add(this.txtWebsite);
            this.grpAccountmanagement.Controls.Add(this.lblWebsite);
            this.grpAccountmanagement.Controls.Add(this.dtpTradeenddate);
            this.grpAccountmanagement.Controls.Add(this.dtpTradestartdate);
            this.grpAccountmanagement.Controls.Add(this.lblTradePair);
            this.grpAccountmanagement.Controls.Add(this.txtCurrencyPair);
            this.grpAccountmanagement.Controls.Add(this.cmbTrader);
            this.grpAccountmanagement.Controls.Add(this.txtDetails);
            this.grpAccountmanagement.Controls.Add(this.txtChallengeFees);
            this.grpAccountmanagement.Controls.Add(this.lblDetails);
            this.grpAccountmanagement.Controls.Add(this.lblChallengefee);
            this.grpAccountmanagement.Controls.Add(this.lblTradecondition);
            this.grpAccountmanagement.Controls.Add(this.grpProfitTarget);
            this.grpAccountmanagement.Controls.Add(this.grpMaxTotalLoss);
            this.grpAccountmanagement.Controls.Add(this.grpMaxdailyLoss);
            this.grpAccountmanagement.Controls.Add(this.txtCapital);
            this.grpAccountmanagement.Controls.Add(this.lblCapital);
            this.grpAccountmanagement.Controls.Add(this.lblStatus);
            this.grpAccountmanagement.Controls.Add(this.txtProfitshare);
            this.grpAccountmanagement.Controls.Add(this.lblFundingfirm);
            this.grpAccountmanagement.Controls.Add(this.cmbFundingfirm);
            this.grpAccountmanagement.Controls.Add(this.lblPlatform);
            this.grpAccountmanagement.Controls.Add(this.lblProfitShare);
            this.grpAccountmanagement.Controls.Add(this.lblAccenddate);
            this.grpAccountmanagement.Controls.Add(this.lblAccstartdate);
            this.grpAccountmanagement.Controls.Add(this.lblUserName);
            this.grpAccountmanagement.Controls.Add(this.lblPassword);
            this.grpAccountmanagement.Controls.Add(this.lblAccountNum);
            this.grpAccountmanagement.Controls.Add(this.cmbStatus);
            this.grpAccountmanagement.Controls.Add(this.cmbPlatform);
            this.grpAccountmanagement.Controls.Add(this.txtUserName);
            this.grpAccountmanagement.Controls.Add(this.txtPassword);
            this.grpAccountmanagement.Controls.Add(this.txtAccountNo);
            this.grpAccountmanagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAccountmanagement.Location = new System.Drawing.Point(365, 119);
            this.grpAccountmanagement.Margin = new System.Windows.Forms.Padding(4);
            this.grpAccountmanagement.Name = "grpAccountmanagement";
            this.grpAccountmanagement.Padding = new System.Windows.Forms.Padding(4);
            this.grpAccountmanagement.Size = new System.Drawing.Size(1546, 685);
            this.grpAccountmanagement.TabIndex = 9;
            this.grpAccountmanagement.TabStop = false;
            this.grpAccountmanagement.Enter += new System.EventHandler(this.grpAccountmanagement_Enter);
            // 
            // txtTradepattern
            // 
            this.txtTradepattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTradepattern.Location = new System.Drawing.Point(670, 558);
            this.txtTradepattern.Name = "txtTradepattern";
            this.txtTradepattern.Size = new System.Drawing.Size(264, 90);
            this.txtTradepattern.TabIndex = 210;
            this.txtTradepattern.Text = "";
            // 
            // grpTradingoption
            // 
            this.grpTradingoption.Controls.Add(this.ckWeekendTrade);
            this.grpTradingoption.Controls.Add(this.ckStoporders);
            this.grpTradingoption.Controls.Add(this.ckNewsTrade);
            this.grpTradingoption.Location = new System.Drawing.Point(1039, 130);
            this.grpTradingoption.Name = "grpTradingoption";
            this.grpTradingoption.Size = new System.Drawing.Size(469, 91);
            this.grpTradingoption.TabIndex = 131;
            this.grpTradingoption.TabStop = false;
            this.grpTradingoption.Text = "Trading condition";
            // 
            // ckWeekendTrade
            // 
            this.ckWeekendTrade.AutoSize = true;
            this.ckWeekendTrade.Location = new System.Drawing.Point(21, 44);
            this.ckWeekendTrade.Name = "ckWeekendTrade";
            this.ckWeekendTrade.Size = new System.Drawing.Size(143, 24);
            this.ckWeekendTrade.TabIndex = 240;
            this.ckWeekendTrade.Text = "Weekend trade";
            this.ckWeekendTrade.UseVisualStyleBackColor = true;
            // 
            // ckStoporders
            // 
            this.ckStoporders.AutoSize = true;
            this.ckStoporders.Location = new System.Drawing.Point(187, 44);
            this.ckStoporders.Name = "ckStoporders";
            this.ckStoporders.Size = new System.Drawing.Size(113, 24);
            this.ckStoporders.TabIndex = 250;
            this.ckStoporders.Text = "Stoporders";
            this.ckStoporders.UseVisualStyleBackColor = true;
            // 
            // ckNewsTrade
            // 
            this.ckNewsTrade.AutoSize = true;
            this.ckNewsTrade.Location = new System.Drawing.Point(314, 43);
            this.ckNewsTrade.Name = "ckNewsTrade";
            this.ckNewsTrade.Size = new System.Drawing.Size(116, 24);
            this.ckNewsTrade.TabIndex = 260;
            this.ckNewsTrade.Text = "News trade";
            this.ckNewsTrade.UseVisualStyleBackColor = true;
            // 
            // lblTradepattern
            // 
            this.lblTradepattern.AutoSize = true;
            this.lblTradepattern.Location = new System.Drawing.Point(537, 588);
            this.lblTradepattern.Name = "lblTradepattern";
            this.lblTradepattern.Size = new System.Drawing.Size(109, 20);
            this.lblTradepattern.TabIndex = 130;
            this.lblTradepattern.Text = "Trade pattern";
            // 
            // dtpAccclosedate
            // 
            this.dtpAccclosedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAccclosedate.Location = new System.Drawing.Point(234, 444);
            this.dtpAccclosedate.Name = "dtpAccclosedate";
            this.dtpAccclosedate.Size = new System.Drawing.Size(208, 29);
            this.dtpAccclosedate.TabIndex = 80;
            // 
            // dtpAccopendate
            // 
            this.dtpAccopendate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAccopendate.Location = new System.Drawing.Point(234, 379);
            this.dtpAccopendate.Name = "dtpAccopendate";
            this.dtpAccopendate.Size = new System.Drawing.Size(207, 29);
            this.dtpAccopendate.TabIndex = 70;
            this.dtpAccopendate.ValueChanged += new System.EventHandler(this.dtpAccopendate_ValueChanged);
            // 
            // lblTradeenddate
            // 
            this.lblTradeenddate.AutoSize = true;
            this.lblTradeenddate.Location = new System.Drawing.Point(58, 453);
            this.lblTradeenddate.Name = "lblTradeenddate";
            this.lblTradeenddate.Size = new System.Drawing.Size(120, 20);
            this.lblTradeenddate.TabIndex = 126;
            this.lblTradeenddate.Text = "Acc close date";
            // 
            // lblTradestartdate
            // 
            this.lblTradestartdate.AutoSize = true;
            this.lblTradestartdate.Location = new System.Drawing.Point(58, 386);
            this.lblTradestartdate.Name = "lblTradestartdate";
            this.lblTradestartdate.Size = new System.Drawing.Size(116, 20);
            this.lblTradestartdate.TabIndex = 125;
            this.lblTradestartdate.Text = "Acc open date";
            // 
            // lblActuallotsize
            // 
            this.lblActuallotsize.AutoSize = true;
            this.lblActuallotsize.Location = new System.Drawing.Point(1048, 353);
            this.lblActuallotsize.Name = "lblActuallotsize";
            this.lblActuallotsize.Size = new System.Drawing.Size(120, 20);
            this.lblActuallotsize.TabIndex = 123;
            this.lblActuallotsize.Text = " Actual lot size";
            // 
            // lblLotsizerange
            // 
            this.lblLotsizerange.AutoSize = true;
            this.lblLotsizerange.Location = new System.Drawing.Point(1052, 411);
            this.lblLotsizerange.Name = "lblLotsizerange";
            this.lblLotsizerange.Size = new System.Drawing.Size(116, 20);
            this.lblLotsizerange.TabIndex = 122;
            this.lblLotsizerange.Text = "Lot size range";
            // 
            // txtActuallotsize
            // 
            this.txtActuallotsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActuallotsize.Location = new System.Drawing.Point(1261, 411);
            this.txtActuallotsize.Name = "txtActuallotsize";
            this.txtActuallotsize.Size = new System.Drawing.Size(205, 29);
            this.txtActuallotsize.TabIndex = 300;
            // 
            // txtLotsizerange
            // 
            this.txtLotsizerange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLotsizerange.Location = new System.Drawing.Point(1260, 353);
            this.txtLotsizerange.Name = "txtLotsizerange";
            this.txtLotsizerange.Size = new System.Drawing.Size(207, 29);
            this.txtLotsizerange.TabIndex = 290;
            // 
            // lblClosingopenpositions
            // 
            this.lblClosingopenpositions.AutoSize = true;
            this.lblClosingopenpositions.Location = new System.Drawing.Point(1047, 296);
            this.lblClosingopenpositions.Name = "lblClosingopenpositions";
            this.lblClosingopenpositions.Size = new System.Drawing.Size(178, 20);
            this.lblClosingopenpositions.TabIndex = 119;
            this.lblClosingopenpositions.Text = "Closing open positions";
            // 
            // lblMinpositionduration
            // 
            this.lblMinpositionduration.AutoSize = true;
            this.lblMinpositionduration.Location = new System.Drawing.Point(1047, 237);
            this.lblMinpositionduration.Name = "lblMinpositionduration";
            this.lblMinpositionduration.Size = new System.Drawing.Size(164, 20);
            this.lblMinpositionduration.TabIndex = 118;
            this.lblMinpositionduration.Text = "Min position duration";
            // 
            // lblMintradingdays
            // 
            this.lblMintradingdays.AutoSize = true;
            this.lblMintradingdays.Location = new System.Drawing.Point(1047, 91);
            this.lblMintradingdays.Name = "lblMintradingdays";
            this.lblMintradingdays.Size = new System.Drawing.Size(132, 20);
            this.lblMintradingdays.TabIndex = 110;
            this.lblMintradingdays.Text = "Min trading days";
            // 
            // lblTradingdays
            // 
            this.lblTradingdays.AutoSize = true;
            this.lblTradingdays.Location = new System.Drawing.Point(1044, 39);
            this.lblTradingdays.Name = "lblTradingdays";
            this.lblTradingdays.Size = new System.Drawing.Size(142, 20);
            this.lblTradingdays.TabIndex = 109;
            this.lblTradingdays.Text = "Total trading days";
            // 
            // txtClosingopenpositions
            // 
            this.txtClosingopenpositions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClosingopenpositions.Location = new System.Drawing.Point(1260, 296);
            this.txtClosingopenpositions.Name = "txtClosingopenpositions";
            this.txtClosingopenpositions.Size = new System.Drawing.Size(208, 29);
            this.txtClosingopenpositions.TabIndex = 280;
            // 
            // txtMinpositionduration
            // 
            this.txtMinpositionduration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinpositionduration.Location = new System.Drawing.Point(1260, 237);
            this.txtMinpositionduration.Name = "txtMinpositionduration";
            this.txtMinpositionduration.Size = new System.Drawing.Size(206, 29);
            this.txtMinpositionduration.TabIndex = 270;
            // 
            // txtMintradingdays
            // 
            this.txtMintradingdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMintradingdays.Location = new System.Drawing.Point(1261, 91);
            this.txtMintradingdays.Name = "txtMintradingdays";
            this.txtMintradingdays.Size = new System.Drawing.Size(45, 29);
            this.txtMintradingdays.TabIndex = 230;
            // 
            // txtTotaltradingdays
            // 
            this.txtTotaltradingdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotaltradingdays.Location = new System.Drawing.Point(1260, 36);
            this.txtTotaltradingdays.Name = "txtTotaltradingdays";
            this.txtTotaltradingdays.Size = new System.Drawing.Size(46, 29);
            this.txtTotaltradingdays.TabIndex = 220;
            // 
            // txtWebsite
            // 
            this.txtWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWebsite.Location = new System.Drawing.Point(1205, 597);
            this.txtWebsite.Margin = new System.Windows.Forms.Padding(4);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(319, 29);
            this.txtWebsite.TabIndex = 330;
            // 
            // lblWebsite
            // 
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.Location = new System.Drawing.Point(1048, 603);
            this.lblWebsite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(70, 20);
            this.lblWebsite.TabIndex = 55;
            this.lblWebsite.Text = "Website";
            // 
            // dtpTradeenddate
            // 
            this.dtpTradeenddate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTradeenddate.Location = new System.Drawing.Point(234, 579);
            this.dtpTradeenddate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTradeenddate.Name = "dtpTradeenddate";
            this.dtpTradeenddate.Size = new System.Drawing.Size(207, 29);
            this.dtpTradeenddate.TabIndex = 100;
            // 
            // dtpTradestartdate
            // 
            this.dtpTradestartdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTradestartdate.Location = new System.Drawing.Point(234, 514);
            this.dtpTradestartdate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTradestartdate.Name = "dtpTradestartdate";
            this.dtpTradestartdate.Size = new System.Drawing.Size(207, 29);
            this.dtpTradestartdate.TabIndex = 90;
            // 
            // lblTradePair
            // 
            this.lblTradePair.AutoSize = true;
            this.lblTradePair.Location = new System.Drawing.Point(537, 491);
            this.lblTradePair.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTradePair.Name = "lblTradePair";
            this.lblTradePair.Size = new System.Drawing.Size(110, 20);
            this.lblTradePair.TabIndex = 51;
            this.lblTradePair.Text = "Currency pair";
            // 
            // txtCurrencyPair
            // 
            this.txtCurrencyPair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrencyPair.Location = new System.Drawing.Point(671, 485);
            this.txtCurrencyPair.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurrencyPair.Multiline = true;
            this.txtCurrencyPair.Name = "txtCurrencyPair";
            this.txtCurrencyPair.Size = new System.Drawing.Size(263, 38);
            this.txtCurrencyPair.TabIndex = 200;
            // 
            // cmbTrader
            // 
            this.cmbTrader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTrader.FormattingEnabled = true;
            this.cmbTrader.Location = new System.Drawing.Point(669, 274);
            this.cmbTrader.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTrader.Name = "cmbTrader";
            this.cmbTrader.Size = new System.Drawing.Size(264, 32);
            this.cmbTrader.TabIndex = 170;
            // 
            // txtDetails
            // 
            this.txtDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.Location = new System.Drawing.Point(671, 386);
            this.txtDetails.Margin = new System.Windows.Forms.Padding(4);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(263, 73);
            this.txtDetails.TabIndex = 190;
            // 
            // txtChallengeFees
            // 
            this.txtChallengeFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChallengeFees.Location = new System.Drawing.Point(671, 328);
            this.txtChallengeFees.Margin = new System.Windows.Forms.Padding(4);
            this.txtChallengeFees.MaxLength = 10;
            this.txtChallengeFees.Name = "txtChallengeFees";
            this.txtChallengeFees.Size = new System.Drawing.Size(112, 29);
            this.txtChallengeFees.TabIndex = 180;
            this.txtChallengeFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtChallengeFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFees_KeyPress);
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(537, 392);
            this.lblDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(62, 20);
            this.lblDetails.TabIndex = 45;
            this.lblDetails.Text = "Details";
            // 
            // lblChallengefee
            // 
            this.lblChallengefee.AutoSize = true;
            this.lblChallengefee.Location = new System.Drawing.Point(537, 334);
            this.lblChallengefee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChallengefee.Name = "lblChallengefee";
            this.lblChallengefee.Size = new System.Drawing.Size(115, 20);
            this.lblChallengefee.TabIndex = 43;
            this.lblChallengefee.Text = "Challlenge fee";
            // 
            // lblTradecondition
            // 
            this.lblTradecondition.AutoSize = true;
            this.lblTradecondition.Location = new System.Drawing.Point(537, 277);
            this.lblTradecondition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTradecondition.Name = "lblTradecondition";
            this.lblTradecondition.Size = new System.Drawing.Size(58, 20);
            this.lblTradecondition.TabIndex = 42;
            this.lblTradecondition.Text = "Trader";
            // 
            // grpProfitTarget
            // 
            this.grpProfitTarget.Controls.Add(this.txtTamount);
            this.grpProfitTarget.Controls.Add(this.txtTpercent);
            this.grpProfitTarget.Controls.Add(this.lblAmount);
            this.grpProfitTarget.Controls.Add(this.lblper2);
            this.grpProfitTarget.Location = new System.Drawing.Point(517, 192);
            this.grpProfitTarget.Margin = new System.Windows.Forms.Padding(4);
            this.grpProfitTarget.Name = "grpProfitTarget";
            this.grpProfitTarget.Padding = new System.Windows.Forms.Padding(4);
            this.grpProfitTarget.Size = new System.Drawing.Size(475, 74);
            this.grpProfitTarget.TabIndex = 101;
            this.grpProfitTarget.TabStop = false;
            this.grpProfitTarget.Text = "Profit target";
            // 
            // txtTamount
            // 
            this.txtTamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTamount.Location = new System.Drawing.Point(153, 22);
            this.txtTamount.Margin = new System.Windows.Forms.Padding(4);
            this.txtTamount.Name = "txtTamount";
            this.txtTamount.Size = new System.Drawing.Size(95, 29);
            this.txtTamount.TabIndex = 150;
            this.txtTamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTamount_KeyPress);
            // 
            // txtTpercent
            // 
            this.txtTpercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTpercent.Location = new System.Drawing.Point(309, 23);
            this.txtTpercent.Margin = new System.Windows.Forms.Padding(4);
            this.txtTpercent.MaxLength = 2;
            this.txtTpercent.Name = "txtTpercent";
            this.txtTpercent.Size = new System.Drawing.Size(40, 29);
            this.txtTpercent.TabIndex = 160;
            this.txtTpercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTpercent_KeyPress);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(78, 28);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(66, 20);
            this.lblAmount.TabIndex = 34;
            this.lblAmount.Text = "Amount";
            // 
            // lblper2
            // 
            this.lblper2.AutoSize = true;
            this.lblper2.Location = new System.Drawing.Point(276, 28);
            this.lblper2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblper2.Name = "lblper2";
            this.lblper2.Size = new System.Drawing.Size(24, 20);
            this.lblper2.TabIndex = 39;
            this.lblper2.Text = "%";
            // 
            // grpMaxTotalLoss
            // 
            this.grpMaxTotalLoss.Controls.Add(this.lblper1);
            this.grpMaxTotalLoss.Controls.Add(this.lblAmt);
            this.grpMaxTotalLoss.Controls.Add(this.txtTLpercent);
            this.grpMaxTotalLoss.Controls.Add(this.txtTLamount);
            this.grpMaxTotalLoss.Location = new System.Drawing.Point(517, 113);
            this.grpMaxTotalLoss.Margin = new System.Windows.Forms.Padding(4);
            this.grpMaxTotalLoss.Name = "grpMaxTotalLoss";
            this.grpMaxTotalLoss.Padding = new System.Windows.Forms.Padding(4);
            this.grpMaxTotalLoss.Size = new System.Drawing.Size(475, 71);
            this.grpMaxTotalLoss.TabIndex = 100;
            this.grpMaxTotalLoss.TabStop = false;
            this.grpMaxTotalLoss.Text = "Max total  loss";
            // 
            // lblper1
            // 
            this.lblper1.AutoSize = true;
            this.lblper1.Location = new System.Drawing.Point(276, 28);
            this.lblper1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblper1.Name = "lblper1";
            this.lblper1.Size = new System.Drawing.Size(24, 20);
            this.lblper1.TabIndex = 3;
            this.lblper1.Text = "%";
            // 
            // lblAmt
            // 
            this.lblAmt.AutoSize = true;
            this.lblAmt.Location = new System.Drawing.Point(78, 28);
            this.lblAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmt.Name = "lblAmt";
            this.lblAmt.Size = new System.Drawing.Size(66, 20);
            this.lblAmt.TabIndex = 2;
            this.lblAmt.Text = "Amount";
            // 
            // txtTLpercent
            // 
            this.txtTLpercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTLpercent.Location = new System.Drawing.Point(309, 21);
            this.txtTLpercent.Margin = new System.Windows.Forms.Padding(4);
            this.txtTLpercent.MaxLength = 2;
            this.txtTLpercent.Name = "txtTLpercent";
            this.txtTLpercent.Size = new System.Drawing.Size(40, 29);
            this.txtTLpercent.TabIndex = 140;
            this.txtTLpercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTLpercent_KeyPress);
            // 
            // txtTLamount
            // 
            this.txtTLamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTLamount.Location = new System.Drawing.Point(153, 21);
            this.txtTLamount.Margin = new System.Windows.Forms.Padding(4);
            this.txtTLamount.Name = "txtTLamount";
            this.txtTLamount.Size = new System.Drawing.Size(96, 29);
            this.txtTLamount.TabIndex = 130;
            this.txtTLamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTLamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTLamount_KeyPress);
            // 
            // grpMaxdailyLoss
            // 
            this.grpMaxdailyLoss.Controls.Add(this.lblPer);
            this.grpMaxdailyLoss.Controls.Add(this.txtAmount);
            this.grpMaxdailyLoss.Controls.Add(this.txtDLamount);
            this.grpMaxdailyLoss.Controls.Add(this.txtDLpercent);
            this.grpMaxdailyLoss.Location = new System.Drawing.Point(517, 33);
            this.grpMaxdailyLoss.Margin = new System.Windows.Forms.Padding(4);
            this.grpMaxdailyLoss.Name = "grpMaxdailyLoss";
            this.grpMaxdailyLoss.Padding = new System.Windows.Forms.Padding(4);
            this.grpMaxdailyLoss.Size = new System.Drawing.Size(475, 78);
            this.grpMaxdailyLoss.TabIndex = 45;
            this.grpMaxdailyLoss.TabStop = false;
            this.grpMaxdailyLoss.Text = "Max daily loss";
            // 
            // lblPer
            // 
            this.lblPer.AutoSize = true;
            this.lblPer.Location = new System.Drawing.Point(276, 32);
            this.lblPer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPer.Name = "lblPer";
            this.lblPer.Size = new System.Drawing.Size(24, 20);
            this.lblPer.TabIndex = 36;
            this.lblPer.Text = "%";
            // 
            // txtAmount
            // 
            this.txtAmount.AutoSize = true;
            this.txtAmount.Location = new System.Drawing.Point(78, 32);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(66, 20);
            this.txtAmount.TabIndex = 35;
            this.txtAmount.Text = "Amount";
            // 
            // txtDLamount
            // 
            this.txtDLamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDLamount.Location = new System.Drawing.Point(152, 25);
            this.txtDLamount.Margin = new System.Windows.Forms.Padding(4);
            this.txtDLamount.Name = "txtDLamount";
            this.txtDLamount.Size = new System.Drawing.Size(96, 29);
            this.txtDLamount.TabIndex = 110;
            this.txtDLamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDLamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDLamount_KeyPress);
            // 
            // txtDLpercent
            // 
            this.txtDLpercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDLpercent.Location = new System.Drawing.Point(309, 23);
            this.txtDLpercent.Margin = new System.Windows.Forms.Padding(4);
            this.txtDLpercent.MaxLength = 2;
            this.txtDLpercent.Name = "txtDLpercent";
            this.txtDLpercent.Size = new System.Drawing.Size(40, 29);
            this.txtDLpercent.TabIndex = 120;
            this.txtDLpercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDLpercent_KeyPress);
            // 
            // txtCapital
            // 
            this.txtCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapital.Location = new System.Drawing.Point(234, 155);
            this.txtCapital.Margin = new System.Windows.Forms.Padding(4);
            this.txtCapital.MaxLength = 10;
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(207, 29);
            this.txtCapital.TabIndex = 30;
            this.txtCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCapital.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCapital_KeyPress);
            // 
            // lblCapital
            // 
            this.lblCapital.AutoSize = true;
            this.lblCapital.Location = new System.Drawing.Point(62, 161);
            this.lblCapital.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapital.Name = "lblCapital";
            this.lblCapital.Size = new System.Drawing.Size(61, 20);
            this.lblCapital.TabIndex = 30;
            this.lblCapital.Text = "Capital";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(1056, 536);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(57, 20);
            this.lblStatus.TabIndex = 29;
            this.lblStatus.Text = "Status";
            // 
            // txtProfitshare
            // 
            this.txtProfitshare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfitshare.Location = new System.Drawing.Point(234, 322);
            this.txtProfitshare.Margin = new System.Windows.Forms.Padding(4);
            this.txtProfitshare.Name = "txtProfitshare";
            this.txtProfitshare.Size = new System.Drawing.Size(83, 29);
            this.txtProfitshare.TabIndex = 60;
            this.txtProfitshare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFundingfirm
            // 
            this.lblFundingfirm.AutoSize = true;
            this.lblFundingfirm.Location = new System.Drawing.Point(62, 39);
            this.lblFundingfirm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFundingfirm.Name = "lblFundingfirm";
            this.lblFundingfirm.Size = new System.Drawing.Size(102, 20);
            this.lblFundingfirm.TabIndex = 23;
            this.lblFundingfirm.Text = "Funding firm";
            // 
            // cmbFundingfirm
            // 
            this.cmbFundingfirm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFundingfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFundingfirm.FormattingEnabled = true;
            this.cmbFundingfirm.Items.AddRange(new object[] {
            "MT4"});
            this.cmbFundingfirm.Location = new System.Drawing.Point(234, 33);
            this.cmbFundingfirm.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFundingfirm.Name = "cmbFundingfirm";
            this.cmbFundingfirm.Size = new System.Drawing.Size(207, 32);
            this.cmbFundingfirm.TabIndex = 10;
            // 
            // lblPlatform
            // 
            this.lblPlatform.AutoSize = true;
            this.lblPlatform.Location = new System.Drawing.Point(1056, 478);
            this.lblPlatform.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlatform.Name = "lblPlatform";
            this.lblPlatform.Size = new System.Drawing.Size(72, 20);
            this.lblPlatform.TabIndex = 18;
            this.lblPlatform.Text = "Platform";
            // 
            // lblProfitShare
            // 
            this.lblProfitShare.AutoSize = true;
            this.lblProfitShare.Location = new System.Drawing.Point(58, 331);
            this.lblProfitShare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfitShare.Name = "lblProfitShare";
            this.lblProfitShare.Size = new System.Drawing.Size(116, 20);
            this.lblProfitShare.TabIndex = 17;
            this.lblProfitShare.Text = "Profit share %";
            // 
            // lblAccenddate
            // 
            this.lblAccenddate.AutoSize = true;
            this.lblAccenddate.Location = new System.Drawing.Point(57, 586);
            this.lblAccenddate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccenddate.Name = "lblAccenddate";
            this.lblAccenddate.Size = new System.Drawing.Size(121, 20);
            this.lblAccenddate.TabIndex = 16;
            this.lblAccenddate.Text = "Trade end date";
            // 
            // lblAccstartdate
            // 
            this.lblAccstartdate.AutoSize = true;
            this.lblAccstartdate.Location = new System.Drawing.Point(57, 521);
            this.lblAccstartdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccstartdate.Name = "lblAccstartdate";
            this.lblAccstartdate.Size = new System.Drawing.Size(128, 20);
            this.lblAccstartdate.TabIndex = 15;
            this.lblAccstartdate.Text = "Trade start date";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(58, 215);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(91, 20);
            this.lblUserName.TabIndex = 14;
            this.lblUserName.Text = "User name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(58, 274);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(83, 20);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Password";
            // 
            // lblAccountNum
            // 
            this.lblAccountNum.AutoSize = true;
            this.lblAccountNum.Location = new System.Drawing.Point(62, 97);
            this.lblAccountNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountNum.Name = "lblAccountNum";
            this.lblAccountNum.Size = new System.Drawing.Size(93, 20);
            this.lblAccountNum.TabIndex = 11;
            this.lblAccountNum.Text = "Account no";
            // 
            // grpValidation
            // 
            this.grpValidation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.grpValidation.Controls.Add(this.rdoP3);
            this.grpValidation.Controls.Add(this.rdoP2);
            this.grpValidation.Controls.Add(this.rdoP1);
            this.grpValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpValidation.Location = new System.Drawing.Point(884, 62);
            this.grpValidation.Margin = new System.Windows.Forms.Padding(4);
            this.grpValidation.Name = "grpValidation";
            this.grpValidation.Padding = new System.Windows.Forms.Padding(4);
            this.grpValidation.Size = new System.Drawing.Size(251, 50);
            this.grpValidation.TabIndex = 58;
            this.grpValidation.TabStop = false;
            // 
            // rdoP3
            // 
            this.rdoP3.AutoSize = true;
            this.rdoP3.Location = new System.Drawing.Point(172, 14);
            this.rdoP3.Margin = new System.Windows.Forms.Padding(4);
            this.rdoP3.Name = "rdoP3";
            this.rdoP3.Size = new System.Drawing.Size(50, 24);
            this.rdoP3.TabIndex = 9;
            this.rdoP3.Text = "P3";
            this.rdoP3.UseVisualStyleBackColor = true;
            // 
            // rdoP2
            // 
            this.rdoP2.AutoSize = true;
            this.rdoP2.Location = new System.Drawing.Point(103, 14);
            this.rdoP2.Margin = new System.Windows.Forms.Padding(4);
            this.rdoP2.Name = "rdoP2";
            this.rdoP2.Size = new System.Drawing.Size(50, 24);
            this.rdoP2.TabIndex = 8;
            this.rdoP2.Text = "P2";
            this.rdoP2.UseVisualStyleBackColor = true;
            // 
            // rdoP1
            // 
            this.rdoP1.AutoSize = true;
            this.rdoP1.Checked = true;
            this.rdoP1.Location = new System.Drawing.Point(27, 14);
            this.rdoP1.Margin = new System.Windows.Forms.Padding(4);
            this.rdoP1.Name = "rdoP1";
            this.rdoP1.Size = new System.Drawing.Size(50, 24);
            this.rdoP1.TabIndex = 6;
            this.rdoP1.TabStop = true;
            this.rdoP1.Text = "P1";
            this.rdoP1.UseVisualStyleBackColor = true;
            this.rdoP1.CheckedChanged += new System.EventHandler(this.rdoP1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.rdoGBP);
            this.groupBox2.Controls.Add(this.rdoUSD);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1308, 62);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(267, 50);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            // 
            // rdoGBP
            // 
            this.rdoGBP.AutoSize = true;
            this.rdoGBP.Location = new System.Drawing.Point(164, 14);
            this.rdoGBP.Margin = new System.Windows.Forms.Padding(4);
            this.rdoGBP.Name = "rdoGBP";
            this.rdoGBP.Size = new System.Drawing.Size(66, 24);
            this.rdoGBP.TabIndex = 18;
            this.rdoGBP.Text = "GBP";
            this.rdoGBP.UseVisualStyleBackColor = true;
            // 
            // rdoUSD
            // 
            this.rdoUSD.AutoSize = true;
            this.rdoUSD.Checked = true;
            this.rdoUSD.Location = new System.Drawing.Point(48, 14);
            this.rdoUSD.Margin = new System.Windows.Forms.Padding(4);
            this.rdoUSD.Name = "rdoUSD";
            this.rdoUSD.Size = new System.Drawing.Size(66, 24);
            this.rdoUSD.TabIndex = 14;
            this.rdoUSD.TabStop = true;
            this.rdoUSD.Text = "USD";
            this.rdoUSD.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.rdoFund);
            this.groupBox1.Controls.Add(this.rdoPersonal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(481, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(247, 50);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            // 
            // rdoFund
            // 
            this.rdoFund.AutoSize = true;
            this.rdoFund.Location = new System.Drawing.Point(133, 15);
            this.rdoFund.Margin = new System.Windows.Forms.Padding(4);
            this.rdoFund.Name = "rdoFund";
            this.rdoFund.Size = new System.Drawing.Size(67, 24);
            this.rdoFund.TabIndex = 2;
            this.rdoFund.Text = "Fund";
            this.rdoFund.UseVisualStyleBackColor = true;
            // 
            // rdoPersonal
            // 
            this.rdoPersonal.AutoSize = true;
            this.rdoPersonal.Checked = true;
            this.rdoPersonal.Location = new System.Drawing.Point(20, 15);
            this.rdoPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.rdoPersonal.Name = "rdoPersonal";
            this.rdoPersonal.Size = new System.Drawing.Size(96, 24);
            this.rdoPersonal.TabIndex = 1;
            this.rdoPersonal.TabStop = true;
            this.rdoPersonal.Text = "Personal";
            this.rdoPersonal.UseVisualStyleBackColor = true;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccount.Location = new System.Drawing.Point(683, 843);
            this.btnAddAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(185, 42);
            this.btnAddAccount.TabIndex = 30;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.UseVisualStyleBackColor = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(989, 843);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 36);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(811, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 29);
            this.label1.TabIndex = 102;
            this.label1.Text = "Add Forex Account";
            // 
            // dgAccounts
            // 
            this.dgAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccounts.Location = new System.Drawing.Point(18, 134);
            this.dgAccounts.Name = "dgAccounts";
            this.dgAccounts.RowHeadersWidth = 62;
            this.dgAccounts.RowTemplate.Height = 24;
            this.dgAccounts.Size = new System.Drawing.Size(316, 490);
            this.dgAccounts.TabIndex = 103;
            this.dgAccounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAccounts_CellContentClick);
            this.dgAccounts.SelectionChanged += new System.EventHandler(this.dgAccounts_SelectionChanged);
            // 
            // lnkBtnAdd
            // 
            this.lnkBtnAdd.AutoSize = true;
            this.lnkBtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkBtnAdd.Location = new System.Drawing.Point(266, 640);
            this.lnkBtnAdd.Name = "lnkBtnAdd";
            this.lnkBtnAdd.Size = new System.Drawing.Size(68, 20);
            this.lnkBtnAdd.TabIndex = 104;
            this.lnkBtnAdd.TabStop = true;
            this.lnkBtnAdd.Text = "Addnew";
            this.lnkBtnAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBtnAdd_LinkClicked);
            // 
            // frmNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1033);
            this.Controls.Add(this.lnkBtnAdd);
            this.Controls.Add(this.dgAccounts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpValidation);
            this.Controls.Add(this.grpAccountmanagement);
            this.Controls.Add(this.btnAddAccount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClear);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNewAccount";
            this.Text = "New Forex Account";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAccountmanagement.ResumeLayout(false);
            this.grpAccountmanagement.PerformLayout();
            this.grpTradingoption.ResumeLayout(false);
            this.grpTradingoption.PerformLayout();
            this.grpProfitTarget.ResumeLayout(false);
            this.grpProfitTarget.PerformLayout();
            this.grpMaxTotalLoss.ResumeLayout(false);
            this.grpMaxTotalLoss.PerformLayout();
            this.grpMaxdailyLoss.ResumeLayout(false);
            this.grpMaxdailyLoss.PerformLayout();
            this.grpValidation.ResumeLayout(false);
            this.grpValidation.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.ComboBox cmbPlatform;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.GroupBox grpAccountmanagement;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblPlatform;
        private System.Windows.Forms.Label lblProfitShare;
        private System.Windows.Forms.Label lblAccenddate;
        private System.Windows.Forms.Label lblAccstartdate;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAccountNum;
        private System.Windows.Forms.RadioButton rdoFund;
        private System.Windows.Forms.RadioButton rdoPersonal;
        private System.Windows.Forms.ComboBox cmbFundingfirm;
        private System.Windows.Forms.Label lblFundingfirm;
        private System.Windows.Forms.RadioButton rdoP3;
        private System.Windows.Forms.RadioButton rdoP2;
        private System.Windows.Forms.RadioButton rdoP1;
        private System.Windows.Forms.TextBox txtProfitshare;
        private System.Windows.Forms.Label lblCapital;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtDLamount;
        private System.Windows.Forms.TextBox txtDLpercent;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.Label lblTradePair;
        private System.Windows.Forms.TextBox txtCurrencyPair;
        private System.Windows.Forms.ComboBox cmbTrader;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.TextBox txtChallengeFees;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblChallengefee;
        private System.Windows.Forms.Label lblTradecondition;
        private System.Windows.Forms.GroupBox grpProfitTarget;
        private System.Windows.Forms.TextBox txtTamount;
        private System.Windows.Forms.TextBox txtTpercent;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblper2;
        private System.Windows.Forms.GroupBox grpMaxTotalLoss;
        private System.Windows.Forms.Label lblper1;
        private System.Windows.Forms.Label lblAmt;
        private System.Windows.Forms.TextBox txtTLpercent;
        private System.Windows.Forms.TextBox txtTLamount;
        private System.Windows.Forms.GroupBox grpMaxdailyLoss;
        private System.Windows.Forms.Label lblPer;
        private System.Windows.Forms.Label txtAmount;
        private System.Windows.Forms.RadioButton rdoGBP;
        private System.Windows.Forms.RadioButton rdoUSD;
        private System.Windows.Forms.DateTimePicker dtpTradeenddate;
        private System.Windows.Forms.DateTimePicker dtpTradestartdate;
        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.GroupBox grpValidation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClosingopenpositions;
        private System.Windows.Forms.Label lblMinpositionduration;
        private System.Windows.Forms.CheckBox ckNewsTrade;
        private System.Windows.Forms.CheckBox ckStoporders;
        private System.Windows.Forms.Label lblMintradingdays;
        private System.Windows.Forms.Label lblTradingdays;
        private System.Windows.Forms.TextBox txtClosingopenpositions;
        private System.Windows.Forms.TextBox txtMinpositionduration;
        private System.Windows.Forms.TextBox txtMintradingdays;
        private System.Windows.Forms.TextBox txtTotaltradingdays;
        private System.Windows.Forms.Label lblActuallotsize;
        private System.Windows.Forms.Label lblLotsizerange;
        private System.Windows.Forms.TextBox txtActuallotsize;
        private System.Windows.Forms.TextBox txtLotsizerange;
        private System.Windows.Forms.RichTextBox txtTradepattern;
        private System.Windows.Forms.GroupBox grpTradingoption;
        private System.Windows.Forms.CheckBox ckWeekendTrade;
        private System.Windows.Forms.Label lblTradepattern;
        private System.Windows.Forms.DateTimePicker dtpAccclosedate;
        private System.Windows.Forms.DateTimePicker dtpAccopendate;
        private System.Windows.Forms.Label lblTradeenddate;
        private System.Windows.Forms.Label lblTradestartdate;
        private System.Windows.Forms.DataGridView dgAccounts;
        private System.Windows.Forms.LinkLabel lnkBtnAdd;
    }
}

