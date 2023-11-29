namespace MasterSignal
{
    partial class frmTradingImages
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
            this.picTrading = new System.Windows.Forms.PictureBox();
            this.btnIUpload = new System.Windows.Forms.Button();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.lblImageDesc = new System.Windows.Forms.Label();
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.cmbSource = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblFileNameVal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmpImageType = new System.Windows.Forms.ComboBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkAddImage = new System.Windows.Forms.LinkLabel();
            this.FileImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.TVtradeImage = new System.Windows.Forms.TreeView();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lnkChange = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picTrading)).BeginInit();
            this.grpAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // picTrading
            // 
            this.picTrading.Location = new System.Drawing.Point(299, 48);
            this.picTrading.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picTrading.Name = "picTrading";
            this.picTrading.Size = new System.Drawing.Size(1139, 790);
            this.picTrading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTrading.TabIndex = 11;
            this.picTrading.TabStop = false;
            // 
            // btnIUpload
            // 
            this.btnIUpload.BackColor = System.Drawing.Color.LightGreen;
            this.btnIUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIUpload.Location = new System.Drawing.Point(511, 388);
            this.btnIUpload.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnIUpload.Name = "btnIUpload";
            this.btnIUpload.Size = new System.Drawing.Size(123, 30);
            this.btnIUpload.TabIndex = 24;
            this.btnIUpload.Text = "Upload Image";
            this.btnIUpload.UseVisualStyleBackColor = false;
            this.btnIUpload.Click += new System.EventHandler(this.BtnIUpload_Click);
            // 
            // txtDetails
            // 
            this.txtDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDetails.Location = new System.Drawing.Point(17, 160);
            this.txtDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetails.Size = new System.Drawing.Size(707, 226);
            this.txtDetails.TabIndex = 26;
            // 
            // lblImageDesc
            // 
            this.lblImageDesc.AutoSize = true;
            this.lblImageDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblImageDesc.ForeColor = System.Drawing.Color.DarkRed;
            this.lblImageDesc.Location = new System.Drawing.Point(299, 14);
            this.lblImageDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImageDesc.Name = "lblImageDesc";
            this.lblImageDesc.Size = new System.Drawing.Size(44, 16);
            this.lblImageDesc.TabIndex = 25;
            this.lblImageDesc.Text = "label1";
            // 
            // grpAdd
            // 
            this.grpAdd.BackColor = System.Drawing.Color.LightGray;
            this.grpAdd.Controls.Add(this.btnChange);
            this.grpAdd.Controls.Add(this.cmbSource);
            this.grpAdd.Controls.Add(this.label4);
            this.grpAdd.Controls.Add(this.label3);
            this.grpAdd.Controls.Add(this.btnClose);
            this.grpAdd.Controls.Add(this.lblFileNameVal);
            this.grpAdd.Controls.Add(this.label2);
            this.grpAdd.Controls.Add(this.cmpImageType);
            this.grpAdd.Controls.Add(this.lblFileName);
            this.grpAdd.Controls.Add(this.label1);
            this.grpAdd.Controls.Add(this.txtDetails);
            this.grpAdd.Controls.Add(this.btnIUpload);
            this.grpAdd.Location = new System.Drawing.Point(433, 48);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(739, 424);
            this.grpAdd.TabIndex = 28;
            this.grpAdd.TabStop = false;
            this.grpAdd.Visible = false;
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.LightGreen;
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChange.Location = new System.Drawing.Point(368, 388);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(123, 30);
            this.btnChange.TabIndex = 29;
            this.btnChange.Text = "Change Details";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // cmbSource
            // 
            this.cmbSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSource.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbSource.FormattingEnabled = true;
            this.cmbSource.Items.AddRange(new object[] {
            "Trading View",
            "You tube",
            "Google",
            "Internet",
            "Smart Chart",
            "Learn To Treade"});
            this.cmbSource.Location = new System.Drawing.Point(437, 102);
            this.cmbSource.Name = "cmbSource";
            this.cmbSource.Size = new System.Drawing.Size(155, 25);
            this.cmbSource.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(337, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Source:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(242, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Upload New Trading Images";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Pink;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(642, 388);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 30);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lblFileNameVal
            // 
            this.lblFileNameVal.AutoSize = true;
            this.lblFileNameVal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFileNameVal.ForeColor = System.Drawing.Color.Maroon;
            this.lblFileNameVal.Location = new System.Drawing.Point(108, 69);
            this.lblFileNameVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFileNameVal.Name = "lblFileNameVal";
            this.lblFileNameVal.Size = new System.Drawing.Size(79, 20);
            this.lblFileNameVal.TabIndex = 27;
            this.lblFileNameVal.Text = "File Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "File Type:";
            // 
            // cmpImageType
            // 
            this.cmpImageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmpImageType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmpImageType.FormattingEnabled = true;
            this.cmpImageType.Location = new System.Drawing.Point(108, 104);
            this.cmpImageType.Name = "cmpImageType";
            this.cmpImageType.Size = new System.Drawing.Size(155, 25);
            this.cmpImageType.TabIndex = 28;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFileName.ForeColor = System.Drawing.Color.Black;
            this.lblFileName.Location = new System.Drawing.Point(17, 69);
            this.lblFileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(69, 17);
            this.lblFileName.TabIndex = 27;
            this.lblFileName.Text = "File Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Details";
            // 
            // lnkAddImage
            // 
            this.lnkAddImage.AutoSize = true;
            this.lnkAddImage.Location = new System.Drawing.Point(4, 14);
            this.lnkAddImage.Name = "lnkAddImage";
            this.lnkAddImage.Size = new System.Drawing.Size(92, 15);
            this.lnkAddImage.TabIndex = 29;
            this.lnkAddImage.TabStop = true;
            this.lnkAddImage.Text = "Add New Image";
            this.lnkAddImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkAddImage_LinkClicked);
            // 
            // FileImageDialog
            // 
            this.FileImageDialog.FileName = "openFileDialog1";
            // 
            // TVtradeImage
            // 
            this.TVtradeImage.Location = new System.Drawing.Point(4, 48);
            this.TVtradeImage.Name = "TVtradeImage";
            this.TVtradeImage.Size = new System.Drawing.Size(276, 728);
            this.TVtradeImage.TabIndex = 30;
            this.TVtradeImage.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TVtradeImage_AfterSelect);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltotal.Location = new System.Drawing.Point(189, 12);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(38, 19);
            this.lbltotal.TabIndex = 31;
            this.lbltotal.Text = "Total";
            // 
            // lnkChange
            // 
            this.lnkChange.AutoSize = true;
            this.lnkChange.Location = new System.Drawing.Point(99, 14);
            this.lnkChange.Name = "lnkChange";
            this.lnkChange.Size = new System.Drawing.Size(86, 15);
            this.lnkChange.TabIndex = 32;
            this.lnkChange.TabStop = true;
            this.lnkChange.Text = "Change Details";
            this.lnkChange.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkChange_LinkClicked);
            // 
            // frmTradingImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 881);
            this.Controls.Add(this.lnkChange);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.TVtradeImage);
            this.Controls.Add(this.lnkAddImage);
            this.Controls.Add(this.grpAdd);
            this.Controls.Add(this.lblImageDesc);
            this.Controls.Add(this.picTrading);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmTradingImages";
            this.Text = "Smart Forex App - Trading Images";
            this.Load += new System.EventHandler(this.FrmEducation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTrading)).EndInit();
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picTrading;
        private System.Windows.Forms.Button btnIUpload;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label lblImageDesc;
        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkAddImage;
        private System.Windows.Forms.OpenFileDialog FileImageDialog;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblFileNameVal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmpImageType;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView TVtradeImage;
        private System.Windows.Forms.ComboBox cmbSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.LinkLabel lnkChange;
        private System.Windows.Forms.Button btnChange;
    }
}

