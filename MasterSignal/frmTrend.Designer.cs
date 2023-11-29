namespace MasterSignal
{
    partial class frmTrend
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
            this.lblHead = new System.Windows.Forms.Label();
            this.dgTrends = new System.Windows.Forms.DataGridView();
            this.chkRed = new System.Windows.Forms.CheckBox();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.btnSaveToDatabase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTrends)).BeginInit();
            this.grpFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblHead.ForeColor = System.Drawing.Color.Maroon;
            this.lblHead.Location = new System.Drawing.Point(201, 10);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(236, 25);
            this.lblHead.TabIndex = 0;
            this.lblHead.Text = "Week and Day QQE Signal";
            // 
            // dgTrends
            // 
            this.dgTrends.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTrends.Location = new System.Drawing.Point(76, 78);
            this.dgTrends.Name = "dgTrends";
            this.dgTrends.RowHeadersWidth = 51;
            this.dgTrends.Size = new System.Drawing.Size(433, 460);
            this.dgTrends.TabIndex = 1;
            this.dgTrends.Text = "dataGridView1";
            this.dgTrends.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgTrends_CellValueChanged);
            // 
            // chkRed
            // 
            this.chkRed.AutoSize = true;
            this.chkRed.ForeColor = System.Drawing.Color.Black;
            this.chkRed.Location = new System.Drawing.Point(365, 15);
            this.chkRed.Name = "chkRed";
            this.chkRed.Size = new System.Drawing.Size(110, 17);
            this.chkRed.TabIndex = 3;
            this.chkRed.Text = "Same Short/Long";
            this.chkRed.UseVisualStyleBackColor = true;
            this.chkRed.Click += new System.EventHandler(this.ResetAll);
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.chkRed);
            this.grpFilter.Location = new System.Drawing.Point(47, 39);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(489, 547);
            this.grpFilter.TabIndex = 6;
            this.grpFilter.TabStop = false;
            // 
            // btnSaveToDatabase
            // 
            this.btnSaveToDatabase.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSaveToDatabase.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSaveToDatabase.Location = new System.Drawing.Point(225, 550);
            this.btnSaveToDatabase.Name = "btnSaveToDatabase";
            this.btnSaveToDatabase.Size = new System.Drawing.Size(135, 29);
            this.btnSaveToDatabase.TabIndex = 7;
            this.btnSaveToDatabase.Text = "Save To Database";
            this.btnSaveToDatabase.UseVisualStyleBackColor = false;
            this.btnSaveToDatabase.Click += new System.EventHandler(this.BtnSaveToDatabase_Click);
            // 
            // frmTrend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(560, 588);
            this.Controls.Add(this.btnSaveToDatabase);
            this.Controls.Add(this.dgTrends);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.grpFilter);
            this.Name = "frmTrend";
            this.Text = "QQE Signal";
            this.Load += new System.EventHandler(this.FrmSnipper_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTrends)).EndInit();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.DataGridView dgTrends;
        private System.Windows.Forms.CheckBox chkRed;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Button btnSaveToDatabase;
    }
}