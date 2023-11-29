
namespace MasterSignal
{
    partial class frmQQE
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
            this.dg_tblQQE = new System.Windows.Forms.DataGridView();
            this.lBLheading = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_tblQQE)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_tblQQE
            // 
            this.dg_tblQQE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_tblQQE.Location = new System.Drawing.Point(25, 68);
            this.dg_tblQQE.Name = "dg_tblQQE";
            this.dg_tblQQE.RowTemplate.Height = 25;
            this.dg_tblQQE.Size = new System.Drawing.Size(613, 463);
            this.dg_tblQQE.TabIndex = 0;
            this.dg_tblQQE.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_tblQQE_CellValueChanged);
            // 
            // lBLheading
            // 
            this.lBLheading.AutoSize = true;
            this.lBLheading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBLheading.Location = new System.Drawing.Point(236, 24);
            this.lBLheading.Name = "lBLheading";
            this.lBLheading.Size = new System.Drawing.Size(158, 24);
            this.lBLheading.TabIndex = 1;
            this.lBLheading.Text = "QQE Signal - Day";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(240, 552);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(155, 33);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save to database";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(599, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(39, 38);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmQQE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 597);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lBLheading);
            this.Controls.Add(this.dg_tblQQE);
            this.Name = "frmQQE";
            this.Text = "Day QQE Signal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_tblQQE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_tblQQE;
        private System.Windows.Forms.Label lBLheading;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
    }
}

