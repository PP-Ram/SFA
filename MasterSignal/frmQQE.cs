using System;
using System.Drawing;
using System.Windows.Forms;

namespace MasterSignal
{
    public partial class frmQQE : Form
    {
        private DataObject db;
        private Utilities util;
        public frmQQE()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            db = new DataObject();
            util = new Utilities();

            dg_tblQQE.RowTemplate.MinimumHeight = 40;
            dg_tblQQE.RowHeadersVisible = dg_tblQQE.AllowUserToAddRows = 
            dg_tblQQE.EnableHeadersVisualStyles = false;
            dg_tblQQE.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;

            dg_tblQQE.Font = new Font("Tahoma", 13);

            dg_tblQQE.DataSource = db.GetQQEAll();
            dg_tblQQE.Columns[0].Visible = dg_tblQQE.Columns[6].Visible = false;
            
        }

        private void dg_tblQQE_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var q = dg_tblQQE;
            if (e.RowIndex <= q.Rows.Count - 1)
            {
                string colHeader = q.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (colHeader != "")
                {
                    string rowHeader = q.Columns[e.ColumnIndex].HeaderText.ToString();
                    string val = q.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    db.UpdateQQE(rowHeader, colHeader, val);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            db.InsertQQE();
            dg_tblQQE.DataSource = db.GetQQEAll();
            dg_tblQQE.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            util.SaveToRepository();
        }
    }
}
    
    





    
    

