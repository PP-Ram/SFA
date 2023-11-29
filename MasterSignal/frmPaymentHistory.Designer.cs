namespace MasterSignal
{
    partial class frmPaymentHistory
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
            this.dgInvoice = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgItem = new System.Windows.Forms.DataGridView();
            this.radInvoice = new System.Windows.Forms.RadioButton();
            this.rdoInvoiceItem = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMainTotal = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItem)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgInvoice
            // 
            this.dgInvoice.AllowUserToAddRows = false;
            this.dgInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInvoice.Location = new System.Drawing.Point(24, 80);
            this.dgInvoice.Name = "dgInvoice";
            this.dgInvoice.ReadOnly = true;
            this.dgInvoice.RowHeadersVisible = false;
            this.dgInvoice.RowHeadersWidth = 51;
            this.dgInvoice.Size = new System.Drawing.Size(564, 251);
            this.dgInvoice.TabIndex = 17;
            this.dgInvoice.Text = "dataGridView1";
            this.dgInvoice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgInvoice_MouseClick);
            this.dgInvoice.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgInvoice_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(254, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Payment History";
            // 
            // dgItem
            // 
            this.dgItem.AllowUserToAddRows = false;
            this.dgItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItem.Location = new System.Drawing.Point(24, 372);
            this.dgItem.Name = "dgItem";
            this.dgItem.ReadOnly = true;
            this.dgItem.RowHeadersVisible = false;
            this.dgItem.RowHeadersWidth = 51;
            this.dgItem.Size = new System.Drawing.Size(564, 255);
            this.dgItem.TabIndex = 17;
            this.dgItem.Text = "dataGridView2";
            // 
            // radInvoice
            // 
            this.radInvoice.AutoSize = true;
            this.radInvoice.Checked = true;
            this.radInvoice.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radInvoice.Location = new System.Drawing.Point(124, 30);
            this.radInvoice.Name = "radInvoice";
            this.radInvoice.Size = new System.Drawing.Size(89, 29);
            this.radInvoice.TabIndex = 18;
            this.radInvoice.TabStop = true;
            this.radInvoice.Text = "Invoice";
            this.radInvoice.UseVisualStyleBackColor = true;
            // 
            // rdoInvoiceItem
            // 
            this.rdoInvoiceItem.AutoSize = true;
            this.rdoInvoiceItem.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoInvoiceItem.Location = new System.Drawing.Point(307, 30);
            this.rdoInvoiceItem.Name = "rdoInvoiceItem";
            this.rdoInvoiceItem.Size = new System.Drawing.Size(153, 29);
            this.rdoInvoiceItem.TabIndex = 19;
            this.rdoInvoiceItem.Text = "Payment Items";
            this.rdoInvoiceItem.UseVisualStyleBackColor = true;
            this.rdoInvoiceItem.CheckedChanged += new System.EventHandler(this.RdoInvoiceItem_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSubTotal);
            this.groupBox2.Controls.Add(this.rdoInvoiceItem);
            this.groupBox2.Controls.Add(this.lblMainTotal);
            this.groupBox2.Controls.Add(this.radInvoice);
            this.groupBox2.Controls.Add(this.dgItem);
            this.groupBox2.Controls.Add(this.dgInvoice);
            this.groupBox2.Location = new System.Drawing.Point(36, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(615, 679);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // lblMainTotal
            // 
            this.lblMainTotal.AutoSize = true;
            this.lblMainTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMainTotal.Location = new System.Drawing.Point(427, 340);
            this.lblMainTotal.Name = "lblMainTotal";
            this.lblMainTotal.Size = new System.Drawing.Size(62, 25);
            this.lblMainTotal.TabIndex = 18;
            this.lblMainTotal.Text = "label2";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubTotal.Location = new System.Drawing.Point(427, 633);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(62, 25);
            this.lblSubTotal.TabIndex = 20;
            this.lblSubTotal.Text = "label2";
            // 
            // frmPaymentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 736);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Name = "frmPaymentHistory";
            this.Text = "frmPaymentHistory";
            this.Load += new System.EventHandler(this.FrmPaymentHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgItem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgInvoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgItem;
        private System.Windows.Forms.RadioButton radInvoice;
        private System.Windows.Forms.RadioButton rdoInvoiceItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMainTotal;
        private System.Windows.Forms.Label lblSubTotal;
    }
}