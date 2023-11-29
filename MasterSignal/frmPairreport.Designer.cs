namespace MasterSignal
{
    partial class frmPairreport
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
            this.components = new System.ComponentModel.Container();
            this.cmbcurrencypair = new System.Windows.Forms.ComboBox();
            this.dgcurrencypair = new System.Windows.Forms.DataGridView();
            this.lblPaireport = new System.Windows.Forms.Label();
            this.lblPair = new System.Windows.Forms.Label();
            this.lblWQQE = new System.Windows.Forms.Label();
            this.lblDQQE = new System.Windows.Forms.Label();
            this.lblCrossover = new System.Windows.Forms.Label();
            this.lblTrend = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rdQQEWSell = new System.Windows.Forms.RadioButton();
            this.rdQQEWBuy = new System.Windows.Forms.RadioButton();
            this.rdCOWSell = new System.Windows.Forms.RadioButton();
            this.rdCOWBuy = new System.Windows.Forms.RadioButton();
            this.rdWTSell = new System.Windows.Forms.RadioButton();
            this.rdWTBuy = new System.Windows.Forms.RadioButton();
            this.rdQQEDSell = new System.Windows.Forms.RadioButton();
            this.rdQQEDBuy = new System.Windows.Forms.RadioButton();
            this.rdCODSell = new System.Windows.Forms.RadioButton();
            this.rdCODBuy = new System.Windows.Forms.RadioButton();
            this.rdDTSell = new System.Windows.Forms.RadioButton();
            this.rdDTBuy = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSeasonal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdTH4Buy = new System.Windows.Forms.RadioButton();
            this.rdTH4Sell = new System.Windows.Forms.RadioButton();
            this.rdCOH4Buy = new System.Windows.Forms.RadioButton();
            this.rdQQEH4Sell = new System.Windows.Forms.RadioButton();
            this.rdCOH4Sell = new System.Windows.Forms.RadioButton();
            this.rdQQEH4Buy = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWClosevalue = new System.Windows.Forms.TextBox();
            this.txtDClosevalue = new System.Windows.Forms.TextBox();
            this.lblWClosevalue = new System.Windows.Forms.Label();
            this.lblDClosevalue = new System.Windows.Forms.Label();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblpattern = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkview = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgcurrencypair)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbcurrencypair
            // 
            this.cmbcurrencypair.FormattingEnabled = true;
            this.cmbcurrencypair.Location = new System.Drawing.Point(50, 17);
            this.cmbcurrencypair.Margin = new System.Windows.Forms.Padding(5);
            this.cmbcurrencypair.Name = "cmbcurrencypair";
            this.cmbcurrencypair.Size = new System.Drawing.Size(514, 33);
            this.cmbcurrencypair.TabIndex = 5;
            this.cmbcurrencypair.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dgcurrencypair
            // 
            this.dgcurrencypair.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcurrencypair.Location = new System.Drawing.Point(50, 60);
            this.dgcurrencypair.Margin = new System.Windows.Forms.Padding(5);
            this.dgcurrencypair.Name = "dgcurrencypair";
            this.dgcurrencypair.RowHeadersWidth = 51;
            this.dgcurrencypair.RowTemplate.Height = 24;
            this.dgcurrencypair.Size = new System.Drawing.Size(576, 323);
            this.dgcurrencypair.TabIndex = 6;
            this.dgcurrencypair.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgcurrencypair_CellContentClick);
            this.dgcurrencypair.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgcurrencypair_CellValueChanged);
            this.dgcurrencypair.SelectionChanged += new System.EventHandler(this.dgcurrencypair_SelectionChanged);
            // 
            // lblPaireport
            // 
            this.lblPaireport.AutoSize = true;
            this.lblPaireport.Location = new System.Drawing.Point(1090, 23);
            this.lblPaireport.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPaireport.Name = "lblPaireport";
            this.lblPaireport.Size = new System.Drawing.Size(96, 25);
            this.lblPaireport.TabIndex = 7;
            this.lblPaireport.Text = "Pairreport";
            // 
            // lblPair
            // 
            this.lblPair.AutoSize = true;
            this.lblPair.Location = new System.Drawing.Point(60, 53);
            this.lblPair.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPair.Name = "lblPair";
            this.lblPair.Size = new System.Drawing.Size(46, 25);
            this.lblPair.TabIndex = 8;
            this.lblPair.Text = "Pair";
            // 
            // lblWQQE
            // 
            this.lblWQQE.AutoSize = true;
            this.lblWQQE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWQQE.Location = new System.Drawing.Point(293, 106);
            this.lblWQQE.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWQQE.Name = "lblWQQE";
            this.lblWQQE.Size = new System.Drawing.Size(66, 24);
            this.lblWQQE.TabIndex = 9;
            this.lblWQQE.Text = "WEEK";
            // 
            // lblDQQE
            // 
            this.lblDQQE.AutoSize = true;
            this.lblDQQE.Location = new System.Drawing.Point(49, 170);
            this.lblDQQE.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDQQE.Name = "lblDQQE";
            this.lblDQQE.Size = new System.Drawing.Size(57, 25);
            this.lblDQQE.TabIndex = 10;
            this.lblDQQE.Text = "QQE";
            // 
            // lblCrossover
            // 
            this.lblCrossover.AutoSize = true;
            this.lblCrossover.Location = new System.Drawing.Point(49, 233);
            this.lblCrossover.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCrossover.Name = "lblCrossover";
            this.lblCrossover.Size = new System.Drawing.Size(102, 25);
            this.lblCrossover.TabIndex = 11;
            this.lblCrossover.Text = "Crossover";
            this.lblCrossover.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblTrend
            // 
            this.lblTrend.AutoSize = true;
            this.lblTrend.Location = new System.Drawing.Point(49, 290);
            this.lblTrend.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTrend.Name = "lblTrend";
            this.lblTrend.Size = new System.Drawing.Size(64, 25);
            this.lblTrend.TabIndex = 12;
            this.lblTrend.Text = "Trend";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(250, 50);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 33);
            this.comboBox1.TabIndex = 14;
            // 
            // rdQQEWSell
            // 
            this.rdQQEWSell.AutoSize = true;
            this.rdQQEWSell.Location = new System.Drawing.Point(260, 168);
            this.rdQQEWSell.Margin = new System.Windows.Forms.Padding(5);
            this.rdQQEWSell.Name = "rdQQEWSell";
            this.rdQQEWSell.Size = new System.Drawing.Size(66, 29);
            this.rdQQEWSell.TabIndex = 15;
            this.rdQQEWSell.TabStop = true;
            this.rdQQEWSell.Text = "Sell";
            this.rdQQEWSell.UseVisualStyleBackColor = true;
            // 
            // rdQQEWBuy
            // 
            this.rdQQEWBuy.AutoSize = true;
            this.rdQQEWBuy.Location = new System.Drawing.Point(337, 170);
            this.rdQQEWBuy.Margin = new System.Windows.Forms.Padding(5);
            this.rdQQEWBuy.Name = "rdQQEWBuy";
            this.rdQQEWBuy.Size = new System.Drawing.Size(67, 29);
            this.rdQQEWBuy.TabIndex = 16;
            this.rdQQEWBuy.TabStop = true;
            this.rdQQEWBuy.Text = "Buy";
            this.rdQQEWBuy.UseVisualStyleBackColor = true;
            // 
            // rdCOWSell
            // 
            this.rdCOWSell.AutoSize = true;
            this.rdCOWSell.Location = new System.Drawing.Point(260, 228);
            this.rdCOWSell.Margin = new System.Windows.Forms.Padding(5);
            this.rdCOWSell.Name = "rdCOWSell";
            this.rdCOWSell.Size = new System.Drawing.Size(66, 29);
            this.rdCOWSell.TabIndex = 17;
            this.rdCOWSell.TabStop = true;
            this.rdCOWSell.Text = "Sell";
            this.rdCOWSell.UseVisualStyleBackColor = true;
            // 
            // rdCOWBuy
            // 
            this.rdCOWBuy.AutoSize = true;
            this.rdCOWBuy.Location = new System.Drawing.Point(337, 228);
            this.rdCOWBuy.Margin = new System.Windows.Forms.Padding(5);
            this.rdCOWBuy.Name = "rdCOWBuy";
            this.rdCOWBuy.Size = new System.Drawing.Size(67, 29);
            this.rdCOWBuy.TabIndex = 18;
            this.rdCOWBuy.TabStop = true;
            this.rdCOWBuy.Text = "Buy";
            this.rdCOWBuy.UseVisualStyleBackColor = true;
            // 
            // rdWTSell
            // 
            this.rdWTSell.AutoSize = true;
            this.rdWTSell.Location = new System.Drawing.Point(260, 287);
            this.rdWTSell.Margin = new System.Windows.Forms.Padding(5);
            this.rdWTSell.Name = "rdWTSell";
            this.rdWTSell.Size = new System.Drawing.Size(66, 29);
            this.rdWTSell.TabIndex = 19;
            this.rdWTSell.TabStop = true;
            this.rdWTSell.Text = "Sell";
            this.rdWTSell.UseVisualStyleBackColor = true;
            // 
            // rdWTBuy
            // 
            this.rdWTBuy.AutoSize = true;
            this.rdWTBuy.Location = new System.Drawing.Point(337, 288);
            this.rdWTBuy.Margin = new System.Windows.Forms.Padding(5);
            this.rdWTBuy.Name = "rdWTBuy";
            this.rdWTBuy.Size = new System.Drawing.Size(67, 29);
            this.rdWTBuy.TabIndex = 20;
            this.rdWTBuy.TabStop = true;
            this.rdWTBuy.Text = "Buy";
            this.rdWTBuy.UseVisualStyleBackColor = true;
            // 
            // rdQQEDSell
            // 
            this.rdQQEDSell.AutoSize = true;
            this.rdQQEDSell.Location = new System.Drawing.Point(451, 170);
            this.rdQQEDSell.Margin = new System.Windows.Forms.Padding(5);
            this.rdQQEDSell.Name = "rdQQEDSell";
            this.rdQQEDSell.Size = new System.Drawing.Size(66, 29);
            this.rdQQEDSell.TabIndex = 21;
            this.rdQQEDSell.TabStop = true;
            this.rdQQEDSell.Text = "Sell";
            this.rdQQEDSell.UseVisualStyleBackColor = true;
            // 
            // rdQQEDBuy
            // 
            this.rdQQEDBuy.AutoSize = true;
            this.rdQQEDBuy.Location = new System.Drawing.Point(527, 172);
            this.rdQQEDBuy.Margin = new System.Windows.Forms.Padding(5);
            this.rdQQEDBuy.Name = "rdQQEDBuy";
            this.rdQQEDBuy.Size = new System.Drawing.Size(67, 29);
            this.rdQQEDBuy.TabIndex = 22;
            this.rdQQEDBuy.TabStop = true;
            this.rdQQEDBuy.Text = "Buy";
            this.rdQQEDBuy.UseVisualStyleBackColor = true;
            // 
            // rdCODSell
            // 
            this.rdCODSell.AutoSize = true;
            this.rdCODSell.Location = new System.Drawing.Point(451, 228);
            this.rdCODSell.Margin = new System.Windows.Forms.Padding(5);
            this.rdCODSell.Name = "rdCODSell";
            this.rdCODSell.Size = new System.Drawing.Size(66, 29);
            this.rdCODSell.TabIndex = 23;
            this.rdCODSell.TabStop = true;
            this.rdCODSell.Text = "Sell";
            this.rdCODSell.UseVisualStyleBackColor = true;
            // 
            // rdCODBuy
            // 
            this.rdCODBuy.AutoSize = true;
            this.rdCODBuy.Location = new System.Drawing.Point(527, 228);
            this.rdCODBuy.Margin = new System.Windows.Forms.Padding(5);
            this.rdCODBuy.Name = "rdCODBuy";
            this.rdCODBuy.Size = new System.Drawing.Size(67, 29);
            this.rdCODBuy.TabIndex = 24;
            this.rdCODBuy.TabStop = true;
            this.rdCODBuy.Text = "Buy";
            this.rdCODBuy.UseVisualStyleBackColor = true;
            // 
            // rdDTSell
            // 
            this.rdDTSell.AutoSize = true;
            this.rdDTSell.Location = new System.Drawing.Point(451, 288);
            this.rdDTSell.Margin = new System.Windows.Forms.Padding(5);
            this.rdDTSell.Name = "rdDTSell";
            this.rdDTSell.Size = new System.Drawing.Size(66, 29);
            this.rdDTSell.TabIndex = 26;
            this.rdDTSell.TabStop = true;
            this.rdDTSell.Text = "Sell";
            this.rdDTSell.UseVisualStyleBackColor = true;
            // 
            // rdDTBuy
            // 
            this.rdDTBuy.AutoSize = true;
            this.rdDTBuy.Location = new System.Drawing.Point(527, 288);
            this.rdDTBuy.Margin = new System.Windows.Forms.Padding(5);
            this.rdDTBuy.Name = "rdDTBuy";
            this.rdDTBuy.Size = new System.Drawing.Size(67, 29);
            this.rdDTBuy.TabIndex = 27;
            this.rdDTBuy.TabStop = true;
            this.rdDTBuy.Text = "Buy";
            this.rdDTBuy.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSeasonal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDetails);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdTH4Buy);
            this.groupBox1.Controls.Add(this.rdTH4Sell);
            this.groupBox1.Controls.Add(this.rdCOH4Buy);
            this.groupBox1.Controls.Add(this.rdQQEH4Sell);
            this.groupBox1.Controls.Add(this.rdCOH4Sell);
            this.groupBox1.Controls.Add(this.rdQQEH4Buy);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtWClosevalue);
            this.groupBox1.Controls.Add(this.txtDClosevalue);
            this.groupBox1.Controls.Add(this.lblPair);
            this.groupBox1.Controls.Add(this.lblWClosevalue);
            this.groupBox1.Controls.Add(this.lblWQQE);
            this.groupBox1.Controls.Add(this.lblDClosevalue);
            this.groupBox1.Controls.Add(this.lblDQQE);
            this.groupBox1.Controls.Add(this.lblCrossover);
            this.groupBox1.Controls.Add(this.txtPattern);
            this.groupBox1.Controls.Add(this.lblTrend);
            this.groupBox1.Controls.Add(this.lblDetails);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lblpattern);
            this.groupBox1.Controls.Add(this.rdQQEWSell);
            this.groupBox1.Controls.Add(this.rdQQEWBuy);
            this.groupBox1.Controls.Add(this.rdCOWSell);
            this.groupBox1.Controls.Add(this.rdDTBuy);
            this.groupBox1.Controls.Add(this.rdCOWBuy);
            this.groupBox1.Controls.Add(this.rdDTSell);
            this.groupBox1.Controls.Add(this.rdWTSell);
            this.groupBox1.Controls.Add(this.rdWTBuy);
            this.groupBox1.Controls.Add(this.rdCODBuy);
            this.groupBox1.Controls.Add(this.rdQQEDSell);
            this.groupBox1.Controls.Add(this.rdCODSell);
            this.groupBox1.Controls.Add(this.rdQQEDBuy);
            this.groupBox1.Location = new System.Drawing.Point(702, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(818, 910);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // txtSeasonal
            // 
            this.txtSeasonal.Location = new System.Drawing.Point(250, 478);
            this.txtSeasonal.Name = "txtSeasonal";
            this.txtSeasonal.Size = new System.Drawing.Size(179, 30);
            this.txtSeasonal.TabIndex = 89;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 478);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 88;
            this.label7.Text = "Seasonal";
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(250, 607);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(357, 138);
            this.txtDetails.TabIndex = 87;
            this.txtDetails.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(692, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "H4";
            // 
            // rdTH4Buy
            // 
            this.rdTH4Buy.AutoSize = true;
            this.rdTH4Buy.Location = new System.Drawing.Point(710, 286);
            this.rdTH4Buy.Margin = new System.Windows.Forms.Padding(5);
            this.rdTH4Buy.Name = "rdTH4Buy";
            this.rdTH4Buy.Size = new System.Drawing.Size(67, 29);
            this.rdTH4Buy.TabIndex = 45;
            this.rdTH4Buy.TabStop = true;
            this.rdTH4Buy.Text = "Buy";
            this.rdTH4Buy.UseVisualStyleBackColor = true;
            // 
            // rdTH4Sell
            // 
            this.rdTH4Sell.AutoSize = true;
            this.rdTH4Sell.Location = new System.Drawing.Point(634, 288);
            this.rdTH4Sell.Margin = new System.Windows.Forms.Padding(5);
            this.rdTH4Sell.Name = "rdTH4Sell";
            this.rdTH4Sell.Size = new System.Drawing.Size(66, 29);
            this.rdTH4Sell.TabIndex = 44;
            this.rdTH4Sell.TabStop = true;
            this.rdTH4Sell.Text = "Sell";
            this.rdTH4Sell.UseVisualStyleBackColor = true;
            // 
            // rdCOH4Buy
            // 
            this.rdCOH4Buy.AutoSize = true;
            this.rdCOH4Buy.Location = new System.Drawing.Point(710, 231);
            this.rdCOH4Buy.Margin = new System.Windows.Forms.Padding(5);
            this.rdCOH4Buy.Name = "rdCOH4Buy";
            this.rdCOH4Buy.Size = new System.Drawing.Size(67, 29);
            this.rdCOH4Buy.TabIndex = 43;
            this.rdCOH4Buy.TabStop = true;
            this.rdCOH4Buy.Text = "Buy";
            this.rdCOH4Buy.UseVisualStyleBackColor = true;
            // 
            // rdQQEH4Sell
            // 
            this.rdQQEH4Sell.AutoSize = true;
            this.rdQQEH4Sell.Location = new System.Drawing.Point(634, 171);
            this.rdQQEH4Sell.Margin = new System.Windows.Forms.Padding(5);
            this.rdQQEH4Sell.Name = "rdQQEH4Sell";
            this.rdQQEH4Sell.Size = new System.Drawing.Size(66, 29);
            this.rdQQEH4Sell.TabIndex = 40;
            this.rdQQEH4Sell.TabStop = true;
            this.rdQQEH4Sell.Text = "Sell";
            this.rdQQEH4Sell.UseVisualStyleBackColor = true;
            // 
            // rdCOH4Sell
            // 
            this.rdCOH4Sell.AutoSize = true;
            this.rdCOH4Sell.Location = new System.Drawing.Point(634, 229);
            this.rdCOH4Sell.Margin = new System.Windows.Forms.Padding(5);
            this.rdCOH4Sell.Name = "rdCOH4Sell";
            this.rdCOH4Sell.Size = new System.Drawing.Size(66, 29);
            this.rdCOH4Sell.TabIndex = 42;
            this.rdCOH4Sell.TabStop = true;
            this.rdCOH4Sell.Text = "Sell";
            this.rdCOH4Sell.UseVisualStyleBackColor = true;
            // 
            // rdQQEH4Buy
            // 
            this.rdQQEH4Buy.AutoSize = true;
            this.rdQQEH4Buy.Location = new System.Drawing.Point(710, 172);
            this.rdQQEH4Buy.Margin = new System.Windows.Forms.Padding(5);
            this.rdQQEH4Buy.Name = "rdQQEH4Buy";
            this.rdQQEH4Buy.Size = new System.Drawing.Size(67, 29);
            this.rdQQEH4Buy.TabIndex = 41;
            this.rdQQEH4Buy.TabStop = true;
            this.rdQQEH4Buy.Text = "Buy";
            this.rdQQEH4Buy.UseVisualStyleBackColor = true;
            this.rdQQEH4Buy.CheckedChanged += new System.EventHandler(this.rdQQEH4Buy_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "Day";
            // 
            // txtWClosevalue
            // 
            this.txtWClosevalue.Location = new System.Drawing.Point(250, 412);
            this.txtWClosevalue.Name = "txtWClosevalue";
            this.txtWClosevalue.Size = new System.Drawing.Size(179, 30);
            this.txtWClosevalue.TabIndex = 38;
            // 
            // txtDClosevalue
            // 
            this.txtDClosevalue.Location = new System.Drawing.Point(250, 352);
            this.txtDClosevalue.Name = "txtDClosevalue";
            this.txtDClosevalue.Size = new System.Drawing.Size(179, 30);
            this.txtDClosevalue.TabIndex = 37;
            // 
            // lblWClosevalue
            // 
            this.lblWClosevalue.AutoSize = true;
            this.lblWClosevalue.Location = new System.Drawing.Point(49, 415);
            this.lblWClosevalue.Name = "lblWClosevalue";
            this.lblWClosevalue.Size = new System.Drawing.Size(130, 25);
            this.lblWClosevalue.TabIndex = 36;
            this.lblWClosevalue.Text = "WClosevalue";
            // 
            // lblDClosevalue
            // 
            this.lblDClosevalue.AutoSize = true;
            this.lblDClosevalue.Location = new System.Drawing.Point(49, 352);
            this.lblDClosevalue.Name = "lblDClosevalue";
            this.lblDClosevalue.Size = new System.Drawing.Size(124, 25);
            this.lblDClosevalue.TabIndex = 34;
            this.lblDClosevalue.Text = "DClosevalue";
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(250, 542);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(179, 30);
            this.txtPattern.TabIndex = 32;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(49, 627);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(71, 25);
            this.lblDetails.TabIndex = 31;
            this.lblDetails.Text = "Details";
            // 
            // lblpattern
            // 
            this.lblpattern.AutoSize = true;
            this.lblpattern.Location = new System.Drawing.Point(49, 542);
            this.lblpattern.Name = "lblpattern";
            this.lblpattern.Size = new System.Drawing.Size(74, 25);
            this.lblpattern.TabIndex = 30;
            this.lblpattern.Text = "Pattern";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(73, 548);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(576, 245);
            this.dataGridView1.TabIndex = 29;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgcurrencypair);
            this.groupBox2.Controls.Add(this.cmbcurrencypair);
            this.groupBox2.Location = new System.Drawing.Point(23, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(649, 481);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // chkview
            // 
            this.chkview.AutoSize = true;
            this.chkview.Location = new System.Drawing.Point(780, 38);
            this.chkview.Name = "chkview";
            this.chkview.Size = new System.Drawing.Size(73, 29);
            this.chkview.TabIndex = 31;
            this.chkview.Text = "view";
            this.chkview.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Items.AddRange(new object[] {
            "view",
            "label"});
            this.listBox1.Location = new System.Drawing.Point(876, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 79);
            this.listBox1.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmPairreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.chkview);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPaireport);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmPairreport";
            this.Text = "frmPairreport";
            this.Load += new System.EventHandler(this.frmPairreport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcurrencypair)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       
        private System.Windows.Forms.ComboBox cmbcurrencypair;
        private System.Windows.Forms.DataGridView dgcurrencypair;
        private System.Windows.Forms.Label lblPaireport;
        private System.Windows.Forms.Label lblPair;
        private System.Windows.Forms.Label lblWQQE;
        private System.Windows.Forms.Label lblDQQE;
        private System.Windows.Forms.Label lblCrossover;
        private System.Windows.Forms.Label lblTrend;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rdQQEWSell;
        private System.Windows.Forms.RadioButton rdQQEWBuy;
        private System.Windows.Forms.RadioButton rdCOWSell;
        private System.Windows.Forms.RadioButton rdCOWBuy;
        private System.Windows.Forms.RadioButton rdWTSell;
        private System.Windows.Forms.RadioButton rdWTBuy;
        private System.Windows.Forms.RadioButton rdQQEDSell;
        private System.Windows.Forms.RadioButton rdQQEDBuy;
        private System.Windows.Forms.RadioButton rdCODSell;
        private System.Windows.Forms.RadioButton rdCODBuy;
        private System.Windows.Forms.RadioButton rdDTSell;
        private System.Windows.Forms.RadioButton rdDTBuy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblpattern;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.Label lblDClosevalue;
        private System.Windows.Forms.Label lblWClosevalue;
        private System.Windows.Forms.TextBox txtDClosevalue;
        private System.Windows.Forms.TextBox txtWClosevalue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdTH4Buy;
        private System.Windows.Forms.RadioButton rdTH4Sell;
        private System.Windows.Forms.RadioButton rdCOH4Buy;
        private System.Windows.Forms.RadioButton rdQQEH4Sell;
        private System.Windows.Forms.RadioButton rdCOH4Sell;
        private System.Windows.Forms.RadioButton rdQQEH4Buy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSeasonal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtDetails;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkview;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}