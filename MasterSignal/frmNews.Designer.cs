namespace MasterSignal
{
    partial class frmNews
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grp_news = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgCountry = new System.Windows.Forms.DataGridView();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.radMedium = new System.Windows.Forms.RadioButton();
            this.radHigh = new System.Windows.Forms.RadioButton();
            this.lnkLoad = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.lblPattern = new System.Windows.Forms.Label();
            this.dgAllNews = new System.Windows.Forms.DataGridView();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.grp_news.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAllNews)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_news
            // 
            this.grp_news.Controls.Add(this.linkLabel1);
            this.grp_news.Controls.Add(this.btnSave);
            this.grp_news.Controls.Add(this.dgCountry);
            this.grp_news.Controls.Add(this.radAll);
            this.grp_news.Controls.Add(this.radMedium);
            this.grp_news.Controls.Add(this.radHigh);
            this.grp_news.Controls.Add(this.lnkLoad);
            this.grp_news.Controls.Add(this.label12);
            this.grp_news.Controls.Add(this.lblPattern);
            this.grp_news.Controls.Add(this.dgAllNews);
            this.grp_news.Location = new System.Drawing.Point(28, 12);
            this.grp_news.Margin = new System.Windows.Forms.Padding(4);
            this.grp_news.Name = "grp_news";
            this.grp_news.Padding = new System.Windows.Forms.Padding(4);
            this.grp_news.Size = new System.Drawing.Size(1412, 894);
            this.grp_news.TabIndex = 11;
            this.grp_news.TabStop = false;
            this.grp_news.Enter += new System.EventHandler(this.grp_news_Enter);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(12, 833);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(251, 33);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save to Database";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgCountry
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCountry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCountry.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgCountry.Location = new System.Drawing.Point(15, 116);
            this.dgCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgCountry.Name = "dgCountry";
            this.dgCountry.RowHeadersWidth = 62;
            this.dgCountry.Size = new System.Drawing.Size(241, 286);
            this.dgCountry.TabIndex = 29;
            this.dgCountry.Text = "dataGridView1";
            this.dgCountry.SelectionChanged += new System.EventHandler(this.dgCountry_SelectionChanged);
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Checked = true;
            this.radAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAll.Location = new System.Drawing.Point(197, 74);
            this.radAll.Margin = new System.Windows.Forms.Padding(4);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(49, 24);
            this.radAll.TabIndex = 28;
            this.radAll.TabStop = true;
            this.radAll.Text = "All";
            this.radAll.UseVisualStyleBackColor = true;
            this.radAll.CheckedChanged += new System.EventHandler(this.radAll_CheckedChanged);
            // 
            // radMedium
            // 
            this.radMedium.AutoSize = true;
            this.radMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMedium.Location = new System.Drawing.Point(96, 74);
            this.radMedium.Margin = new System.Windows.Forms.Padding(4);
            this.radMedium.Name = "radMedium";
            this.radMedium.Size = new System.Drawing.Size(89, 24);
            this.radMedium.TabIndex = 27;
            this.radMedium.Text = "Medium";
            this.radMedium.UseVisualStyleBackColor = true;
            this.radMedium.CheckedChanged += new System.EventHandler(this.radMedium_CheckedChanged);
            // 
            // radHigh
            // 
            this.radHigh.AutoSize = true;
            this.radHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHigh.Location = new System.Drawing.Point(21, 74);
            this.radHigh.Margin = new System.Windows.Forms.Padding(4);
            this.radHigh.Name = "radHigh";
            this.radHigh.Size = new System.Drawing.Size(65, 24);
            this.radHigh.TabIndex = 26;
            this.radHigh.Text = "High";
            this.radHigh.UseVisualStyleBackColor = true;
            this.radHigh.CheckedChanged += new System.EventHandler(this.radHigh_CheckedChanged);
            // 
            // lnkLoad
            // 
            this.lnkLoad.AutoSize = true;
            this.lnkLoad.Location = new System.Drawing.Point(9, 421);
            this.lnkLoad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkLoad.Name = "lnkLoad";
            this.lnkLoad.Size = new System.Drawing.Size(201, 17);
            this.lnkLoad.TabIndex = 20;
            this.lnkLoad.TabStop = true;
            this.lnkLoad.Text = "Load News (C:\\temp\\news.csv)";
            this.lnkLoad.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLoad_LinkClicked);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(737, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(216, 37);
            this.label12.TabIndex = 12;
            this.label12.Text = "Market FX News";
            // 
            // lblPattern
            // 
            this.lblPattern.AutoSize = true;
            this.lblPattern.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.lblPattern.Location = new System.Drawing.Point(0, 0);
            this.lblPattern.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPattern.Name = "lblPattern";
            this.lblPattern.Size = new System.Drawing.Size(0, 32);
            this.lblPattern.TabIndex = 8;
            // 
            // dgAllNews
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgAllNews.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgAllNews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgAllNews.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgAllNews.Location = new System.Drawing.Point(272, 70);
            this.dgAllNews.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgAllNews.Name = "dgAllNews";
            this.dgAllNews.RowHeadersWidth = 62;
            this.dgAllNews.Size = new System.Drawing.Size(1133, 817);
            this.dgAllNews.TabIndex = 21;
            this.dgAllNews.Text = "dataGridView1";
            this.dgAllNews.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAllNews_CellValueChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(183, 537);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(72, 17);
            this.linkLabel1.TabIndex = 31;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // frmNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 921);
            this.Controls.Add(this.grp_news);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNews";
            this.Text = "frmNews";
            this.Load += new System.EventHandler(this.frmNews_Load);
            this.grp_news.ResumeLayout(false);
            this.grp_news.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAllNews)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_news;
        private System.Windows.Forms.LinkLabel lnkLoad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblPattern;
        private System.Windows.Forms.DataGridView dgAllNews;
        private System.Windows.Forms.RadioButton radAll;
        private System.Windows.Forms.RadioButton radMedium;
        private System.Windows.Forms.RadioButton radHigh;
        private System.Windows.Forms.DataGridView dgCountry;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}