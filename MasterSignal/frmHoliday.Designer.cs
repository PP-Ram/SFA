﻿namespace MasterSignal
{
    partial class frmHoliday
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
            this.dgPaperTrade = new System.Windows.Forms.DataGridView();
            this.grp_PaperTrade = new System.Windows.Forms.GroupBox();
            this.lblPaperHead = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPaperTrade)).BeginInit();
            this.grp_PaperTrade.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgPaperTrade
            // 
            this.dgPaperTrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPaperTrade.Location = new System.Drawing.Point(19, 25);
            this.dgPaperTrade.Margin = new System.Windows.Forms.Padding(2);
            this.dgPaperTrade.Name = "dgPaperTrade";
            this.dgPaperTrade.RowHeadersVisible = false;
            this.dgPaperTrade.RowHeadersWidth = 62;
            this.dgPaperTrade.Size = new System.Drawing.Size(965, 487);
            this.dgPaperTrade.TabIndex = 12;
            this.dgPaperTrade.Text = "dataGridView1";
            this.dgPaperTrade.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPaperTrade_CellContentClick);
            this.dgPaperTrade.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgPaperTrade_CellValueChanged);
            // 
            // grp_PaperTrade
            // 
            this.grp_PaperTrade.Controls.Add(this.dgPaperTrade);
            this.grp_PaperTrade.Location = new System.Drawing.Point(14, 38);
            this.grp_PaperTrade.Name = "grp_PaperTrade";
            this.grp_PaperTrade.Size = new System.Drawing.Size(1002, 527);
            this.grp_PaperTrade.TabIndex = 13;
            this.grp_PaperTrade.TabStop = false;
            // 
            // lblPaperHead
            // 
            this.lblPaperHead.AutoSize = true;
            this.lblPaperHead.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblPaperHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPaperHead.Location = new System.Drawing.Point(403, 5);
            this.lblPaperHead.Name = "lblPaperHead";
            this.lblPaperHead.Size = new System.Drawing.Size(160, 37);
            this.lblPaperHead.TabIndex = 14;
            this.lblPaperHead.Text = "Holiday List";
            // 
            // frmHoliday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 578);
            this.Controls.Add(this.lblPaperHead);
            this.Controls.Add(this.grp_PaperTrade);
            this.Name = "frmHoliday";
            this.Text = "frmH4Trade";
            this.Load += new System.EventHandler(this.FrmPaperTrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPaperTrade)).EndInit();
            this.grp_PaperTrade.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPaperTrade;
        private System.Windows.Forms.GroupBox grp_PaperTrade;
        private System.Windows.Forms.Label lblPaperHead;
    }
}