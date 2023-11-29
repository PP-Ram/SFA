using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace MasterSignal
{
    public partial class frmPairreport : Form
    {       DataObject db = new DataObject();
        Utilities util = new Utilities();
        public frmPairreport()
        {
            InitializeComponent();
        }


        private void dgcurrencypair_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void dgcurrencypair_SelectionChanged(object sender, EventArgs e)
        {
            if (dgcurrencypair.SelectedRows.Count >= 1)
            {
                string selValue = dgcurrencypair.SelectedRows[0].Cells[0].Value.ToString();
                Account acc = db.getNewAccountDetails(selValue);

            }
        }

        private void frmPairreport_Load(object sender, EventArgs e)
        {
            
            foreach (DataRow item in db.GetPairReport().Rows)
            {
                cmbcurrencypair.Items.Add(item[1].ToString());
            } 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgcurrencypair_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var q = dgcurrencypair;
            if (e.RowIndex <= q.Rows.Count - 1)
            {
                string colHeader = q.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (colHeader != "")
                {
                    string rowHeader = q.Columns[e.ColumnIndex].HeaderText.ToString();
                    string val = q.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    db.UpdatePattern(rowHeader, colHeader, val);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdQQEH4Buy_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    }

        
